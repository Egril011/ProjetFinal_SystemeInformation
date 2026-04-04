using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetFinal_SystemeInformation
{
    public partial class SignUpForm : Form
    {
        private AppFacade _appFacade;

        public SignUpForm(AppFacade appFacade)
        {
            InitializeComponent();
            _appFacade = appFacade;
        }

        private void SignInlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1(_appFacade);
            form1.Show();
            this.Hide();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if(emailtextBox.Text == String.Empty || passwordtextBox.Text == String.Empty ||
                usernametextBox.Text == String.Empty)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            User user = new User
            {
                Email = emailtextBox.Text,
                Password = passwordtextBox.Text,
                Username = usernametextBox.Text
            };

            if (_appFacade.CreateUser(user)) 
            {
                MessageBox.Show("Account created successfully");
            }
            else
            {
                MessageBox.Show("Accound alerady created");
            } 
        }
    }
}