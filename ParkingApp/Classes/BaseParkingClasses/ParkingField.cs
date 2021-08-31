using System;

namespace ParkingApp
{
    [Serializable]
    class ParkingField
    {
        private int width;
        private int height;
        private String[,] patterns;        
        private Tariff tariff;
        private int leftRoadLength;
        private int rightRoadLength;
        private int upRoadLength;
        private int downRoadLength;

        public ParkingField(int width, int height, String[,] patterns, Tariff tariff, int leftRoadLength, int rightRoadLength, int upRoadLength, int downRoadLength)
        {
            this.width = width;
            this.height = height;
            this.patterns = patterns;
            this.tariff = tariff;
            this.leftRoadLength = leftRoadLength;
            this.rightRoadLength = rightRoadLength;
            this.upRoadLength = upRoadLength;
            this.downRoadLength = downRoadLength;
        }

        public int getLeftRoadLength()
        {
            return this.leftRoadLength;
        }

        public int getRigthRoadLength()
        {
            return this.rightRoadLength;
        }
        public int getUpRoadLength()
        {
            return this.upRoadLength;
        }
        public int getDownRoadLength()
        {
            return this.downRoadLength;
        }

        public String[,] getPatterns()
        {
            return this.patterns;
        }

        public int getWidth()
        {
            return this.width;
        }

        public int getHeight()
        {
            return this.height;
        }

        public Tariff getTariff()
        {
            return this.tariff;
        }

    }
}
