namespace ProjetFinal_SystemeInformation
{
    partial class TaskDetailsForm
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
            Titlelabel = new Label();
            DueDatelabel = new Label();
            Statuslabel = new Label();
            Prioritylabel = new Label();
            Descriptionlabel = new Label();
            BacklinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // Titlelabel
            // 
            Titlelabel.AutoSize = true;
            Titlelabel.Font = new Font("Segoe UI", 15F);
            Titlelabel.Location = new Point(12, 9);
            Titlelabel.Name = "Titlelabel";
            Titlelabel.Size = new Size(100, 28);
            Titlelabel.TabIndex = 1;
            Titlelabel.Text = "TaskName";
            // 
            // DueDatelabel
            // 
            DueDatelabel.AutoSize = true;
            DueDatelabel.Font = new Font("Segoe UI", 12F);
            DueDatelabel.Location = new Point(12, 151);
            DueDatelabel.Name = "DueDatelabel";
            DueDatelabel.Size = new Size(70, 21);
            DueDatelabel.TabIndex = 8;
            DueDatelabel.Text = "DueDate";
            // 
            // Statuslabel
            // 
            Statuslabel.AutoSize = true;
            Statuslabel.Font = new Font("Segoe UI", 12F);
            Statuslabel.Location = new Point(12, 118);
            Statuslabel.Name = "Statuslabel";
            Statuslabel.Size = new Size(52, 21);
            Statuslabel.TabIndex = 7;
            Statuslabel.Text = "Status";
            // 
            // Prioritylabel
            // 
            Prioritylabel.AutoSize = true;
            Prioritylabel.Font = new Font("Segoe UI", 12F);
            Prioritylabel.Location = new Point(12, 82);
            Prioritylabel.Name = "Prioritylabel";
            Prioritylabel.Size = new Size(61, 21);
            Prioritylabel.TabIndex = 6;
            Prioritylabel.Text = "Priority";
            // 
            // Descriptionlabel
            // 
            Descriptionlabel.AutoSize = true;
            Descriptionlabel.Font = new Font("Segoe UI", 12F);
            Descriptionlabel.Location = new Point(12, 49);
            Descriptionlabel.Name = "Descriptionlabel";
            Descriptionlabel.Size = new Size(89, 21);
            Descriptionlabel.TabIndex = 5;
            Descriptionlabel.Text = "Description";
            // 
            // BacklinkLabel
            // 
            BacklinkLabel.AutoSize = true;
            BacklinkLabel.LinkColor = Color.Black;
            BacklinkLabel.Location = new Point(756, 9);
            BacklinkLabel.Name = "BacklinkLabel";
            BacklinkLabel.Size = new Size(32, 15);
            BacklinkLabel.TabIndex = 9;
            BacklinkLabel.TabStop = true;
            BacklinkLabel.Text = "Back";
            BacklinkLabel.LinkClicked += BacklinkLabel_LinkClicked;
            // 
            // TaskDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BacklinkLabel);
            Controls.Add(DueDatelabel);
            Controls.Add(Statuslabel);
            Controls.Add(Prioritylabel);
            Controls.Add(Descriptionlabel);
            Controls.Add(Titlelabel);
            Controls.Add(label1);
            Name = "TaskDetailsForm";
            Text = "TaskDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Titlelabel;
        private Label DueDatelabel;
        private Label Statuslabel;
        private Label Prioritylabel;
        private Label Descriptionlabel;
        private LinkLabel BacklinkLabel;
    }
}