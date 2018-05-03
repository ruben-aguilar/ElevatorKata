namespace ElevatorKata
{
    public class Elevator
    {
        public int[] VisitedFloors { get; }

        public int CurrentFloor { get; private set; }

        public Elevator(int floor)
        {
            CurrentFloor = floor;
        }

        public void RequestFrom(int initialFloor)
        {
            CurrentFloor = initialFloor;
        }

        public void GoTo(int destinationFloor)
        {
            CurrentFloor = destinationFloor;
        }
    }
}
