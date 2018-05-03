using System.Collections.Generic;

namespace ElevatorKata
{
    public class Elevator
    {
        private IList<int> CallingFloors { get; set; }

        private IList<int> RequestedFloors { get; set; }

        public IList<int> VisitedFloors { get; private set; }

        public Elevator()
        {
            CallingFloors = new List<int>();
            RequestedFloors = new List<int>();
            VisitedFloors = new List<int>();
        }

        public void CallFrom(int initialFloor)
        {
            CallingFloors.Add(initialFloor);
        }

        public void GoTo(int destinationFloor)
        {
            RequestedFloors.Add(destinationFloor);
        }

        public void Operate()
        {
            foreach (int callingFloor in CallingFloors)
            {
               VisitedFloors.Add(callingFloor);
            }
            foreach (int requestedFloor in RequestedFloors)
            {
                VisitedFloors.Add(requestedFloor);
            }

            RemoveConsecutiveFloors();
        }

        private void RemoveConsecutiveFloors()
        {
            for (int i = VisitedFloors.Count - 1; i >= 1; i--)
            {
                if (VisitedFloors[i] == VisitedFloors[i - 1])
                {
                    VisitedFloors.RemoveAt(i);
                }
            }
        }
    }
}
