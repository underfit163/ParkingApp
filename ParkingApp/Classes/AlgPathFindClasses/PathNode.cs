namespace ParkingApp.Classes.AlgPathFind
{
    class PathNode
    {
        // Координаты точки на карте.
        public PathPoint Position {get; set;}
        // Длина пути от старта (G).
        public int PathLengthFromStart {get; set;}
        // Ссылка на точку, из которой пришли в эту точку.
        public PathNode CameFrom { get; set; }
        // Примерное расстояние до цели (H).
        public int HeuristicEstimatePathLength { get; set; }
        // Ожидаемое полное расстояние до цели (F).
        public int EstimateFullPathLength
        {
            get
            {
                return this.PathLengthFromStart + this.HeuristicEstimatePathLength;
            }
        }
    }
}
