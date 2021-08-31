using ParkingApp.Classes.BaseParkingClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ParkingApp
{
    public static class Globals
    {
        //Роли пользователей в системе
        public static String ADMINISTRATOR = "Administrator";
        public static String MANAGER = "Manager";

        //Плата взимается по часам или по сутка
        public static String DAILY_RATE = "Daily";
        public static String HOURLY_RATE = "Hourly";

        //Высота и ширина пространства парковки
        public static int WIDTH = 0;
        public static int HEIGHT = 0;

        public static int INTERVAL = 20;

        public static int z = 0;

        public static double delta;

        //Тариф
        public static Tariff tariff;

        public static ModelingParams modelingParams;

        public static List<TabloItem> tabloItems = new List<TabloItem>();

        public static bool isNewParking = true;

        //Названия шаблонов, которые сохраняются в patters
        //и представляют собой матрицу пространства парковки
        public const String TREE = "Tree";
        public const String CASH_BOX = "Cash box";
        public const String PARKING_PLACE = "Auto";
        public const String GRASS = "Grass";
        public const String ENTRANCE = "Entrance";
        public const String EXIT = "Exit";
        public const String ROAD = "Road";
        public const String HIGHWAY = "Highway";

        //Название файла парковки
        public static String parkingFileName = "";
        //Путь к файлу парковки
        public static String parkingFilePath = "";
        //Путь к одностаничному сайту
        public static string pathToHtmlFile = "";

        //Директория пользователя, которая вычисляется исходя из положения папки с проектом
        public static String directory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();

        //Матрица шаблонов, которые представляют собой пространство парковки
        public static String[,] patterns = new String[WIDTH, HEIGHT];
        //Пикчербоксы для отрисовки пространства парковки
        public static List<PictureBox> pictureBoxes = new List<PictureBox>();

        //Матрица шаблонов, которые представляют собой шоссе
        public static String[,] highwayPatterns = new String[WIDTH + 1, HEIGHT + 1];

        //размер поля парковки в пикселях
        public static int SCREEN_SIZE = 500;

        public static int PICTURE_BOX_SIZE = 50;

        public static int leftAdjacentRoadLength = 0;
        public static int rightAdjacentRoadLength = 0;
        public static int downAdjacentRoadLength = 0;
        public static int upAdjacentRoadLength = 0;

        public static bool IS_CORRECT_PARKING;

        public static void calculateDelta()
        {
            //секунда х1
            if(INTERVAL == 20)
            {
                delta = 1.65;
            } 
            //полсекунды х2
            else if(INTERVAL == 10)
            {
                delta = 3.2;
            }
            //четверть секунды х4
            else if (INTERVAL == 5)
            {
                delta = 3.7;
            }
            //две секунды х1/2
            else
            {
                delta = 1.05;
            }
        }

        public static void calculatePictureBoxSize()
        {
            if (HEIGHT >= WIDTH)
            {
                if ((SCREEN_SIZE / HEIGHT) % 5 != 0)
                {
                    PICTURE_BOX_SIZE = (SCREEN_SIZE / HEIGHT) - (SCREEN_SIZE / HEIGHT) % 5;
                }
                else
                {
                    PICTURE_BOX_SIZE = SCREEN_SIZE / HEIGHT;
                }
            }
            else
            {
                if ((SCREEN_SIZE / WIDTH) % 5 != 0)
                {
                    PICTURE_BOX_SIZE = (SCREEN_SIZE / WIDTH) - (SCREEN_SIZE / WIDTH) % 5;
                }
                else
                {
                    PICTURE_BOX_SIZE = SCREEN_SIZE / WIDTH;
                }
            }
        }
    }
}
