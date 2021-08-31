using ParkingApp.Properties;
using System;
using System.Drawing;

namespace ParkingApp.Classes.VisualizationClasses
{
    class ProcessImagesClass
    {
        public Image getImageByName(String name)
        {
            if (name.Equals(Globals.ROAD))
            {
                return Resources.roadPic;
            }
            else if (name.Equals(Globals.ENTRANCE))
            {
                return Resources.entrancePic;
            }
            else if (name.Equals(Globals.EXIT))
            {
                return Resources.exitPic;
            }
            else if (name.Equals(Globals.CASH_BOX))
            {
                return Resources.cashBoxPic;
            }
            else if (name.Equals(Globals.PARKING_PLACE))
            {
                return Resources.parkingPlacePic;
            }
            else if (name.Equals(Globals.TREE))
            {
                return Resources.treePic;
            }
            else
            {
                return Resources.grassPic;
            }
        }

        public String getNameOfImage(Image image)
        {
            if (image != null)
            {
                Bitmap bitmap = new Bitmap(image);
                if (isImageSame(bitmap, new Bitmap(Resources.entrancePic)))
                {
                    return Globals.ENTRANCE;
                }
                else if (isImageSame(bitmap, new Bitmap(Resources.exitPic)))
                {
                    return Globals.EXIT;
                }
                else if (isImageSame(bitmap, new Bitmap(Resources.parkingPlacePic)))
                {
                    return Globals.PARKING_PLACE;
                }
                else if (isImageSame(bitmap, new Bitmap(Resources.treePic)))
                {
                    return Globals.TREE;
                }
                else if (isImageSame(bitmap, new Bitmap(Resources.cashBoxPic)))
                {
                    return Globals.CASH_BOX;
                }
                else if (isImageSame(bitmap, new Bitmap(Resources.roadPic)))
                {
                    return Globals.ROAD;
                }
                else if (isImageSame(bitmap, Resources.highwayPic1))
                {
                    return Globals.HIGHWAY;
                }
                else
                {
                    return Globals.GRASS;
                }
            }
            else
            {
                return Globals.ROAD;
            }
        }

        public bool isImageSame(Bitmap bmp1, Bitmap bmp2)
        {
            if (!bmp1.Size.Equals(bmp2.Size))
            {
                return false;
            }
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp2.Height; y++)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
