using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetFinal_SystemeInformation
{
    public partial class ProjectDetailsForm : Form
    {
        private AppServices _appServices;
        private Project _project;

        public ProjectDetailsForm(AppServices appServices, Project project)
        {
            InitializeComponent();
            this.Load += ProjectDetailsForm_Load;
            _appServices = appServices;
            _project = project;
        }

        public void ProjectDetailsForm_Load(object sender, EventArgs e)
        {
            ProjectNamelabel.Text = $"Project: {_project.Name}";

            User? leader = _appServices.Auth.GetUserById(
                _appServices.Project.GetProjectLeader(_project.Id));

            Memberlabel.Text = $"Members: {leader.Username} (Leader)";

            foreach (int memberId in _appServices.Project.GetProjectMembers(_project.Id))
            {
                if (memberId != leader.Id)
                {
                    User member = _appServices.Auth.GetUserById(memberId);
                    Memberlabel.Text += $", {member.Username}";
                }
            }

            Courselabel.Text = $"Course: {_project.Course}";
            if (!string.IsNullOrEmpty(_project.JoinCode))
            {
                JoinCodelabel.Visible = true;
                JoinCodelabel.Text = $"Join Code: {_project.JoinCode}";
            }

            RefreshTasks();
        }

        private void BacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm(_appServices);
            mainForm.Show();
            this.Close();
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            CreateTaskForm createTaskForm = new CreateTaskForm(_appServices, _project);
            createTaskForm.Show();
            this.Hide();
        }

        private void CompletTaskbutton_Click(object sender, EventArgs e)
        {
            if (ToDolistBox.SelectedItems == null &&
                InProgresslistBox.SelectedItems == null &&
                DonelistBox.SelectedItems == null)
            {
                MessageBox.Show("Please select a task to complete.");
                return;
            }

            Task task = GetSelectedTask();
            if (task == null)
                return;

            _appServices.Task.MoveTask(task);
            RefreshTasks();
        }

        private void MoveBackbutton_Click(object sender, EventArgs e)
        {
            if (ToDolistBox.SelectedItems == null &&
                InProgresslistBox.SelectedItems == null &&
                DonelistBox.SelectedItems == null)
            {
                MessageBox.Show("Please select a task to complete.");
                return;
            }

            Task task = GetSelectedTask();
            if (task == null)
                return;

            _appServices.Task.MoveTaskBack(task);
            RefreshTasks();
        }

        private Task? GetSelectedTask()
        {
            ListBox[] listBoxes = { ToDolistBox, InProgresslistBox, DonelistBox };
            foreach (ListBox listBox in listBoxes)
            {
                if (listBox.SelectedItem != null)
                    return (Task)listBox.SelectedItem;
            }

            return null;
        }

        private void RefreshTasks()
        {
            ToDolistBox.Items.Clear();
            InProgresslistBox.Items.Clear();
            DonelistBox.Items.Clear();
            List<Task> tasks = _appServices.Task.GetAllProjectTasks(_project.Id);
            foreach (Task task in tasks)
            {
                switch (task.Status)
                {
                    case TaskStatus.ToDo:
                        ToDolistBox.Items.Add(task);
                        break;
                    case TaskStatus.InProgress:
                        InProgresslistBox.Items.Add(task);
                        break;
                    case TaskStatus.Done:
                        DonelistBox.Items.Add(task);
                        break;
                }
            }
        }

        private void TaskDetailsButton_Click(object sender, EventArgs e)
        {
            if (ToDolistBox.SelectedItems == null &&
                 InProgresslistBox.SelectedItems == null &&
                 DonelistBox.SelectedItems == null)
            {
                MessageBox.Show("Please select a task to view details.");
                return;
            }

            Task task = GetSelectedTask();
            if (task == null)
                return;

            TaskDetailsForm taskDetailsForm = new TaskDetailsForm(_appServices, task);
            taskDetailsForm.Show();
            this.Hide();
        }
    }
}