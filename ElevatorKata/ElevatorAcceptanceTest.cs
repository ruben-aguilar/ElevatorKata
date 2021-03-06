﻿using System;
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
            GivenAnElevator();

            AnUserGoesFromTo(0, 3);
            AnUserGoesFromTo(2, -1);

            WhenTheElevatorOperates();

            ThenElevatorOpensDoorsIn(new List<int>() {0, 2, 3, -1});
        }

        [Test]
        public void Test2()
        {
            GivenAnElevator();

            AnUserGoesFromTo(2, 0);
            AnUserGoesFromTo(0, 1);

            WhenTheElevatorOperates();

            ThenElevatorOpensDoorsIn(new List<int>() { 2, 0, 1 });
        }

        [Test]
        public void Test3()
        {
            GivenAnElevator();

            AnUserGoesFromTo(-1, 2);
            AnUserGoesFromTo(3, 6);

            WhenTheElevatorOperates();

            ThenElevatorOpensDoorsIn(new List<int>() {-1, 2, 3, 6});
        }

        private void WhenTheElevatorOperates()
        {
            elevator.Operate();
        }

        private void GivenAnElevator()
        {
            elevator = new Elevator();
        }

        private void AnUserGoesFromTo(int initialFloor, int destinationFloor)
        {
            elevator.CallFrom(initialFloor);
            elevator.GoTo(destinationFloor);
        }

        private void ThenElevatorOpensDoorsIn(IList<int> floors)
        {
            Assert.AreEqual(floors, elevator.VisitedFloors);
        }
    }
}
