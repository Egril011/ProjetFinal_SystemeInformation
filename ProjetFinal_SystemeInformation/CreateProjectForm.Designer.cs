namespace ProjetFinal_SystemeInformation
{
    partial class CreateProjectForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ProjectNametextBox = new TextBox();
            CoursetextBox = new TextBox();
            BacklinkLabel = new LinkLabel();
            CreateProjectButton = new Button();
            PrivateradioButton = new RadioButton();
            PublicradioButton = new RadioButton();
            label4 = new Label();
            JoinCodeLabel = new Label();
            Codelabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(255, 38);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 0;
            label1.Text = "Create a New Project";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(152, 95);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 1;
            label2.Text = "Project Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(152, 132);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 2;
            label3.Text = "Course:";
            // 
            // ProjectNametextBox
            // 
            ProjectNametextBox.Location = new Point(292, 100);
            ProjectNametextBox.Name = "ProjectNametextBox";
            ProjectNametextBox.Size = new Size(227, 23);
            ProjectNametextBox.TabIndex = 3;
            // 
            // CoursetextBox
            // 
            CoursetextBox.Location = new Point(234, 137);
            CoursetextBox.Name = "CoursetextBox";
            CoursetextBox.Size = new Size(285, 23);
            CoursetextBox.TabIndex = 4;
            // 
            // BacklinkLabel
            // 
            BacklinkLabel.AutoSize = true;
            BacklinkLabel.Font = new Font("Segoe UI", 9F);
            BacklinkLabel.LinkColor = Color.Black;
            BacklinkLabel.Location = new Point(756, 9);
            BacklinkLabel.Name = "BacklinkLabel";
            BacklinkLabel.Size = new Size(32, 15);
            BacklinkLabel.TabIndex = 6;
            BacklinkLabel.TabStop = true;
            BacklinkLabel.Text = "Back";
            BacklinkLabel.TextAlign = ContentAlignment.TopCenter;
            BacklinkLabel.LinkClicked += BacklinkLabel_LinkClicked;
            // 
            // CreateProjectButton
            // 
            CreateProjectButton.BackColor = Color.FromArgb(31, 35, 40);
            CreateProjectButton.Font = new Font("Segoe UI", 12F);
            CreateProjectButton.ForeColor = Color.White;
            CreateProjectButton.Location = new Point(292, 309);
            CreateProjectButton.Name = "CreateProjectButton";
            CreateProjectButton.Size = new Size(182, 42);
            CreateProjectButton.TabIndex = 7;
            CreateProjectButton.Text = "Create Project";
            CreateProjectButton.UseVisualStyleBackColor = false;
            CreateProjectButton.Click += CreateProjectButton_Click;
            // 
            // PrivateradioButton
            // 
            PrivateradioButton.AutoSize = true;
            PrivateradioButton.Font = new Font("Segoe UI", 12F);
            PrivateradioButton.Location = new Point(172, 212);
            PrivateradioButton.Name = "PrivateradioButton";
            PrivateradioButton.Size = new Size(76, 25);
            PrivateradioButton.TabIndex = 9;
            PrivateradioButton.TabStop = true;
            PrivateradioButton.Text = "Private";
            PrivateradioButton.UseVisualStyleBackColor = true;
            PrivateradioButton.CheckedChanged += PrivateradioButton_CheckedChanged;
            // 
            // PublicradioButton
            // 
            PublicradioButton.AutoSize = true;
            PublicradioButton.Font = new Font("Segoe UI", 12F);
            PublicradioButton.Location = new Point(172, 243);
            PublicradioButton.Name = "PublicradioButton";
            PublicradioButton.Size = new Size(70, 25);
            PublicradioButton.TabIndex = 10;
            PublicradioButton.TabStop = true;
            PublicradioButton.Text = "Public";
            PublicradioButton.UseVisualStyleBackColor = true;
            PublicradioButton.CheckedChanged += PublicradioButton_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(152, 181);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 11;
            label4.Text = "Visibility:";
            // 
            // JoinCodeLabel
            // 
            JoinCodeLabel.AutoSize = true;
            JoinCodeLabel.Font = new Font("Segoe UI", 12F);
            JoinCodeLabel.Location = new Point(205, 271);
            JoinCodeLabel.Name = "JoinCodeLabel";
            JoinCodeLabel.Size = new Size(81, 21);
            JoinCodeLabel.TabIndex = 12;
            JoinCodeLabel.Text = "Join Code:";
            // 
            // Codelabel
            // 
            Codelabel.AutoSize = true;
            Codelabel.Font = new Font("Segoe UI", 12F);
            Codelabel.Location = new Point(292, 271);
            Codelabel.Name = "Codelabel";
            Codelabel.Size = new Size(52, 21);
            Codelabel.TabIndex = 13;
            Codelabel.Text = "label6";
            // 
            // CreateProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Codelabel);
            Controls.Add(JoinCodeLabel);
            Controls.Add(label4);
            Controls.Add(PublicradioButton);
            Controls.Add(PrivateradioButton);
            Controls.Add(CreateProjectButton);
            Controls.Add(BacklinkLabel);
            Controls.Add(CoursetextBox);
            Controls.Add(ProjectNametextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateProjectForm";
            Text = "CreateProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ProjectNametextBox;
        private TextBox CoursetextBox;
        private LinkLabel BacklinkLabel;
        private Button CreateProjectButton;
        private RadioButton PrivateradioButton;
        private RadioButton PublicradioButton;
        private Label label4;
        private Label JoinCodeLabel;
        private Label Codelabel;
    }
}