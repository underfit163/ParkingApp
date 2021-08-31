using ParkingApp.Classes;
using System;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class CreateParkingField : Form
    {

        private int MAX_SIZE = 10;
        private int MIN_SIZE = 5;
        public CreateParkingField()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (isCorrectValues())
            {
                this.Hide();
                ParkingSpaceForm parkingSpaceForm = new ParkingSpaceForm();
                parkingSpaceForm.Show();
            }
        }

        private void adjacentRoad()
        {
            if (rightRadioBtn.Checked && upRadioBtn.Checked)
            {
                Globals.rightAdjacentRoadLength = int.Parse(widthTextBox.Text)+1;
                Globals.upAdjacentRoadLength = int.Parse(heightTextBox.Text);

            }
            else if(leftRadioBtn.Checked && downRadioBtn.Checked)
            {
                Globals.leftAdjacentRoadLength = int.Parse(widthTextBox.Text);
                Globals.downAdjacentRoadLength = int.Parse(heightTextBox.Text)+1;
            }
            else if (leftRadioBtn.Checked && upRadioBtn.Checked)
            {
                Globals.leftAdjacentRoadLength = int.Parse(widthTextBox.Text);
                Globals.upAdjacentRoadLength = int.Parse(heightTextBox.Text)+1;
            }
            else if (rightRadioBtn.Checked && downRadioBtn.Checked)
            {
                Globals.rightAdjacentRoadLength = int.Parse(widthTextBox.Text)+1;
                Globals.downAdjacentRoadLength = int.Parse(heightTextBox.Text);
            }
            else
            {
                Globals.downAdjacentRoadLength = 0;
            }
        }

        private bool isCorrectValues()
        {
            int width = int.Parse(widthTextBox.Text);
            int height = int.Parse(heightTextBox.Text);
            if (width >= MIN_SIZE && width <= MAX_SIZE && height >= MIN_SIZE && height <= MAX_SIZE)
            {
                Globals.HEIGHT = height;
                Globals.WIDTH = width;
                adjacentRoad();
                return true;
            }
            else
            {
                MessageBox.Show("Минимальное значение 5, максимальное 10", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void backToMainAdminScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorMainScreen administratorMainScreen = new AdministratorMainScreen();
            administratorMainScreen.Show();
        }

        private void validation(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.WIDTH = 5;
            Globals.HEIGHT = 5;
            Globals.patterns = new DefaultParkings().getDefault_5_5();
            Globals.isNewParking = false;
            Globals.leftAdjacentRoadLength = Globals.WIDTH + 1;
            Globals.downAdjacentRoadLength = Globals.HEIGHT + 1;
            Globals.upAdjacentRoadLength = 0;
            Globals.rightAdjacentRoadLength = 0;
            Globals.highwayPatterns = new String[Globals.WIDTH + 1, Globals.HEIGHT + 1];

            this.Hide();
            ParkingSpaceForm parkingSpaceForm = new ParkingSpaceForm();
            parkingSpaceForm.Show();
        }

        private void CreateParkingField_Load(object sender, EventArgs e)
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
