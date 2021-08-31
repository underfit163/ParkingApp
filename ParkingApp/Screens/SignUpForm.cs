using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class SignInForm : Form
    {
        private FileWorkerWithUsers fileWorker = new FileWorkerWithUsers();

        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String password = passwordTextBox.Text;
            String repeatPassword = repeatPasswordTextBox.Text;
            if (isCorrectData(login, password, repeatPassword))
            {
                if (!isExist(login, getUsers()))
                {
                    if (radioButton1.Checked)
                    {
                        addToTheFile(createNewUser(login, password, Globals.ADMINISTRATOR));
                        AdministratorSignInForm administratorForm = new AdministratorSignInForm();
                        administratorForm.Show();
                    }
                    else
                    {
                        addToTheFile(createNewUser(login, password, Globals.MANAGER));
                        ManagerSignInForm managerSignInForm = new ManagerSignInForm();
                        managerSignInForm.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован в приложении", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //создает нового пользователя
        private User createNewUser(String login, String password, String type)
        {
            User newUser = new User(login, password, type);
            return newUser;
        }

        //добавляет нового пользователя в конец файла
        private void addToTheFile(User user)
        {
            fileWorker.addUserToFile(user);
        }

        //todo реализовать проверку валидности введенных данных (длина, символы)
        private bool isCorrectData(String login, String password, String repeatPassword)
        {
            if (login.Length > 2 && password.Length > 2)
            {
                if (password.Equals(repeatPassword))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Введенные пароли должны совпадать", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Логин и пароль должны иметь как минимум 3 символа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //вернуть тру если пользователь с таким именем найден
        private bool isExist(String login, List<User> users)
        {
            if(users == null)
            {
                return false;
            }
            else
            {
                foreach (User user in users)
                {
                    if (user.getLogin().Equals(login))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        //считать всех пользователей из файла
        private List<User> getUsers()
        {
            return fileWorker.readUsers();
        }

        //Разрешены только буквы и цифры для логина и пароля
        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void backToMainScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }


        bool isChecked = false;
     
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !isChecked)
                radioButton1.Checked = false;
            else
            {
                radioButton1.Checked = true;
                isChecked = false;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioButton1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar.Equals('*'))
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
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
