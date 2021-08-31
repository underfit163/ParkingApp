using ParkingApp.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingApp.Classes
{
    class AdjacentRoadClass
    {
        //Создать дорогу слева от паркинга
        public void createLeftAdjacentRoad(Panel panel1, int length)
        {
            // <= когда вторая дорога снизу
            // < когда вторая дорога сверху            
            if (Globals.downAdjacentRoadLength != 0)
            {       
                for (int j = 0; j < length; j++)
                {
                    PictureBox pictureBox = createRoadPictureBox(j + 1, 0);
                    panel1.Controls.Add(pictureBox);
                    pictureBox.BringToFront();
                    Globals.highwayPatterns[j, 0] = Globals.HIGHWAY;
                }
            }
            else
            {
                for (int j = 0; j < length; j++)
                {
                    PictureBox pictureBox = createRoadPictureBox(j + 1, 0);
                    panel1.Controls.Add(pictureBox);
                    pictureBox.BringToFront();
                    Globals.highwayPatterns[j + 1, 0] = Globals.HIGHWAY;
                }
            }
        }

        
        //Создать дорогу справа от паркинга
        public void createRightAdjacentRoad(Panel panel1, int length)
        {
            //если сверху то length-1
            //если снизу то length
            if (Globals.upAdjacentRoadLength != 0)
            {
                for (int j = 0; j < length; j++)
                {
                    PictureBox pictureBox = createRoadPictureBox(j, Globals.HEIGHT + 1);
                    panel1.Controls.Add(pictureBox);
                    pictureBox.BringToFront();
                    Globals.highwayPatterns[j, Globals.HEIGHT] = Globals.HIGHWAY;
                }
            }
            else
            {
                for (int j = 0; j < length; j++)
                {
                    PictureBox pictureBox = createRoadPictureBox(j + 1, Globals.HEIGHT + 1);
                    panel1.Controls.Add(pictureBox);
                    pictureBox.BringToFront();
                    Globals.highwayPatterns[j, Globals.HEIGHT] = Globals.HIGHWAY;
                }
            }
        }

        //Создать дорогу сверху от паркинга
        public void createUpAdjacentRoad(Panel panel1, int length)
        {
            //когда вторая дорога слева --
            //когда вторая дорога справа то все как есть
            if (Globals.leftAdjacentRoadLength != 0)
            {
                for (int j = 0; j < length; j++)
                {
                    PictureBox pictureBox = createRoadPictureBox(0, j);
                    panel1.Controls.Add(pictureBox);
                    pictureBox.BringToFront();
                    Globals.highwayPatterns[0, j] = Globals.HIGHWAY;
                }
            }
            else
            {
                for (int j = 0; j < length; j++)
                {
                    PictureBox pictureBox = createRoadPictureBox(0, j + 1);
                    panel1.Controls.Add(pictureBox);
                    pictureBox.BringToFront();
                    Globals.highwayPatterns[0, j] = Globals.HIGHWAY;
                }
            }
        }

        //Создать дорогу снизу от паркинга
        public void createDownAdjacentRoad(Panel panel1, int length)
        {
            //length - 1 только когда вторая дорога слева
            //legth когда вторая дорога справа
            if (Globals.leftAdjacentRoadLength != 0)
            {
                for (int j = 0; j < length; j++)
                {
                    PictureBox pictureBox = createRoadPictureBox(Globals.WIDTH + 1, j);
                    panel1.Controls.Add(pictureBox);
                    pictureBox.BringToFront();
                    Globals.highwayPatterns[Globals.WIDTH, j] = Globals.HIGHWAY;
                }
            }
            else
            {
                for (int j = 0; j < length; j++)
                {
                    PictureBox pictureBox = createRoadPictureBox(Globals.WIDTH + 1, j + 1);
                    panel1.Controls.Add(pictureBox);
                    pictureBox.BringToFront();
                    Globals.highwayPatterns[Globals.WIDTH, j] = Globals.HIGHWAY;
                }
            }
        }

        private PictureBox createRoadPictureBox(int i, int j)
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(0 + j * Globals.PICTURE_BOX_SIZE, 0 + i * Globals.PICTURE_BOX_SIZE);
            pictureBox1.Name = i + "_" + j;
            pictureBox1.Size = new Size(Globals.PICTURE_BOX_SIZE, Globals.PICTURE_BOX_SIZE);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Resources.highwayPic1;
            return pictureBox1;
        }
    }
}
