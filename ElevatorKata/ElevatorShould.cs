using System.Collections.Generic;
using NUnit.Framework;

namespace ElevatorKata
{
    [TestFixture]
    public class ElevatorShould
    {
        [Test]
        public void RecordTheRequestingFloors()
        {
            var elevator = new Elevator();
            elevator.CallFrom(2);
            elevator.Operate();

            Assert.AreEqual(new[] { 2 }, elevator.VisitedFloors);
        }

        [Test]
        public void RecordTheRequestedFloors()
        {
            var elevator = new Elevator();
            elevator.GoTo(4);
            elevator.Operate();
            Assert.AreEqual(new[] { 4 }, elevator.VisitedFloors);
        }

        [Test]
        public void GoToTheRequestingFloorsAndThenToTheRequestedFloorsInOrderWhenOperates()
        {
            var elevator = new Elevator();

            elevator.CallFrom(0);
            elevator.GoTo(3);
            elevator.CallFrom(2);
            elevator.GoTo(4);
            elevator.Operate();

            Assert.AreEqual(new List<int>() { 0, 2, 3, 4 }, elevator.VisitedFloors);
        }

        [Test]
        public void NotRecordRepeatedConsecutiveFloors()
        {
            var elevator = new Elevator();

            elevator.CallFrom(2);
            elevator.GoTo(0);
            elevator.CallFrom(0);
            elevator.GoTo(1);
            elevator.Operate();

            Assert.AreEqual(new List<int>() { 2, 0, 1 }, elevator.VisitedFloors);
        }

        [Test]
        public void OpenTheDoorsInOrderWhenMovingInOneDirection()
        {
            var elevator = new Elevator();

            elevator.CallFrom(-1);
            elevator.GoTo(2);
            elevator.CallFrom(3);
            elevator.GoTo(6);
            elevator.Operate();

            Assert.AreEqual(new List<int>() { -1, 2, 3, 6 }, elevator.VisitedFloors);
        }
    }
}
