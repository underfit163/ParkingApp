using ParkingApp.Classes.AlgPathFind;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ParkingApp.Classes
{
    class Modeling
    {
        public List<Car> cars = new List<Car>();
        // функция перевода PathPoint в Point
        //Функция нахождения точки относительно Point(0,0)
        public static Point getLocPointRoad(PathPoint point)
        {
            Point point1 = new Point(0,0);
            if (Globals.leftAdjacentRoadLength != 0 && Globals.downAdjacentRoadLength != 0)
            {
               point1 = new Point((point.Y) * Globals.PICTURE_BOX_SIZE, (point.X) * Globals.PICTURE_BOX_SIZE + Globals.PICTURE_BOX_SIZE);
            }
            else if (Globals.leftAdjacentRoadLength != 0 && Globals.upAdjacentRoadLength != 0)
            {
                point1 = new Point((point.Y) * Globals.PICTURE_BOX_SIZE , (point.X) * Globals.PICTURE_BOX_SIZE);
            }
            else if (Globals.upAdjacentRoadLength != 0 && Globals.rightAdjacentRoadLength != 0)
            {
                point1 = new Point((point.Y) * Globals.PICTURE_BOX_SIZE+Globals.PICTURE_BOX_SIZE, (point.X) * Globals.PICTURE_BOX_SIZE);
            }
            else if (Globals.rightAdjacentRoadLength != 0 && Globals.downAdjacentRoadLength != 0)
            {
                point1 = new Point((point.Y) * Globals.PICTURE_BOX_SIZE+Globals.PICTURE_BOX_SIZE, (point.X) * Globals.PICTURE_BOX_SIZE + Globals.PICTURE_BOX_SIZE);
            }
            return point1;
        }

        public static Point getLocPointPark(PathPoint point)
        {
           return new Point((point.Y) * Globals.PICTURE_BOX_SIZE + Globals.PICTURE_BOX_SIZE, (point.X) * Globals.PICTURE_BOX_SIZE + Globals.PICTURE_BOX_SIZE); 
        }

        public PathPoint getLocPathPoint(Point point)
        {
            Console.WriteLine(point.Y / Globals.PICTURE_BOX_SIZE);
            Console.WriteLine(point.X / Globals.PICTURE_BOX_SIZE);
            return new PathPoint(point.Y / Globals.PICTURE_BOX_SIZE, point.X / Globals.PICTURE_BOX_SIZE);

        }
        

    }
}
