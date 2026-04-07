using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetFinal_SystemeInformation
{
    public partial class MainForm : Form
    {
        private AppServices _appServices;

        public MainForm(AppServices appServices)
        {
            InitializeComponent();
            _appServices = appServices;
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Welcomlabel.Text = $"Welcome, {_appServices.Auth.CurrentUser.Username}!";

            ProjectslistBox.Items.Clear();

            List<Project> projects = _appServices.Project.GetProjectsByUserId(
                _appServices.Auth.CurrentUser.Id);

            if(projects.Count == 0)
            {
                ProjectslistBox.Items.Add("Any projects yet.");
                ProjectslistBox.Enabled = false; 
                return;
            }

            ProjectslistBox.Enabled = true;
            foreach (var project in projects)
            {
                ProjectslistBox.Items.Add(project);
            }
        }

        private void SignOutlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _appServices.Auth.SignOut();

            Form1 form1 = new Form1(_appServices);
            form1.Show();
            this.Hide();
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            CreateProjectForm createProjectForm = new CreateProjectForm(_appServices);
            createProjectForm.Show();
            this.Hide();
        }

        private void JoinProjectbutton_Click(object sender, EventArgs e)
        {
            JoinCode joinCodeForm = new JoinCode(_appServices);
            joinCodeForm.Show();
            this.Hide();
        }
    }
}