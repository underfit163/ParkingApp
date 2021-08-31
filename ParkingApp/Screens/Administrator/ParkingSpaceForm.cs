using ParkingApp.Classes;
using ParkingApp.Screens.Administrator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class ParkingSpaceForm : Form
    {
        ParkingFieldClass parkingFieldClass;
        public ParkingSpaceForm()
        {
            InitializeComponent();

            Globals.calculatePictureBoxSize();

            parkingFieldClass = new ParkingFieldClass();

            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(Globals.PICTURE_BOX_SIZE * Globals.HEIGHT + Globals.PICTURE_BOX_SIZE * 4 + 12, Globals.PICTURE_BOX_SIZE * 2);           
            buttonsBox.Location = new Point(Globals.PICTURE_BOX_SIZE * Globals.HEIGHT + Globals.PICTURE_BOX_SIZE * 4, panel2.Height + Globals.PICTURE_BOX_SIZE * 2);            

            if (Globals.isNewParking)
            {
                Globals.pictureBoxes = new List<PictureBox>();
                Globals.patterns = new String[Globals.WIDTH, Globals.HEIGHT];
                Globals.highwayPatterns = new String[Globals.WIDTH + 1, Globals.HEIGHT + 1];
                parkingFieldClass.createField(panel1, Globals.WIDTH, Globals.HEIGHT);                
            }
            else
            {
                parkingFieldClass.fillPictureBoxesList();
                parkingFieldClass.loadField(panel1);
            }            
            new RoadsClass().createRoads(panel1);            
        }             

        private bool isCorrectField()
        {
            VerifyParkingClass verifyParking = new VerifyParkingClass();
            if (verifyParking.isCorrectNumberOfTerminals())
            {
                if (verifyParking.isTerminalsAtTheBorder())
                {
                    System.Windows.Forms.MessageBox.Show("Парковка заполнена корректно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Убедитесь в правильности заполнения пространства парковки", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Убедитесь в правильности заполнения пространства парковки", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }                             

        private void saveBtn_Click(object sender, EventArgs e)
        {
            parkingFieldClass.fillPatternsArray();

            if (isCorrectField())
            {
                Globals.isNewParking = false;

            }
        }

        private void saveToFile_Click(object sender, EventArgs e)
        {
            parkingFieldClass.fillPatternsArray();
            if (isCorrectField())
            {
                SaveForm saveForm = new SaveForm();
                saveForm.Show();
            }
        }

        private void createNewParkingBtn_Click(object sender, EventArgs e)
        {
            Globals.isNewParking = true;
            Globals.tariff = null;
            Globals.pictureBoxes = null;
            Globals.patterns = null;
            Globals.rightAdjacentRoadLength = 0;
            Globals.leftAdjacentRoadLength = 0;
            Globals.upAdjacentRoadLength = 0;
            Globals.downAdjacentRoadLength = 0;
            this.Hide();
            ConfigureTarifForm configureTarifForm = new ConfigureTarifForm();
            configureTarifForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Вы уверены? Несохраненные изменения будут потеряны!", "Подтвердить действие", System.Windows.MessageBoxButton.YesNo);

            if (confirmResult == System.Windows.MessageBoxResult.Yes)
            {
                this.Hide();
                AdministratorMainScreen administratorMainScreen = new AdministratorMainScreen();
                administratorMainScreen.Show();
            }
        }

        private void mouseDownEntrancePic(object sender, MouseEventArgs e)
        {
            entrancePic.DoDragDrop(entrancePic.Image, DragDropEffects.Copy);
        }

        private void mouseDownExitPic(object sender, MouseEventArgs e)
        {
            exitPic.DoDragDrop(exitPic.Image, DragDropEffects.Copy);
        }

        private void dollarDown(object sender, MouseEventArgs e)
        {
            dollarPic.DoDragDrop(dollarPic.Image, DragDropEffects.Copy);
        }

        private void mouseDownCar(object sender, MouseEventArgs e)
        {
            autoPic.DoDragDrop(autoPic.Image, DragDropEffects.Copy);
        }

        private void mouseDownRoad(object sender, MouseEventArgs e)
        {
            roadPic.DoDragDrop(roadPic.Image, DragDropEffects.Copy);
        }

        private void mouseDownTree(object sender, MouseEventArgs e)
        {
            treePic.DoDragDrop(treePic.Image, DragDropEffects.Copy);
        }

        private void mouseDownGrass(object sender, MouseEventArgs e)
        {
            grassPic.DoDragDrop(grassPic.Image, DragDropEffects.Copy);
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


