using System;
using System.Windows.Forms;

namespace ParkingApp.Screens
{
    public partial class AboutSystemForm : Form
    {
        public AboutSystemForm()
        {
            InitializeComponent();
        }

        private void preventResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void backToMainScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathToHtmlFile = Globals.directory + '\\' + "aboutParking" + '.' + "html";
            System.Diagnostics.Process.Start(pathToHtmlFile);
        }
    }
}
