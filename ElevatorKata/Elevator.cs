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
            throw new System.NotImplementedException();
        }

        public void GoTo(int destinationFloor)
        {
            throw new System.NotImplementedException();
        }
    }
}
