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

        public CreateTaskForm(AppServices appServices)
        {
            InitializeComponent();
            this.Load += CreateTaskForm_Load;
            _appServices = appServices;
        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            dueDatetimePicker.MinDate = DateTime.Now;
        }

        private void backlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm(_appServices);
            mainForm.Show();
            this.Close();
        }

        private void SaveTaskButton_Click(object sender, EventArgs e)
        {
            if(titleTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter a title for the task.");
                return;
            }


        }
    }
}
