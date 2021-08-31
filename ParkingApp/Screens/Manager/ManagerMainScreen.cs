using ParkingApp.Classes;
using ParkingApp.Screens.Manager;
using System;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class ManagerMainScreen : Form
    {
        public ManagerMainScreen()
        {
            InitializeComponent();            
        }

        private void loadParking()
        {            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Parking files(*.parking) | *.parking";
            openFileDialog1.InitialDirectory = Globals.directory;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Globals.IS_CORRECT_PARKING = false;
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
                    Globals.IS_CORRECT_PARKING = true;

                    MessageBox.Show("Парковка успешно загружена!", "Статус загрузки", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    MessageBox.Show("Упс...Что-то пошло не так. Воможно, файл был поврежден :(", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
            this.Show();
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

        private void backToMainScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreenForm mainScreenForm = new MainScreenForm();
            mainScreenForm.Show();
        }

        //Запустить моделирование
        private void button1_Click(object sender, EventArgs e)
        {            
            if (Globals.IS_CORRECT_PARKING)
            {
                if (Globals.modelingParams != null)
                {
                    this.Hide();
                    ModelingSpaceForm modelingSpaceForm = new ModelingSpaceForm();
                    modelingSpaceForm.Show();
                }
                else
                {
                    this.Hide();
                    ConfigureModelingParamsForm configureModeling = new ConfigureModelingParamsForm();
                    configureModeling.Show();
                }                
            }
            else
            {
                loadParking();
            }                  
        }

       
        private void loadparkingBtn_Click(object sender, EventArgs e)
        {
            loadParking();
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

        private void configureModellingParamsBtn_Click(object sender, EventArgs e)
        {
            ConfigureModelingParamsForm paramsForm = new ConfigureModelingParamsForm();
            paramsForm.Show();
            this.Hide();
        }
    }
}
