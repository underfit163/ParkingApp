using System;
using System.Windows.Forms;
using ParkingApp.Screens;

namespace ParkingApp
{
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();
        }

        private void aboutSystemBtn_Click(object sender, EventArgs e)
        {
            AboutSystemForm aboutSystemForm = new AboutSystemForm();
            aboutSystemForm.Show();
            this.Hide();
        }

        private void administratorBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorSignInForm administratorForm = new AdministratorSignInForm();
            administratorForm.Show();
        }

        private void managerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerSignInForm managerSignInForm = new ManagerSignInForm();
            managerSignInForm.Show();
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
