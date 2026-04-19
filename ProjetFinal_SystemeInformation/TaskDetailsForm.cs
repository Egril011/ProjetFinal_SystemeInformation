using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetFinal_SystemeInformation
{
    public partial class TaskDetailsForm : Form
    {
        AppServices _appServices;
        Task _task;

        public TaskDetailsForm(AppServices appServices, Task task)
        {
            InitializeComponent();
            this.Load += TaskDetailsForm_Load;
            _appServices = appServices;
            _task = task;
        }

        private void TaskDetailsForm_Load(object sender, EventArgs e)
        {
            Titlelabel.Text = $"Title: {_task.Title}";
            Descriptionlabel.Text = $"Description: {_task.Description}";
            Prioritylabel.Text = $"Priority: {_task.Priority}";
            Statuslabel.Text = $"Status: {_task.Status}";
            DueDatelabel.Text = $"Due Date: {_task.DueDate.ToShortDateString()}";
        }

        private void BacklinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Project? project = _appServices.Project.GetProjectById(_task.ProjectId);
            if (project == null)
                return;

            ProjectDetailsForm projectDetailsForm = new ProjectDetailsForm(_appServices,
                project);
            projectDetailsForm.Show();
            this.Close();
        }
    }
}
