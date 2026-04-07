using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetFinal_SystemeInformation
{
    public partial class CreateProjectForm : Form
    {
        private AppServices _appServices;

        public CreateProjectForm(AppServices appServices)
        {
            InitializeComponent();
            _appServices = appServices;
            this.Load += CreateProjectForm_Load;
        }

        private void CreateProjectForm_Load(object sender, EventArgs e)
        {
            PrivateradioButton.Checked = true; 
        }

        private void PrivateradioButton_CheckedChanged(object sender, EventArgs e)
        {
            JoinCodeLabel.Visible = false;
            Codelabel.Visible = false;
        }
        private void PublicradioButton_CheckedChanged(object sender, EventArgs e)
        {
            JoinCodeLabel.Visible = true;
            Codelabel.Visible = true;
            Codelabel.Text = _appServices.Project.GenerateJoinCode().ToString();
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            if(ProjectNametextBox.Text == String.Empty || 
                CoursetextBox.Text == String.Empty)
            {
                Project project = new Project
                {
                    Name = ProjectNametextBox.Text,
                    Course = CoursetextBox.Text,
                    UserId = _appServices.Auth.CurrentUser.Id,
                    JoinCode = PublicradioButton.Checked ? Codelabel.Text : null,
                    Created = DateTime.Now
                };
            }
        }

        private void BacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm(_appServices);
            mainForm.Show();
            this.Close();
        }
    }
}