using ParkingApp.Classes.AlgPathFind;
using ParkingApp.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ParkingApp.Classes.BaseParkingClasses;
using System.Threading.Tasks;

namespace ParkingApp.Classes
{
    class Car
    {
        private static int OFFSET = 5;

        public int rotate { get; set; }
        public PathPoint currPos { get; set; }
        public PictureBox carPicBox { get; set; }
        public List<Point> outParking { get; set; }
        public List<Point> onParking { get; set; }
        public TabloItem tabloItem { get; set; }

        private Random random;
        public double probability { get; set; }
        public int parkingPlaceNumber { get; set; }
        public double timeStay { get; set; }

        public System.Windows.Forms.Timer timer1;
        public Car()
        {
            random = new Random();

            this.probability = random.NextDouble();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = Globals.INTERVAL;
            timer1.Tick += new System.EventHandler(timer1_Tick_1);

            onParking = new List<Point>();
            outParking = new List<Point>();

            carPicBox = new PictureBox();
            carPicBox.Location = Modeling.getLocPointRoad(FindPaths.startRoad);
            carPicBox.Image = getRandomCarImage();
            carPicBox.Name = "car";
            carPicBox.Size = new Size(Globals.PICTURE_BOX_SIZE, Globals.PICTURE_BOX_SIZE);
            carPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            carPicBox.MouseEnter += CarPicBox_MouseEnter;
        }

        private void CarPicBox_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip((PictureBox)sender, "Вероятность заезда: " + Math.Round((1 - this.probability), 2));
        }

        public Image getRandomCarImage()
        {
            random = new Random();
            int k = random.Next(0, 8);
            if (k == 0)
            {
                return Resources.parkingCar1Pic;
            }
            else if (k == 1)
            {
                return Resources.parkingCar2Pic;
            }
            else if (k == 2)
            {
                return Resources.parkingCar3Pic;
            }
            else if (k == 3)
            {
                return Resources.parkingCar4Pic;
            }
            else if (k == 4)
            {
                return Resources.parkingCar5Pic;
            }
            else if (k == 5)
            {
                return Resources.parkingCar6Pic;
            }
            else
            {
                return Resources.parkingCar7Pic;
            }
        }

        public void rotateCarBeforeStart()
        {
            if (Globals.downAdjacentRoadLength != 0 && Globals.leftAdjacentRoadLength != 0)
            {
                rotate = 3;
                carPicBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                carPicBox.Refresh();
            }
            if (Globals.upAdjacentRoadLength != 0 && Globals.leftAdjacentRoadLength != 0)
            {
                rotate = 0;
                carPicBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                carPicBox.Refresh();
            }
            if (Globals.upAdjacentRoadLength != 0 && Globals.rightAdjacentRoadLength != 0)
            {
                rotate = 1;
                carPicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                carPicBox.Refresh();
            }
            if (Globals.rightAdjacentRoadLength != 0 && Globals.downAdjacentRoadLength != 0)
            {
                rotate = 2;
                carPicBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                carPicBox.Refresh();
            }
        }

        public List<Point> getStayPoint(int k)
        {
            List<Point> points = new List<Point>();
            while (k >= 0)
            {
                points.Add(new Point(0, 0));
                k--;
            }
            return points;
        }

        public List<Point> getBetweenTwoPointRoadPark(PathPoint start, PathPoint end)
        {
            List<Point> points = new List<Point>();
            var firstPoint = Modeling.getLocPointRoad(start);
            var secondPoint = Modeling.getLocPointPark(end);
            secondPoint.Offset(-firstPoint.X, -firstPoint.Y);
            addPoints(points, secondPoint);
            return points;
        }
        public List<Point> getBetweenTwoPointParkRoad(PathPoint start, PathPoint end)
        {
            List<Point> points = new List<Point>();
            var firstPoint = Modeling.getLocPointPark(start);
            var secondPoint = Modeling.getLocPointRoad(end);
            secondPoint.Offset(-firstPoint.X, -firstPoint.Y);
            addPoints(points,secondPoint);
            return points;
        }

