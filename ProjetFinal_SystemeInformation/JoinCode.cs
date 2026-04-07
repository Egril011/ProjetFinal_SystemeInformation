using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetFinal_SystemeInformation
{
    public partial class JoinCode : Form
    {
        private AppServices _appServices;

        public JoinCode(AppServices appServices)
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
    }
}