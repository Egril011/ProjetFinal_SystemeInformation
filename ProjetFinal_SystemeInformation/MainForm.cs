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
        private AppFacade _appFacade;

        public MainForm(AppFacade appFacade)
        {
            InitializeComponent();
            _appFacade = appFacade;
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Welcomlabel.Text = $"Welcome, {_appFacade.CurrentUser.Username}!";
        }
        private void SignOutlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _appFacade.SignOut();

            Form1 form1 = new Form1(_appFacade);
            form1.Show();
            this.Hide();
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {

        }
    }
}