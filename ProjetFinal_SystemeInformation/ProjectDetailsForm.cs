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

            User leader = _appServices.Auth.GetUserById(
                _appServices.Project.GetProjectLeader(_project.Id));

            Memberlabel.Text = $"Project members: {leader.Username}(Leader)";

            foreach (int memberId in _appServices.Project.GetProjectMembers(_project.Id))
            {
                if (memberId != leader.Id)
                {
                    User member = _appServices.Auth.GetUserById(memberId);
                    Memberlabel.Text += $", {member.Username}";
                }
            }

            Memberlabel.Text += "(Members)";
        }

        private void BacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm(_appServices);
            mainForm.Show();
            this.Close();
        }
    }
}