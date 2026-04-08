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
            SuspendLayout();
            // 
            // ProjectNamelabel
            // 
            ProjectNamelabel.AutoSize = true;
            ProjectNamelabel.Font = new Font("Segoe UI", 15F);
            ProjectNamelabel.Location = new Point(12, 9);
            ProjectNamelabel.Name = "ProjectNamelabel";
            ProjectNamelabel.Size = new Size(65, 28);
            ProjectNamelabel.TabIndex = 0;
            ProjectNamelabel.Text = "label1";
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
            Memberlabel.Location = new Point(12, 37);
            Memberlabel.Name = "Memberlabel";
            Memberlabel.Size = new Size(52, 21);
            Memberlabel.TabIndex = 3;
            Memberlabel.Text = "label2";
            // 
            // ProjectDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}