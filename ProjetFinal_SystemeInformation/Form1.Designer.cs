namespace ProjetFinal_SystemeInformation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            linkLabelLogin = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(260, 35);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(260, 113);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(260, 164);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(329, 118);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(100, 23);
            EmailTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(363, 172);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(31, 35, 40);
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(329, 224);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(96, 42);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Sign in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // linkLabelLogin
            // 
            linkLabelLogin.AutoSize = true;
            linkLabelLogin.LinkColor = Color.Black;
            linkLabelLogin.Location = new Point(416, 282);
            linkLabelLogin.Name = "linkLabelLogin";
            linkLabelLogin.Size = new Size(47, 15);
            linkLabelLogin.TabIndex = 6;
            linkLabelLogin.TabStop = true;
            linkLabelLogin.Text = "Sign up";
            linkLabelLogin.LinkClicked += linkLabelLogin_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 282);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 7;
            label4.Text = "Don't have an account?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(linkLabelLogin);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private LinkLabel linkLabelLogin;
        private Label label4;
    }
}