        private void addPoints(List<Point> points, Point secondPoint)
        {
            if (secondPoint.X != 0)
            {
                if (secondPoint.X > 0)
                {
                    int t = 0;
                    int path = OFFSET;
                    while (t < secondPoint.X)
                    {
                        points.Add(new Point(path, 0));
                        t += OFFSET;
                    }
                }
                else if (secondPoint.X < 0)
                {
                    int t = 0;
                    int path = -OFFSET;
                    while (t > secondPoint.X)
                    {
                        points.Add(new Point(path, 0));
                        t -= OFFSET;
                    }
                }
            }
            if (secondPoint.Y != 0)
            {
                if (secondPoint.Y > 0)
                {
                    int t = 0;
                    int path = OFFSET;
                    while (t < secondPoint.Y)
                    {
                        points.Add(new Point(0, path));
                        t += OFFSET;
                    }
                }
                else if (secondPoint.Y < 0)
                {
                    int t = 0;
                    int path = -OFFSET;
                    while (t > secondPoint.Y)
                    {
                        points.Add(new Point(0, path));
                        t -= OFFSET;
                    }
                }

            }
        }

        public List<Point> getBetweenTwoPointRoad(PathPoint start, PathPoint end)
        {
            List<Point> points = new List<Point>();
            var pathPoints = FindPaths.FindPath(FindPaths.roadMatr, start, end);
            for (int i = 0; i < pathPoints.Count - 1; i++)
            {
                var firstPoint = Modeling.getLocPointRoad(pathPoints.ElementAt(i));
                var secondPoint = Modeling.getLocPointRoad(pathPoints.ElementAt(i + 1));
                secondPoint.Offset(-firstPoint.X, -firstPoint.Y);
                addPoints(points, secondPoint);
            }
            return points;
        }

        public List<Point> getBetweenTwoPointPark(PathPoint start, PathPoint end)
        {
            List<Point> points = new List<Point>();
            var pathPoints = FindPaths.FindPath(FindPaths.parkMatr, start, end);
            for (int i = 0; i < pathPoints.Count - 1; i++)
            {
                var firstPoint = Globals.pictureBoxes.ElementAt(pathPoints.ElementAt(i).X * Globals.HEIGHT + pathPoints.ElementAt(i).Y).Location;
                var secondPoint = Globals.pictureBoxes.ElementAt(pathPoints.ElementAt(i + 1).X * Globals.HEIGHT + pathPoints.ElementAt(i + 1).Y).Location;
                secondPoint.Offset(-firstPoint.X, -firstPoint.Y);
                addPoints(points, secondPoint);
            }
            return points;
        }
        public async void timer1_Tick_1(object sender, EventArgs e)
        {

            carPicBox.BringToFront();
            carPicBox.Location = new Point(carPicBox.Location.X + onParking.ElementAt(0).X, carPicBox.Location.Y + onParking.ElementAt(0).Y);
            if (0 < onParking.Count - 1)
            {
                rotateCar();
            }

            onParking.RemoveAt(0);

            if (0 == onParking.Count)
            {
                timer1.Stop();
                if (currPos == FindPaths.endRoad)
                {
                    carPicBox.Dispose();
                }
                if (currPos != FindPaths.endRoad)
                {
                    Console.WriteLine((int)timeStay * 100);
                    await Task.Delay((int)timeStay*100);
                    await Task.Run(() => outParkToEndPark(this));
                    await Task.Run(() => outParkToRoad(this));
                    await Task.Run(() => outRoad(this));
                    this.carPicBox.Refresh();
                    timer1.Start();
                }
            }
        }

