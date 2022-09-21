using System;
using NUnit.Framework;
using CarsAndLetter;

namespace Tests
{
    public class CarpoolServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetMaxDistance_IfCars50_FuelCapacity100()
        {
            // Arrange
            Carpool carpool = new Carpool(50);
            // Act
            var result = carpool.GetMaxDistance(100);
            // Assert
            Assert.AreEqual(449, result, 1);
        }
        
        [Test]
        public void GetMaxDistance_IfCars1_FuelCapacity100()
        {
            // Arrange
            Carpool carpool = new Carpool(1);
            // Act
            var result = carpool.GetMaxDistance(100);
            // Assert
            Assert.AreEqual(100, result, 1);
        }
        
        [Test]
        public void GetMaxDistance_IfCars5_FuelCapacity100()
        {
            // Arrange
            Carpool carpool = new Carpool(5);
            // Act
            var result = carpool.GetMaxDistance(100);
            // Assert
            Assert.AreEqual(228, result, 1);
        }
        
        [Test]
        public void GetMaxDistance_IfCars100_FuelCapacity50()
        {
            // Arrange
            Carpool carpool = new Carpool(100);
            // Act
            var result = carpool.GetMaxDistance(50);
            // Assert
            Assert.AreEqual(260, result, 1);
        }
        
        [Test]
        public void GetMaxDistance_IfCars50FuelCapacity100_Approach2()
        {
            // Arrange
            Carpool carpool = new Carpool();
            var cars = FakeCar.Generate(50, 100);
            // Act
            var result = carpool.GetMaxDistance(cars);
            // Assert
            Assert.AreEqual(449, result, 1);
        }
        
        [Test]
        public void GetMaxDistance_IfCars1FuelCapacity100_Approach2()
        {
            // Arrange
            Carpool carpool = new Carpool();
            var cars = FakeCar.Generate(1, 100);
            // Act
            var result = carpool.GetMaxDistance(cars);
            // Assert
            Assert.AreEqual(100, result, 1);
        }
        [Test]
        public void GetMaxDistance_IfCars100FuelCapacity100_Approach2()
        {
            // Arrange
            Carpool carpool = new Carpool();
            var cars = FakeCar.Generate(5, 100);
            // Act
            var result = carpool.GetMaxDistance(cars);
            // Assert
            Assert.AreEqual(228, result, 1);
        }

        // Recursive approach
        [Test]
        public void GetMaxDistance_Recursive_IfCars50()
        {
            // Arrange
            Carpool carpool = new Carpool();
            // Act
            var result = carpool.GetMaxDistance(50, 100);
            // Assert
            Assert.AreEqual(449, result, 1);
        }
        
        [Test]
        public void GetMaxDistance_Recursive_IfCars1()
        {
            // Arrange
            Carpool carpool = new Carpool();
            // Act
            var result = carpool.GetMaxDistance(1, 100);
            // Assert
            Assert.AreEqual(100, result, 1);
        }
        
        [Test]
        public void GetMaxDistance_Recursive_IfCars5()
        {
            // Arrange
            Carpool carpool = new Carpool();
            // Act
            var result = carpool.GetMaxDistance(5, 100);
            // Assert
            Assert.AreEqual(228, result, 1);
        }
    }
}