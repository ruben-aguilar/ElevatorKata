using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ElevatorKata
{
    [TestFixture]
    class ElevatorAcceptanceTest
    {
        private Elevator elevator;

        [Test]
        public void Test1()
        {
            GivenAnElevatorInFloor(0);

            AnUserGoesFromTo(0, 3);
            AnUserGoesFromTo(2, -1);

            ThenElevatorOpensDoorsIn(new[] {0, 2, 3, -1});
        }

        private void GivenAnElevatorInFloor(int floor)
        {
            elevator = new Elevator(floor);
        }

        private void AnUserGoesFromTo(int initialFloor, int destinationFloor)
        {
            elevator.RequestFrom(initialFloor);
            elevator.GoTo(destinationFloor);
        }

        private void ThenElevatorOpensDoorsIn(int[] floors)
        {
            Assert.AreEqual(floors, elevator.VisitedFloors);
        }
    }
}
