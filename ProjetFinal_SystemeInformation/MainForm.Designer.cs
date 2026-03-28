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
            linkLabelLogout = new LinkLabel();
            Welcomlabel = new Label();
            CreateProjectButton = new Button();
            JoinProjectbutton = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabelLogout
            // 
            linkLabelLogout.AutoSize = true;
            linkLabelLogout.LinkColor = Color.Black;
            linkLabelLogout.Location = new Point(743, 9);
            linkLabelLogout.Name = "linkLabelLogout";
            linkLabelLogout.Size = new Size(45, 15);
            linkLabelLogout.TabIndex = 0;
            linkLabelLogout.TabStop = true;
            linkLabelLogout.Text = "Logout";
            linkLabelLogout.LinkClicked += linkLabelLogout_LinkClicked;
            // 
            // Welcomlabel
            // 
            Welcomlabel.AutoSize = true;
            Welcomlabel.Font = new Font("Segoe UI", 20F);
            Welcomlabel.Location = new Point(311, 33);
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
            CreateProjectButton.Location = new Point(167, 93);
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
            JoinProjectbutton.Location = new Point(369, 93);
            JoinProjectbutton.Name = "JoinProjectbutton";
            JoinProjectbutton.Size = new Size(183, 42);
            JoinProjectbutton.TabIndex = 7;
            JoinProjectbutton.Text = "Join Project";
            JoinProjectbutton.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 169);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(578, 169);
            listBox1.TabIndex = 8;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(JoinProjectbutton);
            Controls.Add(CreateProjectButton);
            Controls.Add(Welcomlabel);
            Controls.Add(linkLabelLogout);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabelLogout;
        private Label Welcomlabel;
        private Button CreateProjectButton;
        private Button JoinProjectbutton;
        private ListBox listBox1;
        private Label label1;
    }
}