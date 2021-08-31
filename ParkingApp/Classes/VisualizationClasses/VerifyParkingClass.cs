namespace ParkingApp.Classes
{
    class VerifyParkingClass
    {
        public bool isCorrectNumberOfTerminals()
        {
            int i = 0;
            int j = 0;
            int count = 0;
            int parkingPlaces = 0;
            while (i < Globals.WIDTH)
            {
                j = 0;
                while (j < Globals.HEIGHT)
                {
                    if (Globals.patterns[i, j].Equals(Globals.ENTRANCE))
                    {
                        count++;
                    }
                    if (Globals.patterns[i, j].Equals(Globals.EXIT))
                    {
                        count++;
                    }
                    if (Globals.patterns[i, j].Equals(Globals.CASH_BOX))
                    {
                        count++;
                    }
                    if (Globals.patterns[i, j].Equals(Globals.PARKING_PLACE))
                    {
                        parkingPlaces++;
                    }
                    j++;
                }
                i++;
            }
            if (count == 3 && parkingPlaces != 0) return true;
            else return false;
        }

        public bool isTerminalsAtTheBorder()
        {
            int i = 0;
            int j = 0;
            int x = 0;
            int y = 0;
            int z = 0;
            while (i < Globals.WIDTH)
            {
                j = 0;
                while (j < Globals.HEIGHT)
                {
                    if (i == 0 || j == 0 || i == Globals.WIDTH - 1 || j == Globals.HEIGHT - 1)
                    {
                        if (Globals.patterns[i, j].Equals(Globals.ENTRANCE))
                        {
                            x++;
                        }
                        if (Globals.patterns[i, j].Equals(Globals.EXIT))
                        {
                            y++;
                        }
                        if (Globals.patterns[i, j].Equals(Globals.CASH_BOX))
                        {
                            z++;
                        }
                    }
                    j++;
                }
                i++;
            }
            if (x != 1 || y != 1 || z != 1)
            {
                return false;
            }
            else return true;
        }
    }
}
