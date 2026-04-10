namespace ProjetFinal_SystemeInformation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SignOutlinkLabel = new LinkLabel();
            Welcomlabel = new Label();
            CreateProjectButton = new Button();
            JoinProjectbutton = new Button();
            ProjectslistBox = new ListBox();
            label1 = new Label();
            OpenProjectbutton = new Button();
            DeleteProjectButton1 = new Button();
            SuspendLayout();
            // 
            // SignOutlinkLabel
            // 
            SignOutlinkLabel.AutoSize = true;
            SignOutlinkLabel.Font = new Font("Segoe UI", 9F);
            SignOutlinkLabel.LinkColor = Color.Black;
            SignOutlinkLabel.Location = new Point(737, 9);
            SignOutlinkLabel.Name = "SignOutlinkLabel";
            SignOutlinkLabel.Size = new Size(51, 15);
            SignOutlinkLabel.TabIndex = 0;
            SignOutlinkLabel.TabStop = true;
            SignOutlinkLabel.Text = "Sign out";
            SignOutlinkLabel.LinkClicked += SignOutlinkLabel_LinkClicked;
            // 
            // Welcomlabel
            // 
            Welcomlabel.AutoSize = true;
            Welcomlabel.Font = new Font("Segoe UI", 20F);
            Welcomlabel.Location = new Point(12, 30);
            Welcomlabel.Name = "Welcomlabel";
            Welcomlabel.Size = new Size(90, 37);
            Welcomlabel.TabIndex = 1;
            Welcomlabel.Text = "label1";
            // 
            // CreateProjectButton
            // 
            CreateProjectButton.BackColor = Color.FromArgb(31, 35, 40);
            CreateProjectButton.Font = new Font("Segoe UI", 12F);
            CreateProjectButton.ForeColor = Color.White;
            CreateProjectButton.Location = new Point(12, 81);
            CreateProjectButton.Name = "CreateProjectButton";
            CreateProjectButton.Size = new Size(183, 42);
            CreateProjectButton.TabIndex = 6;
            CreateProjectButton.Text = "Create Project";
            CreateProjectButton.UseVisualStyleBackColor = false;
            CreateProjectButton.Click += CreateProjectButton_Click;
            // 
            // JoinProjectbutton
            // 
            JoinProjectbutton.BackColor = Color.FromArgb(31, 35, 40);
            JoinProjectbutton.Font = new Font("Segoe UI", 12F);
            JoinProjectbutton.ForeColor = Color.White;
            JoinProjectbutton.Location = new Point(201, 81);
            JoinProjectbutton.Name = "JoinProjectbutton";
            JoinProjectbutton.Size = new Size(183, 42);
            JoinProjectbutton.TabIndex = 7;
            JoinProjectbutton.Text = "Join Project";
            JoinProjectbutton.UseVisualStyleBackColor = false;
            JoinProjectbutton.Click += JoinProjectbutton_Click;
            // 
            // ProjectslistBox
            // 
            ProjectslistBox.Font = new Font("Segoe UI", 10F);
            ProjectslistBox.FormattingEnabled = true;
            ProjectslistBox.Location = new Point(12, 169);
            ProjectslistBox.Name = "ProjectslistBox";
            ProjectslistBox.Size = new Size(578, 140);
            ProjectslistBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 145);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 9;
            label1.Text = "My projects";
            // 
            // OpenProjectbutton
            // 
            OpenProjectbutton.BackColor = Color.FromArgb(31, 35, 40);
            OpenProjectbutton.Font = new Font("Segoe UI", 12F);
            OpenProjectbutton.ForeColor = Color.White;
            OpenProjectbutton.Location = new Point(31, 356);
            OpenProjectbutton.Name = "OpenProjectbutton";
            OpenProjectbutton.Size = new Size(183, 48);
            OpenProjectbutton.TabIndex = 10;
            OpenProjectbutton.Text = "Open Selected Project";
            OpenProjectbutton.UseVisualStyleBackColor = false;
            OpenProjectbutton.Click += OpenProjectbutton_Click;
            // 
            // DeleteProjectButton1
            // 
            DeleteProjectButton1.BackColor = Color.FromArgb(31, 35, 40);
            DeleteProjectButton1.Font = new Font("Segoe UI", 12F);
            DeleteProjectButton1.ForeColor = Color.White;
            DeleteProjectButton1.Location = new Point(220, 356);
            DeleteProjectButton1.Name = "DeleteProjectButton1";
            DeleteProjectButton1.Size = new Size(202, 48);
            DeleteProjectButton1.TabIndex = 11;
            DeleteProjectButton1.Text = "Delete Selected Project";
            DeleteProjectButton1.UseVisualStyleBackColor = false;
            DeleteProjectButton1.Click += DeleteProjectButton1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteProjectButton1);
            Controls.Add(OpenProjectbutton);
            Controls.Add(label1);
            Controls.Add(ProjectslistBox);
            Controls.Add(JoinProjectbutton);
            Controls.Add(CreateProjectButton);
            Controls.Add(Welcomlabel);
            Controls.Add(SignOutlinkLabel);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel SignOutlinkLabel;
        private Label Welcomlabel;
        private Button CreateProjectButton;
        private Button JoinProjectbutton;
        private ListBox ProjectslistBox;
        private Label label1;
        private Button OpenProjectbutton;
        private Button DeleteProjectButton1;
    }
}