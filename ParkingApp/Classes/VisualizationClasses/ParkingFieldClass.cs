using ParkingApp.Classes.VisualizationClasses;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ParkingApp.Classes
{
    class ParkingFieldClass
    {
        ProcessImagesClass processImages;

        public ParkingFieldClass()
        {
            processImages = new ProcessImagesClass();
        }

        public void loadField(Panel panel1)
        {
            for (int i = 0; i < Globals.pictureBoxes.Count; i++)
            {
                panel1.Controls.Add(Globals.pictureBoxes.ElementAt(i));
            }
        }

        public void fillPatternsArray()
        {
            int z = 0;
            int k = Globals.pictureBoxes.Count;
            for (int i = 0; i < Globals.WIDTH; i++)
            {
                for (int j = 0; j < Globals.HEIGHT; j++)
                {
                    if (z < k)
                    {
                        Globals.patterns[i, j] = processImages.getNameOfImage(Globals.pictureBoxes.ElementAt(z).Image);
                        z++;
                    }
                }
            }
        }

        public void fillPictureBoxesList()
        {
            if (Globals.pictureBoxes != null)
            {
                Globals.pictureBoxes.Clear();
            }
            else
            {
                Globals.pictureBoxes = new List<PictureBox>();
            }
            for (int i = 0; i < Globals.WIDTH; i++)
            {
                for (int j = 0; j < Globals.HEIGHT; j++)
                {
                    Globals.pictureBoxes.Add(createPictureBox(processImages.getImageByName(Globals.patterns[i, j]), i, j));
                }
            }
        }        

        public void createField(Panel panel1, int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    PictureBox pictureBox1 = createPictureBox(processImages.getImageByName(Globals.ROAD), i, j);
                    Globals.pictureBoxes.Add(pictureBox1);
                    panel1.Controls.Add(pictureBox1);
                }
            }
        }

        public PictureBox createPictureBox(Image image, int i, int j)
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(Globals.PICTURE_BOX_SIZE + j * Globals.PICTURE_BOX_SIZE, Globals.PICTURE_BOX_SIZE + i * Globals.PICTURE_BOX_SIZE);
            pictureBox1.Name = i + "_" + j;
            pictureBox1.Size = new Size(Globals.PICTURE_BOX_SIZE, Globals.PICTURE_BOX_SIZE);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.AllowDrop = true;
            pictureBox1.DragEnter += pictureBox_DragEnter;
            pictureBox1.DragDrop += PictureBox1_DragDrop;
            pictureBox1.Image = image;
            return pictureBox1;
        }

        void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
    }
}
