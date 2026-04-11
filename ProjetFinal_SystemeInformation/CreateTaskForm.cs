using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetFinal_SystemeInformation
{
    public partial class CreateTaskForm : Form
    {
        private AppServices _appServices;
        private Project _project;

        public CreateTaskForm(AppServices appServices, Project project)
        {
            InitializeComponent();
            this.Load += CreateTaskForm_Load;
            _appServices = appServices;
            _project = project;
        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            dueDatetimePicker.MinDate = DateTime.Now;
            MediumRadioButton.Checked = true;
        }

        private void backlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm(_appServices);
            mainForm.Show();
            this.Close();
        }

        private void SaveTaskButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter a title for the task.");
                return;
            } 

            Task task = new Task(
                _project.Id,
                _appServices.Auth.CurrentUser.Id,
                titleTextBox.Text,
                DescriptionTextBox.Text,
                GetSelectedPriority(),
                TaskStatus.ToDo,
                dueDatetimePicker.Value);

            if (_appServices.Task.CreateTask(task))
            {
                MessageBox.Show("Task created successfully.");
                ProjectDetailsForm projectDetailsForm = new ProjectDetailsForm(_appServices, _project);
                projectDetailsForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create task.");
            }
        }

        private TaskPriority GetSelectedPriority()
        {
            if (LowRadioButton.Checked)
                return TaskPriority.Low;
            else if (MediumRadioButton.Checked)
                return TaskPriority.Medium;
            else if (hightRadioButton.Checked)
                return TaskPriority.High;
            else
                return TaskPriority.Medium;
        }
    }
}
