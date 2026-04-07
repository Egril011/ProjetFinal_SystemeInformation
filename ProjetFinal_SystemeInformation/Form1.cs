namespace ProjetFinal_SystemeInformation
{
    public partial class Form1 : Form
    {
        private AppServices _appServices;

        public Form1(AppServices appServices)
        {
            InitializeComponent();
            _appServices = appServices;
        }

        private void SignInButton_Click_1(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == String.Empty || PasswordTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!_appServices.Auth.SignIn(EmailTextBox.Text, PasswordTextBox.Text))
            {
                MessageBox.Show("Invalid email or password.");
                return;
            }

            MainForm mainForm = new MainForm(_appServices);
            mainForm.Show();
            this.Hide();
        }

        private void SignUplinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUp = new SignUpForm(_appServices);
            signUp.Show();
            this.Hide();
        }
    }
}