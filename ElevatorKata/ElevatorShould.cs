using System.Runtime.InteropServices;
using NUnit.Framework;

namespace ElevatorKata
{
    [TestFixture]
    public class ElevatorShould
    {
        [Test]
        public void BeInitializedInGivenFloor()
        {
            const int STARTING_FLOOR = 1;

            var elevator = new Elevator(STARTING_FLOOR);

            Assert.AreEqual(STARTING_FLOOR, elevator.CurrentFloor);
        }

        [Test]
        public void GoToTheRequestedFloorWhenIsRequested()
        {
            const int STARTING_FLOOR = 3;
            const int FINAL_FLOOR = 1;
            var elevator = new Elevator(STARTING_FLOOR);

            elevator.RequestFrom(FINAL_FLOOR);

            Assert.AreEqual(FINAL_FLOOR, elevator.CurrentFloor);
        }

        [Test]
        public void GoToTheDestinationFloorWhenIsSelected()
        {
            const int STARTING_FLOOR = 3;
            const int DESTINATION_FLOOR = 4;
            var elevator = new Elevator(STARTING_FLOOR);

            elevator.GoTo(DESTINATION_FLOOR);

            Assert.AreEqual(DESTINATION_FLOOR, elevator.CurrentFloor);
        }

        [Test]
        public void RecordTheVisitedFloors()
        {
            var elevator = new Elevator(3);
            elevator.RequestFrom(2);

            Assert.AreEqual(new [] {2}, elevator.VisitedFloors);
        }
    }
}
