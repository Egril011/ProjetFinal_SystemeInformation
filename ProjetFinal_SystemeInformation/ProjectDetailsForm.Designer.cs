namespace ProjetFinal_SystemeInformation
{
    partial class ProjectDetailsForm
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
            ProjectNamelabel = new Label();
            label1 = new Label();
            BacklinkLabel = new LinkLabel();
            Memberlabel = new Label();
            Courselabel = new Label();
            JoinCodelabel = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CreateTaskButton = new Button();
            MoveBackbutton = new Button();
            CompletTaskbutton = new Button();
            Progresslabel = new Label();
            SuspendLayout();
            // 
            // ProjectNamelabel
            // 
            ProjectNamelabel.AutoSize = true;
            ProjectNamelabel.Font = new Font("Segoe UI", 15F);
            ProjectNamelabel.Location = new Point(12, 9);
            ProjectNamelabel.Name = "ProjectNamelabel";
            ProjectNamelabel.Size = new Size(125, 28);
            ProjectNamelabel.TabIndex = 0;
            ProjectNamelabel.Text = "ProjectName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(750, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // BacklinkLabel
            // 
            BacklinkLabel.AutoSize = true;
            BacklinkLabel.LinkColor = Color.Black;
            BacklinkLabel.Location = new Point(756, 9);
            BacklinkLabel.Name = "BacklinkLabel";
            BacklinkLabel.Size = new Size(32, 15);
            BacklinkLabel.TabIndex = 2;
            BacklinkLabel.TabStop = true;
            BacklinkLabel.Text = "Back";
            BacklinkLabel.LinkClicked += BacklinkLabel_LinkClicked;
            // 
            // Memberlabel
            // 
            Memberlabel.AutoSize = true;
            Memberlabel.Font = new Font("Segoe UI", 12F);
            Memberlabel.Location = new Point(12, 106);
            Memberlabel.Name = "Memberlabel";
            Memberlabel.Size = new Size(76, 21);
            Memberlabel.TabIndex = 3;
            Memberlabel.Text = "Members";
            // 
            // Courselabel
            // 
            Courselabel.AutoSize = true;
            Courselabel.Font = new Font("Segoe UI", 12F);
            Courselabel.Location = new Point(12, 46);
            Courselabel.Name = "Courselabel";
            Courselabel.Size = new Size(62, 21);
            Courselabel.TabIndex = 4;
            Courselabel.Text = "Course:";
            // 
            // JoinCodelabel
            // 
            JoinCodelabel.AutoSize = true;
            JoinCodelabel.Font = new Font("Segoe UI", 12F);
            JoinCodelabel.Location = new Point(12, 76);
            JoinCodelabel.Name = "JoinCodelabel";
            JoinCodelabel.Size = new Size(77, 21);
            JoinCodelabel.TabIndex = 5;
            JoinCodelabel.Text = "JoinCode:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 170);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(179, 154);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(221, 170);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(179, 154);
            listBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(428, 170);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(179, 154);
            listBox3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(13, 148);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 9;
            label2.Text = "To Do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(221, 148);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 10;
            label3.Text = "In Progress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(428, 148);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 11;
            label4.Text = "Done";
            // 
            // CreateTaskButton
            // 
            CreateTaskButton.BackColor = Color.FromArgb(31, 35, 40);
            CreateTaskButton.Font = new Font("Segoe UI", 12F);
            CreateTaskButton.ForeColor = Color.White;
            CreateTaskButton.Location = new Point(22, 381);
            CreateTaskButton.Name = "CreateTaskButton";
            CreateTaskButton.Size = new Size(115, 40);
            CreateTaskButton.TabIndex = 12;
            CreateTaskButton.Text = "Create Task";
            CreateTaskButton.UseVisualStyleBackColor = false;
            CreateTaskButton.Click += CreateTaskButton_Click;
            // 
            // MoveBackbutton
            // 
            MoveBackbutton.BackColor = Color.FromArgb(31, 35, 40);
            MoveBackbutton.Font = new Font("Segoe UI", 12F);
            MoveBackbutton.ForeColor = Color.White;
            MoveBackbutton.Location = new Point(264, 381);
            MoveBackbutton.Name = "MoveBackbutton";
            MoveBackbutton.Size = new Size(115, 40);
            MoveBackbutton.TabIndex = 13;
            MoveBackbutton.Text = "Move Back";
            MoveBackbutton.UseVisualStyleBackColor = false;
            // 
            // CompletTaskbutton
            // 
            CompletTaskbutton.BackColor = Color.FromArgb(31, 35, 40);
            CompletTaskbutton.Font = new Font("Segoe UI", 12F);
            CompletTaskbutton.ForeColor = Color.White;
            CompletTaskbutton.Location = new Point(143, 381);
            CompletTaskbutton.Name = "CompletTaskbutton";
            CompletTaskbutton.Size = new Size(115, 40);
            CompletTaskbutton.TabIndex = 14;
            CompletTaskbutton.Text = "Complet Task";
            CompletTaskbutton.UseVisualStyleBackColor = false;
            // 
            // Progresslabel
            // 
            Progresslabel.AutoSize = true;
            Progresslabel.Font = new Font("Segoe UI", 10F);
            Progresslabel.Location = new Point(13, 327);
            Progresslabel.Name = "Progresslabel";
            Progresslabel.Size = new Size(65, 19);
            Progresslabel.TabIndex = 15;
            Progresslabel.Text = "Progress:";
            // 
            // ProjectDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Progresslabel);
            Controls.Add(CompletTaskbutton);
            Controls.Add(MoveBackbutton);
            Controls.Add(CreateTaskButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(JoinCodelabel);
            Controls.Add(Courselabel);
            Controls.Add(Memberlabel);
            Controls.Add(BacklinkLabel);
            Controls.Add(label1);
            Controls.Add(ProjectNamelabel);
            Name = "ProjectDetailsForm";
            Text = "ProjectDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProjectNamelabel;
        private Label label1;
        private LinkLabel BacklinkLabel;
        private Label Memberlabel;
        private Label Courselabel;
        private Label JoinCodelabel;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button CreateTaskButton;
        private Button MoveBackbutton;
        private Button CompletTaskbutton;
        private Label Progresslabel;
    }
}