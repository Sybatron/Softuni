using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddRider_Should_AddSuccessfully()
        {
            //Rider {0} added in race.
            //Arrange
            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle unitMotorcycle = new UnitMotorcycle("Kawasaki", 60, 500);
            UnitRider rider = new UnitRider("Ivan", unitMotorcycle);

            //Act
            string resultMessage = raceEntry.AddRider(rider);

            //Assert
            string expectedMessage = "Rider Ivan added in race.";

            Assert.AreEqual(expectedMessage, resultMessage);
            Assert.AreEqual(raceEntry.Counter, 1);
        }

        [Test]
        public void AddRider_Should_ThrowInvalidOperationExceptionIfNull()
        {
            RaceEntry raceEntry = new RaceEntry();

            //Asert
            var ex = Assert.Throws<InvalidOperationException>(() => raceEntry.AddRider(null));

            string expectedMessage = "Rider cannot be null.";
            Assert.That(() => ex.Message == expectedMessage);
        }

        [Test]
        public void AddRider_Should_ThrowInvalidOperationExceptionIfRiderExists()
        {
            //Arrange
            RaceEntry raceEntry = new RaceEntry();

            UnitMotorcycle unitMotorcycle = new UnitMotorcycle("Kawasaki", 60, 500);
            UnitRider rider = new UnitRider("Ivan", unitMotorcycle);

            //Act
            string resultMessage = raceEntry.AddRider(rider);

            //Asert
            var ex = Assert.Throws<InvalidOperationException>(() => raceEntry.AddRider(rider));
            string expectedMessage = "Rider Ivan is already added.";
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [Test]
        public void CalculateAvarageHorsePower_Should_ReturnAverageHorsePowerOfAllRiders()
        {
            var raceEntry = new RaceEntry();
            UnitMotorcycle unitMotorcycle1 = new UnitMotorcycle("Kawasaki", 60, 500);
            UnitRider rider1 = new UnitRider("Ivan", unitMotorcycle1);

            UnitMotorcycle unitMotorcycle2 = new UnitMotorcycle("Honda", 24, 500);
            UnitRider rider2 = new UnitRider("Pesho", unitMotorcycle2);

            UnitMotorcycle unitMotorcycle3 = new UnitMotorcycle("Yamaha", 78, 500);
            UnitRider rider3 = new UnitRider("Gosho", unitMotorcycle3);

            raceEntry.AddRider(rider1);
            raceEntry.AddRider(rider2);
            raceEntry.AddRider(rider3);

            var result = raceEntry.CalculateAverageHorsePower();
            var expectedResult = 54;

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculateAvarageHorsePower_Should_ReturnInvalidOperationExceptionWhenThereAreOnlyTwoRiders()
        {
            var raceEntry = new RaceEntry();
            UnitMotorcycle unitMotorcycle1 = new UnitMotorcycle("Kawasaki", 60, 500);
            UnitRider rider1 = new UnitRider("Ivan", unitMotorcycle1);

            raceEntry.AddRider(rider1);

            var exception = Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
            var expectedMessage = "The race cannot start with less than 2 participants.";

            Assert.AreEqual(expectedMessage, exception.Message);
        }
    }
}