        private void rotateCar()
        {
            //ехали вверх
            if ((onParking.ElementAt(0 + 1).Y == 0) && (onParking.ElementAt(0).Y < 0))
            {
                if (onParking.ElementAt(0 + 1).X > 0)
                {//поворот вправо
                 // машина смотрит вправо относительно начального положения въезда
                    rotate = 1;
                    carPicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    carPicBox.Refresh();
                }
                else if (onParking.ElementAt(0 + 1).X < 0)
                {//поворот влево
                 //машина смотрит влево относительно начального положения въезда
                    rotate = 3;
                    carPicBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    carPicBox.Refresh();
                }
            }
            //ехали вниз
            if ((onParking.ElementAt(0 + 1).Y == 0) && (onParking.ElementAt(0).Y > 0))
            {
                if (onParking.ElementAt(0 + 1).X > 0)
                {//поворот вправо
                 //машина смотрит вправо относительно начального положения въезда
                    rotate = 1;
                    carPicBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    carPicBox.Refresh();
                }
                else if (onParking.ElementAt(0 + 1).X < 0)
                {//поворот влево
                 //машина смотрит влево относительно начального положения въезда
                    rotate = 3;
                    carPicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    carPicBox.Refresh();
                }
            }
            //ехали вправо
            if ((onParking.ElementAt(0 + 1).X == 0) && (onParking.ElementAt(0).X > 0))
            {
                if (onParking.ElementAt(0 + 1).Y > 0)
                {//поворот вниз
                 //машина смотрит вниз относительно начального положения въезда
                    rotate = 2;
                    carPicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    carPicBox.Refresh();
                }
                else if (onParking.ElementAt(0 + 1).Y < 0)
                {//поворот вверх
                 //машина смотрит вверх относительно начального положения въезда
                    rotate = 0;
                    carPicBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    carPicBox.Refresh();
                }
            }
            //ехали влево
            if ((onParking.ElementAt(0 + 1).X == 0) && (onParking.ElementAt(0).X < 0))
            {
                if (onParking.ElementAt(0 + 1).Y > 0)
                {//поворот вниз
                 //машина смотрит вниз относительно начального положения въезда
                    rotate = 2;
                    carPicBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    carPicBox.Refresh();
                }
                else if (onParking.ElementAt(0 + 1).Y < 0)
                {//поворот вверх
                 //машина смотрит вверх относительно начального положения въезда
                    rotate = 0;
                    carPicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    carPicBox.Refresh();
                }
            }
        }

        private Car outParkToRoad(Car car)
        {
            car.currPos = FindPaths.endPark;
            car.onParking.AddRange(car.getBetweenTwoPointParkRoad(FindPaths.endPark, FindPaths.preEndPark));
            car.currPos = FindPaths.preEndPark;
            return car;
        }
        private Car outRoad(Car car)
        {
            car.currPos = FindPaths.preEndPark;
            car.onParking.AddRange(car.getBetweenTwoPointRoad(FindPaths.preEndPark, FindPaths.endRoad));
            car.currPos = FindPaths.endRoad;
            return car;
        }

        private void outParkToEndPark(Car car)
        {
            PathPoint carPoint = FindPaths.getCarPoint(car);
            if (carPoint != null)
            {
                car.currPos = carPoint;
                car.onParking.AddRange(car.getBetweenTwoPointPark(car.currPos, FindPaths.endPark));
                FindPaths.parkMatr[currPos.X, currPos.Y] = 5;

                rotateCarBeforeExit(car);

               // car.timer1.Start();
              //  car.carPicBox.Refresh();
                car.currPos = FindPaths.endPark;

                Globals.tabloItems.Remove(tabloItem);
            }
        }

        private void rotateCarBeforeExit(Car car)
        {
            //полицейский разворот
            if (car.rotate == 0 && (FindPaths.endPark.X >= car.currPos.X))
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if (car.rotate == 1 && (FindPaths.endPark.Y == car.currPos.Y) && (FindPaths.parkMatr[car.currPos.X + 1, car.currPos.Y] == 0))
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (car.rotate == 1 && (FindPaths.endPark.Y <= car.currPos.Y))
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if (car.rotate == 2 && (FindPaths.endPark.X >= car.currPos.X) && (FindPaths.parkMatr[car.currPos.X, car.currPos.Y - 1] == 0))
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (car.rotate == 2 && (FindPaths.endPark.X <= car.currPos.X))
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if (car.rotate == 2 && (FindPaths.endPark.X > car.currPos.X))
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            // если машина повернута влево и находится слева от выезда с праковки, то поворачиваем

            else if (car.rotate == 3 && (FindPaths.endPark.Y <= car.currPos.Y) && (FindPaths.parkMatr[car.currPos.X + 1, car.currPos.Y] == 0))
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else if (car.rotate == 3 && (FindPaths.endPark.Y <= car.currPos.Y) && (FindPaths.parkMatr[car.currPos.X, car.currPos.Y - 1] == 0))
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
            }
            else if (car.rotate == 3 && (FindPaths.endPark.Y <= car.currPos.Y) && (FindPaths.parkMatr[car.currPos.X - 1, car.currPos.Y] == 0))
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (car.rotate == 3 && (FindPaths.endPark.Y > car.currPos.Y) && (FindPaths.parkMatr[car.currPos.X + 1, car.currPos.Y] == 0))
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else
            {
                car.carPicBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
        }

    }
}
