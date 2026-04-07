namespace ProjetFinal_SystemeInformation
{
    partial class JoinCode
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
            BacklinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // BacklinkLabel
            // 
            BacklinkLabel.AutoSize = true;
            BacklinkLabel.LinkColor = Color.Black;
            BacklinkLabel.Location = new Point(756, 9);
            BacklinkLabel.Name = "BacklinkLabel";
            BacklinkLabel.Size = new Size(32, 15);
            BacklinkLabel.TabIndex = 0;
            BacklinkLabel.TabStop = true;
            BacklinkLabel.Text = "Back";
            BacklinkLabel.LinkClicked += BacklinkLabel_LinkClicked;
            // 
            // JoinCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BacklinkLabel);
            Name = "JoinCode";
            Text = "JoinCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel BacklinkLabel;
    }
}