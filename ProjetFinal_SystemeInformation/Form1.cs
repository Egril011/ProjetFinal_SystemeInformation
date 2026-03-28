namespace ProjetFinal_SystemeInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == String.Empty || PasswordTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            AppFacade appFacade = new AppFacade();
            User user = appFacade.SignIn(EmailTextBox.Text, PasswordTextBox.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid email or password.");
                return;
            }

            MainForm mainForm = new MainForm(user);
            mainForm.Show();
            this.Hide();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }
    }
}