namespace ProjetFinal_SystemeInformation
{
    partial class CreateTaskForm
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
            backlinkLabel = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            titleTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            LowRadioButton = new RadioButton();
            MediumRadioButton = new RadioButton();
            highRadioButton = new RadioButton();
            dueDatetimePicker = new DateTimePicker();
            SaveTaskButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(271, 28);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 1;
            label1.Text = "Create a New Task";
            // 
            // backlinkLabel
            // 
            backlinkLabel.AutoSize = true;
            backlinkLabel.LinkColor = Color.Black;
            backlinkLabel.Location = new Point(756, 9);
            backlinkLabel.Name = "backlinkLabel";
            backlinkLabel.Size = new Size(32, 15);
            backlinkLabel.TabIndex = 2;
            backlinkLabel.TabStop = true;
            backlinkLabel.Text = "Back";
            backlinkLabel.LinkClicked += backlinkLabel_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(179, 74);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(178, 121);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(179, 207);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 5;
            label4.Text = "Priority:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(179, 255);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 6;
            label5.Text = "Due Date:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(238, 82);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(217, 23);
            titleTextBox.TabIndex = 7;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(300, 126);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(321, 72);
            DescriptionTextBox.TabIndex = 8;
            // 
            // LowRadioButton
            // 
            LowRadioButton.AutoSize = true;
            LowRadioButton.Location = new Point(271, 216);
            LowRadioButton.Name = "LowRadioButton";
            LowRadioButton.Size = new Size(47, 19);
            LowRadioButton.TabIndex = 9;
            LowRadioButton.TabStop = true;
            LowRadioButton.Text = "Low";
            LowRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumRadioButton
            // 
            MediumRadioButton.AutoSize = true;
            MediumRadioButton.Location = new Point(324, 216);
            MediumRadioButton.Name = "MediumRadioButton";
            MediumRadioButton.Size = new Size(70, 19);
            MediumRadioButton.TabIndex = 10;
            MediumRadioButton.TabStop = true;
            MediumRadioButton.Text = "Medium";
            MediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // highRadioButton
            // 
            highRadioButton.AutoSize = true;
            highRadioButton.Location = new Point(400, 216);
            highRadioButton.Name = "highRadioButton";
            highRadioButton.Size = new Size(55, 19);
            highRadioButton.TabIndex = 11;
            highRadioButton.TabStop = true;
            highRadioButton.Text = "Hight";
            highRadioButton.UseVisualStyleBackColor = true;
            // 
            // dueDatetimePicker
            // 
            dueDatetimePicker.Location = new Point(282, 260);
            dueDatetimePicker.Name = "dueDatetimePicker";
            dueDatetimePicker.Size = new Size(200, 23);
            dueDatetimePicker.TabIndex = 13;
            // 
            // SaveTaskButton
            // 
            SaveTaskButton.BackColor = Color.FromArgb(31, 35, 40);
            SaveTaskButton.Font = new Font("Segoe UI", 12F);
            SaveTaskButton.ForeColor = Color.White;
            SaveTaskButton.Location = new Point(324, 301);
            SaveTaskButton.Name = "SaveTaskButton";
            SaveTaskButton.Size = new Size(115, 40);
            SaveTaskButton.TabIndex = 14;
            SaveTaskButton.Text = "Save Task";
            SaveTaskButton.UseVisualStyleBackColor = false;
            SaveTaskButton.Click += SaveTaskButton_Click;
            // 
            // CreateTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveTaskButton);
            Controls.Add(dueDatetimePicker);
            Controls.Add(highRadioButton);
            Controls.Add(MediumRadioButton);
            Controls.Add(LowRadioButton);
            Controls.Add(DescriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(backlinkLabel);
            Controls.Add(label1);
            Name = "CreateTaskForm";
            Text = "TaskDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel backlinkLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox titleTextBox;
        private TextBox DescriptionTextBox;
        private RadioButton LowRadioButton;
        private RadioButton MediumRadioButton;
        private RadioButton highRadioButton;
        private DateTimePicker dueDatetimePicker;
        private Button SaveTaskButton;
    }
}