using ParkingApp.Classes;
using System;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class AdministratorMainScreen : Form
    {
        public AdministratorMainScreen()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            createParking();
        }

        private void createParking()
        {
            if (Globals.isNewParking)
            {
                if (Globals.tariff == null)
                {
                    this.Hide();
                    ConfigureTarifForm configureTarifForm = new ConfigureTarifForm();
                    configureTarifForm.Show();
                }
                else
                {
                    this.Hide();
                    CreateParkingField createParkingField = new CreateParkingField();
                    createParkingField.Show();
                }
            }
            else
            {
                this.Hide();
                ParkingSpaceForm parkingSpaceForm = new ParkingSpaceForm();
                parkingSpaceForm.Show();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            loadParking();            
        }

        private void loadParking()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Parking files(*.parking) | *.parking";
            openFileDialog1.InitialDirectory = Globals.directory;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Globals.parkingFilePath = openFileDialog1.FileName;
                ParkingField parkingField = loadParkingFromFile();
                if (parkingField != null)
                {
                    Globals.patterns = parkingField.getPatterns();
                    Globals.tariff = parkingField.getTariff();
                    Globals.WIDTH = parkingField.getWidth();
                    Globals.HEIGHT = parkingField.getHeight();
                    Globals.isNewParking = false;
                    Globals.leftAdjacentRoadLength = parkingField.getLeftRoadLength();
                    Globals.rightAdjacentRoadLength = parkingField.getRigthRoadLength();
                    Globals.upAdjacentRoadLength = parkingField.getUpRoadLength();
                    Globals.downAdjacentRoadLength = parkingField.getDownRoadLength();

                    MessageBox.Show("Парковка успешно загружена!", "Статус загрузки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    createParking();
                }
                else
                {
                    MessageBox.Show("Упс...Что-то пошло не так. Воможно, файл был поврежден :(", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Загрузка парковки из файла парковки
        private ParkingField loadParkingFromFile()
        {
            FileWorkerWithParkingField fileWorker = new FileWorkerWithParkingField();
            if (fileWorker.readParkingField() != null)
            {
                return fileWorker.readParkingField();
            }
            else return null;
        }

        private void configureTariff_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfigureTarifForm configureTarifForm = new ConfigureTarifForm();
            configureTarifForm.Show();
        }

        private void backToMainScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
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
