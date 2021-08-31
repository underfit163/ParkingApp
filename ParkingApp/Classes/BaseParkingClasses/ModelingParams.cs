using System.Collections.Generic;

namespace ParkingApp.Classes.BaseParkingClasses
{
    public class ModelingParams
    {
        public bool determFlow { get; set; }
        public bool randomFlow { get; set; }
        public double probability { get; set; }
        public int appearanceInterval { get; set; }
        public int onParkingInterval { get; set; }

        public List<double> appearanceIntervals { get; set; }
        public List<double> onParkingIntervals { get; set; }

        //для детерминированного потока
        public ModelingParams(bool determFlow, double probability, int appearanceInterval, int onParkingInterval)
        {
            this.determFlow = determFlow;
            this.probability = probability;
            this.appearanceInterval = appearanceInterval;
            this.onParkingInterval = onParkingInterval;
        }

        //для случайного потока
        public ModelingParams(bool randomFlow, double probability, List<double> appearanceIntervals, List<double> onParkingIntervals)
        {
            this.randomFlow = randomFlow;
            this.probability = probability;
            this.appearanceIntervals = appearanceIntervals;
            this.onParkingIntervals = onParkingIntervals;
        }
    }
}
