namespace ProjetFinal_SystemeInformation
{
    partial class SignUpForm
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
            Username = new Label();
            Email = new Label();
            Password = new Label();
            usernametextBox = new TextBox();
            emailtextBox = new TextBox();
            passwordtextBox = new TextBox();
            CreateAccountButton = new Button();
            SignInlinkLabel = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F);
            Username.ForeColor = Color.Black;
            Username.Location = new Point(247, 256);
            Username.Name = "Username";
            Username.Size = new Size(84, 21);
            Username.TabIndex = 0;
            Username.Text = "Username:";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F);
            Email.ForeColor = Color.Black;
            Email.Location = new Point(247, 118);
            Email.Name = "Email";
            Email.Size = new Size(51, 21);
            Email.TabIndex = 1;
            Email.Text = "Email:";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F);
            Password.ForeColor = Color.Black;
            Password.Location = new Point(247, 188);
            Password.Name = "Password";
            Password.Size = new Size(79, 21);
            Password.TabIndex = 2;
            Password.Text = "Password:";
            // 
            // usernametextBox
            // 
            usernametextBox.Font = new Font("Segoe UI", 12F);
            usernametextBox.Location = new Point(247, 280);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(323, 29);
            usernametextBox.TabIndex = 3;
            // 
            // emailtextBox
            // 
            emailtextBox.Font = new Font("Segoe UI", 12F);
            emailtextBox.Location = new Point(247, 149);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(323, 29);
            emailtextBox.TabIndex = 4;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Font = new Font("Segoe UI", 12F);
            passwordtextBox.Location = new Point(247, 212);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(323, 29);
            passwordtextBox.TabIndex = 5;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.BackColor = Color.FromArgb(31, 35, 0);
            CreateAccountButton.Font = new Font("Sans Serif Collection", 12F);
            CreateAccountButton.ForeColor = SystemColors.ButtonHighlight;
            CreateAccountButton.Location = new Point(247, 331);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(344, 47);
            CreateAccountButton.TabIndex = 6;
            CreateAccountButton.Text = "Create account";
            CreateAccountButton.UseVisualStyleBackColor = false;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // SignInlinkLabel
            // 
            SignInlinkLabel.AutoSize = true;
            SignInlinkLabel.LinkColor = Color.Black;
            SignInlinkLabel.Location = new Point(745, 9);
            SignInlinkLabel.Name = "SignInlinkLabel";
            SignInlinkLabel.Size = new Size(43, 15);
            SignInlinkLabel.TabIndex = 7;
            SignInlinkLabel.TabStop = true;
            SignInlinkLabel.Text = "Sign In";
            SignInlinkLabel.LinkClicked += SignInlinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(597, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 8;
            label1.Text = "Already have an account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(247, 60);
            label2.Name = "label2";
            label2.Size = new Size(111, 37);
            label2.TabIndex = 9;
            label2.Text = "Sign Up";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SignInlinkLabel);
            Controls.Add(CreateAccountButton);
            Controls.Add(passwordtextBox);
            Controls.Add(emailtextBox);
            Controls.Add(usernametextBox);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Username);
            ForeColor = Color.White;
            Name = "SignUpForm";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Email;
        private Label Password;
        private TextBox usernametextBox;
        private TextBox emailtextBox;
        private TextBox passwordtextBox;
        private Button CreateAccountButton;
        private LinkLabel SignInlinkLabel;
        private Label label1;
        private Label label2;
    }
}