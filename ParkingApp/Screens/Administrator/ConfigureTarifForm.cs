using System;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class ConfigureTarifForm : Form
    {
        public ConfigureTarifForm()
        {
            InitializeComponent();
            if (Globals.tariff != null)
            {
                if (Globals.tariff.rateType.Equals(Globals.HOURLY_RATE))
                {
                    hourlyRateRadioBtn.Checked = true;
                    dayRateRadioBtn.Checked = false;
                }
                carPriceField.Text = Globals.tariff.carPrice.ToString();
            }
            hourlyRateRadioBtn.Checked = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Globals.tariff = createTariff();
            this.Hide();
            if (Globals.isNewParking)
            {
                this.Hide();
                CreateParkingField createParkingField = new CreateParkingField();
                createParkingField.Show();
            }
            else
            {
                this.Hide();
                ParkingSpaceForm parkingSpaceForm = new ParkingSpaceForm();
                parkingSpaceForm.Show();
            }           
        }

        private Tariff createTariff()
        {
            int carPrice = int.Parse(carPriceField.Text);
            Tariff tariff;
            if (hourlyRateRadioBtn.Checked)
            {
                tariff = new Tariff(Globals.HOURLY_RATE, carPrice);
            }
            else
            {
                tariff = new Tariff(Globals.DAILY_RATE, carPrice);
            }
            return tariff;
        }

        private void backToMainAdminScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorMainScreen administratorMainScreen = new AdministratorMainScreen();
            administratorMainScreen.Show();
        }

        private void clickRadioBtn(object sender, EventArgs e)
        {
            if (dayRateRadioBtn.Checked)
            {
                hourlyRateRadioBtn.Checked = false;
            }
            if (hourlyRateRadioBtn.Checked)
            {
                dayRateRadioBtn.Checked = false;
            }
        }

        private void validation(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))){
                e.Handled = true;
            }
        }

        private void saveAndBackBtn_Click(object sender, EventArgs e)
        {
            Globals.tariff = createTariff();
            this.Hide();
            AdministratorMainScreen administratorMainScreen = new AdministratorMainScreen();
            administratorMainScreen.Show();
        }

        private void carPriceField_TextChanged(object sender, EventArgs e)
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
