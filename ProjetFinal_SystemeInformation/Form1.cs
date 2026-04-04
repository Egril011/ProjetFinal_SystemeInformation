namespace ProjetFinal_SystemeInformation
{
    public partial class Form1 : Form
    {
        private AppFacade _appFacade;

        public Form1(AppFacade appFacade)
        {
            InitializeComponent();
            _appFacade = appFacade;
        }

        private void SignInButton_Click_1(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == String.Empty || PasswordTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!_appFacade.SignIn(EmailTextBox.Text, PasswordTextBox.Text))
            {
                MessageBox.Show("Invalid email or password.");
                return;
            }

            MainForm mainForm = new MainForm(_appFacade);
            mainForm.Show();
            this.Hide();
        }

        private void SignUplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUp = new SignUpForm(_appFacade);
            signUp.Show();
            this.Hide();
        }
    }
}