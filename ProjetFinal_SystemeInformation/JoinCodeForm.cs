using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetFinal_SystemeInformation
{
    public partial class JoinCodeForm : Form
    {
        private AppServices _appServices;

        public JoinCodeForm(AppServices appServices)
        {
            InitializeComponent();
            _appServices = appServices;
        }

        private void BacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm(_appServices);
            mainForm.Show();
            this.Close();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            if(JointextBox.Text == String.Empty)
            {
               MessageBox.Show("Please enter a join code.");
               return;
            }

            
            if (_appServices.Project.JoinProject(JointextBox.Text,
                _appServices.Auth.CurrentUser.Id))
            {
                MessageBox.Show("You have successfully joined the project!");
                MainForm mainForm = new MainForm(_appServices);
                mainForm.Show();
                this.Close();
                return;
            }

            MessageBox.Show("Invalid join code or you are already a member of this project.");
        }
    }
}