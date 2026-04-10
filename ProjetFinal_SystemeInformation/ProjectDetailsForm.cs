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

            //Get the project leader and members
            User leader = _appServices.Auth.GetUserById(
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

            //Get the project course and join code
            Courselabel.Text = $"Course: {_project.Course}";
            if (!string.IsNullOrEmpty(_project.JoinCode))
            {
                JoinCodelabel.Text = $"Join Code: {_project.JoinCode}";
            }
        }

        private void BacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm(_appServices);
            mainForm.Show();
            this.Close();
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
           CreateTaskForm createTaskForm = new CreateTaskForm(_appServices);
            createTaskForm.Show();
            this.Hide();
        }
    }
}