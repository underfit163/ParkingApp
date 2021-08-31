using System;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class ManagerSignInForm : Form
    {
        private static String MANAGER = "Manager";

        public ManagerSignInForm()
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

            if(userValidator.isExisted(login, password, MANAGER))
            {
                this.Hide();
                ManagerMainScreen managerMainScreen = new ManagerMainScreen();
                managerMainScreen.Show();
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
