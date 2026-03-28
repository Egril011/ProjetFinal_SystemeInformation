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
        private User _currentUser;

        public MainForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Welcomlabel.Text = $"Welcome, {_currentUser.Username}!";
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}