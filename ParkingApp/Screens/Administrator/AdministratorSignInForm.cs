using System;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class AdministratorSignInForm : Form
    {
        private static String ADMINISTRATOR = "Administrator";


        public AdministratorSignInForm()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String password = passwordTextBox.Text;
            UserValidator userValidator = new UserValidator();

            if (userValidator.isExisted(login, password, ADMINISTRATOR))
            {
                this.Hide();
                AdministratorMainScreen administratorMainScreen = new AdministratorMainScreen();
                administratorMainScreen.Show();
            }
            else
            {
                MessageBox.Show("Пользователя с введенными данными не найдено", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backToMainScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        private void validation(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void preventResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void shutDownApplication(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
