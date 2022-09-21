using System;
using System.Collections;
using System.Collections.Generic;
using Bogus;

namespace CarsAndLetter
{
    public class Car
    {
        public Guid Id { get; set; }
        public string NumberPlate { get; set; }
        public double fuelCapacity;
    }

    public class FakeCar
    {
        private static readonly Faker<Car> faker = new Faker<Car>()
            .RuleFor(x => x.Id, _ => Guid.NewGuid())
            .RuleFor(x => x.NumberPlate, f => f.Vehicle.Vin());

        public static IEnumerable<Car> Generate(uint count, double fuelCapacity)
            => faker.RuleFor(x => x.fuelCapacity, fuelCapacity)
                .Generate((int)count);
    }
}