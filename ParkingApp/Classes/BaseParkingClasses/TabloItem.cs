namespace ParkingApp.Classes.BaseParkingClasses
{
    public class TabloItem
    {
        public double onParkingTime { get; set; }
        public int placeNumber { get; set; }
        public int totalPrice { get; set; }


        public TabloItem(double onParkingTime, int placeNumber, int totalPrice)
        {
            this.onParkingTime = onParkingTime;
            this.placeNumber = placeNumber;
            this.totalPrice = totalPrice;
        }
    }
}