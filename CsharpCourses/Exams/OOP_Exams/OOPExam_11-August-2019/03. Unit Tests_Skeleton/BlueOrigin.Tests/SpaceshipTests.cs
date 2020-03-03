namespace BlueOrigin.Tests
{
    using System;
    using NUnit.Framework;

    public class SpaceshipTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Spaceship_Should_ThrowArgumentNullExceptionIfSpaceshipNameIsNullOrEmpty()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new Spaceship("", 5));
            var expectedMessage = "Invalid spaceship name!\r\nParameter name: value";

            Assert.AreEqual(expectedMessage, ex.Message);

            ex = Assert.Throws<ArgumentNullException>(() => new Spaceship(null, 5));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [Test]
        public void Spaceship_Should_ThrowArgumentExceptionIfSpaceshipCapacityIsBelowZero()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Spaceship("Sputnik1", -2));
            var expectedMessage = "Invalid capacity!";

            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [Test]
        public void Add_Should_ThrowInvalidOperationExceptionIfSpaceshipIsFull()
        {
            var spaceship = new Spaceship("Sputnik1", 2);
            var astronaut1 = new Astronaut("Gosho", 54);
            var astronaut2 = new Astronaut("Pesho", 30.7);
            var astronaut3 = new Astronaut("Kiro", 46.23);

            spaceship.Add(astronaut1);
            spaceship.Add(astronaut2);

            var ex = Assert.Throws<InvalidOperationException>(() => spaceship.Add(astronaut3));
            var expectedMessage = "Spaceship is full!";

            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [Test]
        public void Add_Should_ThrowInvalidOperationExceptionIfAstronautAlreadyExist()
        {
            var spaceship = new Spaceship("Sputnik1", 5);
            var astronaut1 = new Astronaut("Gosho", 54);
            var astronaut2 = new Astronaut("Pesho", 30.7);
            var astronaut3 = new Astronaut("Kiro", 46.23);

            spaceship.Add(astronaut1);
            spaceship.Add(astronaut2);
            spaceship.Add(astronaut3);

            var ex = Assert.Throws<InvalidOperationException>(() => spaceship.Add(astronaut3));
            var expectedMessage = $"Astronaut {astronaut3.Name} is already in!";

            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [Test]
        public void Remove_Should_TrueIfAstronautExist()
        {
            var spaceship = new Spaceship("Sputnik1", 5);
            var astronaut1 = new Astronaut("Gosho", 54);
            var astronaut2 = new Astronaut("Pesho", 30.7);
            var astronaut3 = new Astronaut("Kiro", 46.23);

            spaceship.Add(astronaut1);
            spaceship.Add(astronaut2);
            spaceship.Add(astronaut3);

            Assert.IsTrue(spaceship.Remove("Kiro"));
        }
    }
}