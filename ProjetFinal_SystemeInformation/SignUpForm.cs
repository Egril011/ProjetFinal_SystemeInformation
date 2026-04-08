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
        private AppServices _appServices;

        public SignUpForm(AppServices appServices)
        {
            InitializeComponent();
            _appServices = appServices;
        }

        private void SignInlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1(_appServices);
            form1.Show();
            this.Close();
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

            if (_appServices.Auth.CreateUser(user)) 
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