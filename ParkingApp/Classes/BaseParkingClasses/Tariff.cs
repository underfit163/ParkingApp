using System;

namespace ParkingApp
{
    [Serializable]
    public class Tariff
    {
        public String rateType { get; set; }
        public int carPrice { get; set; }

        public Tariff(string rateType, int carPrice)
        {
            this.rateType = rateType;
            this.carPrice = carPrice;
        }
    }
}
