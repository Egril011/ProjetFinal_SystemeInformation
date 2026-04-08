namespace ProjetFinal_SystemeInformation
{
    partial class JoinCodeForm
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
            label1 = new Label();
            JointextBox = new TextBox();
            JoinButton = new Button();
            SuspendLayout();
            // 
            // BacklinkLabel
            // 
            BacklinkLabel.AutoSize = true;
            BacklinkLabel.LinkColor = Color.Black;
            BacklinkLabel.Location = new Point(546, 9);
            BacklinkLabel.Name = "BacklinkLabel";
            BacklinkLabel.Size = new Size(32, 15);
            BacklinkLabel.TabIndex = 0;
            BacklinkLabel.TabStop = true;
            BacklinkLabel.Text = "Back";
            BacklinkLabel.LinkClicked += BacklinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(91, 100);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 1;
            label1.Text = "Join code:";
            // 
            // JointextBox
            // 
            JointextBox.Location = new Point(196, 105);
            JointextBox.Name = "JointextBox";
            JointextBox.Size = new Size(183, 23);
            JointextBox.TabIndex = 2;
            // 
            // JoinButton
            // 
            JoinButton.BackColor = Color.FromArgb(31, 35, 40);
            JoinButton.Font = new Font("Segoe UI", 12F);
            JoinButton.ForeColor = Color.White;
            JoinButton.Location = new Point(229, 158);
            JoinButton.Name = "JoinButton";
            JoinButton.Size = new Size(115, 40);
            JoinButton.TabIndex = 7;
            JoinButton.Text = "Join";
            JoinButton.UseVisualStyleBackColor = false;
            JoinButton.Click += JoinButton_Click;
            // 
            // JoinCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 310);
            Controls.Add(JoinButton);
            Controls.Add(JointextBox);
            Controls.Add(label1);
            Controls.Add(BacklinkLabel);
            Name = "JoinCode";
            Text = "JoinCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel BacklinkLabel;
        private Label label1;
        private TextBox JointextBox;
        private Button JoinButton;
    }
}