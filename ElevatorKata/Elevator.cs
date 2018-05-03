using System.Collections.Generic;

namespace ElevatorKata
{
    public class Elevator
    {
        public IList<int> VisitedFloors { get; set; }

        public int CurrentFloor { get; private set; }

        public Elevator(int floor)
        {
            CurrentFloor = floor;
        }

        public void RequestFrom(int initialFloor)
        {
            CurrentFloor = initialFloor;
            if (VisitedFloors == null)
            {
                VisitedFloors = new List<int>();
            }
            VisitedFloors.Add(initialFloor);
        }

        public void GoTo(int destinationFloor)
        {
            CurrentFloor = destinationFloor;
        }
    }
}
