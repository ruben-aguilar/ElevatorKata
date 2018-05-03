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
    }
}
