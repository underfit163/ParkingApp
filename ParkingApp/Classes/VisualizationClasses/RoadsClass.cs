using System.Windows.Forms;

namespace ParkingApp.Classes
{
    class RoadsClass
    {
        public void createRoads(Panel panel1)
        {
            AdjacentRoadClass roadClass = new AdjacentRoadClass();
            if (Globals.upAdjacentRoadLength != 0)
            {
                roadClass.createUpAdjacentRoad(panel1, Globals.upAdjacentRoadLength);
            }
            if (Globals.downAdjacentRoadLength != 0)
            {
                roadClass.createDownAdjacentRoad(panel1, Globals.downAdjacentRoadLength);

            }
            if (Globals.leftAdjacentRoadLength != 0)
            {
                roadClass.createLeftAdjacentRoad(panel1, Globals.leftAdjacentRoadLength);

            }
            if (Globals.rightAdjacentRoadLength != 0)
            {
                roadClass.createRightAdjacentRoad(panel1, Globals.rightAdjacentRoadLength);
            }
        }
    }
}
