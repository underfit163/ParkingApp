using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingApp.Classes.AlgPathFind
{
    class FindPaths
    {
        public static PathPoint startPark;
        public static PathPoint endPark;
        public static PathPoint startRoad;
        public static PathPoint endRoad;
        public static PathPoint preStartPark;
        public static PathPoint preEndPark;

        public static List<PathPoint> parkPoints = new List<PathPoint>();
        public static List<PathPoint> carPoints = new List<PathPoint>();
        // public static List<PathPoint> freeParkPoints = new List<PathPoint>();
        public static int[,] parkMatr;
        public static int[,] roadMatr;
       // public static bool startEnd;
        //  public static List<PathPoint> PointsPath = new List<PathPoint>();

        public static void fillParkMatr()
        {
            parkMatr = new int[Globals.WIDTH, Globals.HEIGHT];
            startPark = new PathPoint(0, 0);
            endPark = new PathPoint(0, 0);
            preStartPark = new PathPoint(0, 0);
            preEndPark = new PathPoint(0, 0);

            for (int i = 0; i < Globals.WIDTH; i++)
            {
                for (int j = 0; j < Globals.HEIGHT; j++)
                {
                    if (Globals.patterns[i, j] == Globals.ROAD)
                    {
                        parkMatr[i, j] = 0;
                    }
                    else if (Globals.patterns[i, j] == Globals.PARKING_PLACE)
                    {
                        parkMatr[i, j] = 5;
                        parkPoints.Add(new PathPoint(i, j));
                       
                    }
                    else if (Globals.patterns[i, j] == Globals.ENTRANCE)
                    {
                        parkMatr[i, j] = 1;
                        startPark.X = i;
                        startPark.Y = j;
                        preStartPark = getPosStartEnd(startPark,preStartPark);
                    }
                    else if (Globals.patterns[i, j] == Globals.EXIT)
                    {
                        parkMatr[i, j] = 1;
                        endPark.X = i;
                        endPark.Y = j;
                        preEndPark = getPosStartEnd(endPark, preEndPark);
                     //   preEndPark.X = i;
                     //   preEndPark.Y = j;
                    }
                    else
                    {
                        parkMatr[i, j] = 2;
                    }
                }
            }
        }
        //Функция вычисления направления
        public static PathPoint getPosStartEnd(PathPoint pointPark, PathPoint pointRoad)
        {
            if (pointPark.Y == 0 && Globals.leftAdjacentRoadLength !=0 && Globals.upAdjacentRoadLength!= 0)
            {
                pointRoad = new PathPoint(pointPark.X+1, pointPark.Y);
            }
            if (pointPark.Y == 0 && Globals.leftAdjacentRoadLength != 0 && Globals.downAdjacentRoadLength != 0)
            {
                pointRoad = new PathPoint(pointPark.X, pointPark.Y);
            }
            else if (pointPark.X == 0 && Globals.leftAdjacentRoadLength != 0 && Globals.upAdjacentRoadLength != 0)
            {
                pointRoad = new PathPoint(pointPark.X, pointPark.Y+1);
            }
            else if (pointPark.X == 0 && Globals.rightAdjacentRoadLength != 0 && Globals.upAdjacentRoadLength != 0)
            {
                pointRoad = new PathPoint(pointPark.X, pointPark.Y);
            }
            else if (pointPark.Y == Globals.HEIGHT-1 && Globals.rightAdjacentRoadLength != 0 && Globals.upAdjacentRoadLength != 0)
            {
                pointRoad = new PathPoint(pointPark.X+1, pointPark.Y+1);
            }
            else if (pointPark.Y == Globals.HEIGHT-1 && Globals.rightAdjacentRoadLength != 0 && Globals.downAdjacentRoadLength != 0)
            {
                pointRoad = new PathPoint(pointPark.X, pointPark.Y+1);
            }
            else if (pointPark.X == Globals.WIDTH-1 && Globals.rightAdjacentRoadLength != 0 && Globals.downAdjacentRoadLength != 0)
            {
                pointRoad = new PathPoint(pointPark.X + 1, pointPark.Y);
            }
            else if (pointPark.X == Globals.WIDTH-1 && Globals.leftAdjacentRoadLength != 0 && Globals.downAdjacentRoadLength != 0)
            {
                pointRoad = new PathPoint(pointPark.X+1, pointPark.Y + 1);
            }
            return pointRoad;
        }
        
        public static void fillRoadMatr()
        {
            startRoad = new PathPoint(0, 0);
            endRoad = new PathPoint(0, 0);
            roadMatr = new int[Globals.WIDTH + 1, Globals.HEIGHT + 1];
            if (Globals.leftAdjacentRoadLength != 0 && Globals.downAdjacentRoadLength !=0)
            {
                endRoad = new PathPoint(0, 0);
                startRoad = new PathPoint(Globals.WIDTH, Globals.HEIGHT);
            }
            else if (Globals.leftAdjacentRoadLength != 0 && Globals.upAdjacentRoadLength != 0)
            {
                endRoad = new PathPoint(0, Globals.HEIGHT);
                startRoad = new PathPoint(Globals.WIDTH, 0);
            }
            else if (Globals.rightAdjacentRoadLength != 0 && Globals.downAdjacentRoadLength != 0)
            {
                endRoad = new PathPoint(Globals.WIDTH, 0);
                startRoad = new PathPoint(0, Globals.HEIGHT);
            }
            else if (Globals.rightAdjacentRoadLength != 0 && Globals.upAdjacentRoadLength != 0)
            {
                endRoad = new PathPoint(Globals.WIDTH, Globals.HEIGHT);
                startRoad = new PathPoint(0, 0);
            }

            for (int i = 0; i < Globals.WIDTH + 1; i++)
            {
                for (int j = 0; j < Globals.HEIGHT + 1; j++)
                {
                    if (Globals.highwayPatterns[i, j] == Globals.HIGHWAY)
                    {
                        roadMatr[i, j] = 7;
                    }
                    else { roadMatr[i, j] = 2; }
                }
            }
        }

        // выезжающая машины
        public static PathPoint getCarPoint(Car car)
        {
            if (carPoints.Count != 0)
            {
                try
                {
                    var t = carPoints.First(car2 => ((car2.X == car.currPos.X) && (car2.Y == car.currPos.Y)));
                    carPoints.Remove(t);
                    parkMatr[t.X, t.Y] = 3;// рассматриваемая машина
                    parkPoints.Add(t);
                    return t;
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
            return null;
        }

        //Поиск свободного места для легковых авто
        public static PathPoint getParkPoint(Car car)
        {          
            Random rnd = new Random();
            int value = rnd.Next(parkPoints.Count);
            //var f = freeParkPoints.ElementAt(value);
            
            var t = parkPoints.ElementAt(value);

            string placeNumber = t.X + "" + t.Y;
            car.parkingPlaceNumber = int.Parse(placeNumber);
            parkPoints.Remove(t);
            parkMatr[t.X, t.Y] = 3;// рассматриваемое парковочное место
            carPoints.Add(t);// добавляем машину в список          
            return t;
        }

        public static List<PathPoint> FindPath(int[,] field, PathPoint start, PathPoint goal)
        {
            //Создается 2 списка вершин — ожидающие рассмотрения и уже рассмотренные.
            //В ожидающие добавляется точка старта, список рассмотренных пока пуст.
            var closedSet = new List<PathNode>();
            var openSet = new List<PathNode>();
            //Для каждой точки рассчитывается F = G + H. G — расстояние от старта до точки, H — примерное расстояние от точки до цели.  
            //Так же каждая точка хранит ссылку на точку, из которой в нее пришли.
            PathNode startNode = new PathNode()
            {
                Position = start,
                CameFrom = null,
                PathLengthFromStart = 0,
                HeuristicEstimatePathLength = GetHeuristicPathLength(start, goal)
            };
            openSet.Add(startNode);
            while (openSet.Count > 0)
            {
                // Из списка точек на рассмотрение выбирается точка с наименьшим F. Обозначим ее X.
                var currentNode = openSet.OrderBy(node => node.EstimateFullPathLength).First();
                //Если X — цель, то мы нашли маршрут.
                if ((currentNode.Position.X == goal.X) && (currentNode.Position.Y == goal.Y))
                {
                    if ((field[goal.X, goal.Y] != 1) && (field[goal.X, goal.Y] != 7))
                    { field[goal.X, goal.Y] = 5; }//парковочное место занято}
                    return GetPathForNode(currentNode);
                }
                //Переносим X из списка ожидающих рассмотрения в список уже рассмотренных.
                openSet.Remove(currentNode);
                closedSet.Add(currentNode);
                //Для каждой из точек, соседних для X(обозначим эту соседнюю точку Y), делаем следующее:
                //Если Y уже находится в рассмотренных — пропускаем ее.
                foreach (var neighbourNode in GetNeighbours(currentNode, goal, field))
                {
                    //!!! Если Y уже находится в рассмотренных — пропускаем ее.
                    if (closedSet.Count(node => ((node.Position.X == neighbourNode.Position.X) && (node.Position.Y == neighbourNode.Position.Y))) > 0)
                        continue;
                    var openNode = openSet.FirstOrDefault(node => ((node.Position.X == neighbourNode.Position.X) && (node.Position.Y == neighbourNode.Position.Y)));
                    //!!!  Если Y еще нет в списке на ожидание — добавляем ее туда, запомнив ссылку на X и рассчитав Y.G (это X.G + расстояние от X до Y) и Y.H.
                    if (openNode == null)
                        openSet.Add(neighbourNode);
                    else
                    if (openNode.PathLengthFromStart > neighbourNode.PathLengthFromStart)
                    {
                        //Если же Y в списке на рассмотрение — проверяем, если X.G + расстояние от X до Y < Y.G, 
                        //значит мы пришли в точку Y более коротким путем, заменяем Y.G на X.G + расстояние от X до Y, а точку, из которой пришли в Y на X.
                        openNode.CameFrom = currentNode;
                        openNode.PathLengthFromStart = neighbourNode.PathLengthFromStart;
                    }
                }
            }
            //Если список точек на рассмотрение пуст, 
            //а до цели мы так и не дошли — значит маршрут не существует.
            return null;
        }

        // Функция расстояния от X до Y
        private static int GetDistanceBetweenNeighbours()
        {
            return 1;
        }

        //Функция примерной оценки расстояния до цели
        private static int GetHeuristicPathLength(PathPoint from, PathPoint to)
        {
            return (Math.Abs(from.X - to.X) + Math.Abs(from.Y - to.Y));
        }

        //Получение списка соседей для точки
        private static List<PathNode> GetNeighbours(PathNode pathNode, PathPoint goal, int[,] field)
        {
            var result = new List<PathNode>();
            // Соседними точками являются соседние по стороне клетки.
            PathPoint[] neighbourPoints = new PathPoint[4];
            neighbourPoints[0] = new PathPoint(pathNode.Position.X - 1, pathNode.Position.Y);
            neighbourPoints[1] = new PathPoint(pathNode.Position.X + 1, pathNode.Position.Y);
            neighbourPoints[2] = new PathPoint(pathNode.Position.X, pathNode.Position.Y - 1);
            neighbourPoints[3] = new PathPoint(pathNode.Position.X, pathNode.Position.Y + 1);
            foreach (var point in neighbourPoints)
            {
                // Проверяем, что не вышли за границы карты.
                if (point.X < 0 || point.X >= field.GetLength(0))
                    continue;
                if (point.Y < 0 || point.Y >= field.GetLength(1))
                {
                    continue;
                }
                // Проверяем, что по клетке можно ходить.!!!
                if ((field[point.X, point.Y] == 2) || (field[point.X, point.Y] == 5))
                    continue;
                // Заполняем данные для точки маршрута.
                var neighbourNode = new PathNode()
                {
                    Position = point,
                    CameFrom = pathNode,
                    PathLengthFromStart = pathNode.PathLengthFromStart + GetDistanceBetweenNeighbours(),
                    HeuristicEstimatePathLength = GetHeuristicPathLength(point, goal)
                };
                result.Add(neighbourNode);
            }
            return result;
        }
        //Получения маршрута. Маршрут представлен в виде списка координат точек
        private static List<PathPoint> GetPathForNode(PathNode pathNode)
        {
            var result = new List<PathPoint>();
            var currentNode = pathNode;
            while (currentNode != null)
            {
                result.Insert(0, currentNode.Position);
                currentNode = currentNode.CameFrom;
            }
            //result.Reverse();
            return result;
        }
    }
}
