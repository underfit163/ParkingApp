using ParkingApp.Classes;
using ParkingApp.Classes.AlgPathFind;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ParkingApp.Classes.BaseParkingClasses;

namespace ParkingApp.Screens.Manager
{
    public partial class ModelingSpaceForm : Form
    {
        private static System.Timers.Timer VisualizationTimer;
        public ModelingSpaceForm()
        {
            InitializeComponent();

            clearValues();

            Globals.calculatePictureBoxSize();

            Globals.highwayPatterns = new String[Globals.WIDTH + 1, Globals.HEIGHT + 1];

            panel1.Location = new Point(0, 0);

            ParkingFieldClass parkingField = new ParkingFieldClass();

            parkingField.fillPictureBoxesList();
            parkingField.loadField(panel1);

            FindPaths.fillParkMatr();

            panel1.Invalidate();

            new RoadsClass().createRoads(panel1);
            FindPaths.fillRoadMatr();

            configureTimer();

            dataGridView1.Location = new Point(Globals.HEIGHT * Globals.PICTURE_BOX_SIZE + Globals.PICTURE_BOX_SIZE , Globals.PICTURE_BOX_SIZE);
            dataGridView1.Size = new Size(300, Globals.WIDTH * Globals.PICTURE_BOX_SIZE + Globals.PICTURE_BOX_SIZE);

            SystemTime.Start();
            SystemTime.Interval = 50 * Globals.INTERVAL;
            SystemTime.Tick += SystemTime_Tick1;
        }

        private void clearValues()
        {
            FindPaths.startPark = null;
            FindPaths.endPark = null;
            FindPaths.startRoad = null;
            FindPaths.endRoad = null;
            FindPaths.preStartPark = null;
            FindPaths.preEndPark = null;
            FindPaths.parkPoints = new List<PathPoint>();
            FindPaths.carPoints = new List<PathPoint>();
            Globals.tabloItems = new List<TabloItem>();
            FindPaths.parkMatr = null;
            FindPaths.roadMatr = null;
        }

        double systemTimer = 0;
        private void SystemTime_Tick1(object sender, EventArgs e)
        {
            systemTimer+=0.5;
            SystemTimeLabel.Text = "Системное время: " + systemTimer;
        }

        int intervalNumber = 0;
        private void configureTimer()
        {
            VisualizationTimer = new System.Timers.Timer();
            if (Globals.modelingParams.appearanceInterval != 0)
            {
                VisualizationTimer.Interval = Globals.modelingParams.appearanceInterval * 50 * Globals.INTERVAL;
            }
            else
            {
                VisualizationTimer.Interval = Globals.modelingParams.appearanceIntervals[intervalNumber] * 50 * Globals.INTERVAL;
                intervalNumber++;
            }  
            VisualizationTimer.Elapsed += VisualizationTimer_Tick;
            VisualizationTimer.Start();
        }

        private void ModelingSpaceForm_Load(object sender, EventArgs e)
        {

        }

        private Car startRoad(Car car)
        {
            car.currPos = FindPaths.startRoad;
            car.onParking.AddRange(car.getBetweenTwoPointRoad(FindPaths.startRoad, FindPaths.preStartPark));
            Action action = () =>
            {
                panel1.Controls.Add(car.carPicBox);
                car.timer1.Start();
                car.currPos = FindPaths.preStartPark;
            };
            if (InvokeRequired)
                Invoke(action);
            else
                action();
            return car;
        }
        private void outRoadToPark(Car car)
        {
            car.currPos = FindPaths.preStartPark;
            car.onParking.AddRange(car.getBetweenTwoPointRoadPark(FindPaths.preStartPark, FindPaths.startPark));
            car.currPos = FindPaths.startPark;
        }
        private void preStartParkToEndRoad(Car car)
        {
            car.currPos = FindPaths.preStartPark;
            car.onParking.AddRange(car.getBetweenTwoPointRoad(FindPaths.preStartPark, FindPaths.endRoad));
            car.currPos = FindPaths.endRoad;
        }

        private void preStartParkToParkPoint(Car car)
        {
            PathPoint parkPoint = FindPaths.getParkPoint(car);
            car.onParking.AddRange(car.getBetweenTwoPointPark(FindPaths.startPark, parkPoint));
            car.currPos = FindPaths.startPark;
            car.currPos = parkPoint;
        }

        private void addToTablo(Car car)
        {
            if (intervalNumber == 100)
            {
                intervalNumber = 0;
            }
            if (Globals.modelingParams.onParkingInterval != 0)
            {
                car.tabloItem = new TabloItem(Globals.modelingParams.onParkingInterval, car.parkingPlaceNumber, Globals.tariff.carPrice * Globals.modelingParams.onParkingInterval);
                Globals.tabloItems.Add(car.tabloItem);
            }
            else
            {
                car.tabloItem = new TabloItem(Globals.modelingParams.onParkingIntervals[intervalNumber], car.parkingPlaceNumber, Convert.ToInt32(Globals.tariff.carPrice * Globals.modelingParams.onParkingIntervals[intervalNumber]));
                Globals.tabloItems.Add(car.tabloItem);
            }
        }

        private Car stayOnParking(Car car)
        {
            //количество точек: время стоянки = k*INTERVAL*Globals.delta
            double z;
            if (Globals.modelingParams.onParkingInterval != 0)
            {
              //  z = Globals.INTERVAL * Globals.modelingParams.onParkingInterval * Globals.delta;
                Console.WriteLine("Время стоянки");
                car.timeStay = /*Globals.INTERVAL **/ Globals.modelingParams.onParkingInterval;
            }
            else
            {
              //  z = /*Globals.INTERVAL * */Globals.modelingParams.onParkingIntervals[intervalNumber] * Globals.delta;
                car.timeStay = /*Globals.INTERVAL **/ Globals.modelingParams.onParkingIntervals[intervalNumber];
            }
          //  int k = Convert.ToInt32(z);       
          //  car.onParking.AddRange(car.);
            return car;
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

        private void VisualizationTimer_Tick(object sender, EventArgs e)
        {
            timerIntervalStep();
            Car car = new Car();
            car.rotateCarBeforeStart();
            startRoad(car);
            if (car.probability <= Globals.modelingParams.probability && FindPaths.parkPoints.Count != 0)
            {
              
                outRoadToPark(car);
                preStartParkToParkPoint(car);
                stayOnParking(car);

                addToTablo(car);
            }
            else
            {
                preStartParkToEndRoad(car);
            }
            refreshTablo();
        }

        private void refreshTablo()
        {
            Action action = () =>
            {
                freePlacesCounter.Text = "Свободных парковочных мест: " + FindPaths.parkPoints.Count;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Globals.tabloItems;
            };
            if (InvokeRequired)
                Invoke(action);
            else
            {
                action();
            }
        }

        private void timerIntervalStep()
        {
            if (intervalNumber == 100)
            {
                intervalNumber = 0;
            }
            if (Globals.modelingParams.appearanceInterval != 0)
            {
                VisualizationTimer.Interval = Globals.modelingParams.appearanceInterval * 50 * Globals.INTERVAL;
            }
            else
            {
                VisualizationTimer.Interval = Globals.modelingParams.appearanceIntervals[intervalNumber] * 50 * Globals.INTERVAL;
            }
            
            intervalNumber++;
        }

        private void exit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                this.Hide();
                VisualizationTimer.Stop();
                SystemTime.Stop();              
                ConfigureModelingParamsForm configureModelingParams = new ConfigureModelingParamsForm();
                configureModelingParams.Show();
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
                e.Row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}