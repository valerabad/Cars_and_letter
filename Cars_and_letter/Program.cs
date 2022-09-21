using System;
using System.Collections.Generic;
using System.Globalization;
using CarsAndLetter;

namespace Cars_and_letter
{
    class Program
    {
        static void Main(string[] args)
        {
            uint countOfCars;
            Console.WriteLine("Please enter count of cars: ");
            var countOfCarsInput = Console.ReadLine();
            while (!uint.TryParse(countOfCarsInput, out countOfCars))
            {
                Console.WriteLine("Not a valid number, try again.");
                countOfCarsInput = Console.ReadLine();
            }
            
            double capacityForCar;
            Console.WriteLine("Please enter capacity for car: ");
            var capacityForCarInput = Console.ReadLine();
            while (!double.TryParse(capacityForCarInput, out capacityForCar))
            {
                Console.WriteLine("Not a valid number, try again.");
                capacityForCarInput = Console.ReadLine();
            }
            
            // 1st approach
            var carpool_ = new Carpool(countOfCars);
            var result1 = carpool_.GetMaxDistance(capacityForCar);
            Console.WriteLine(result1);
            
            // 2nd approach
            var carpool = new Carpool();
            var cars = FakeCar.Generate(countOfCars, capacityForCar);
            var result2 = carpool.GetMaxDistance(cars);
            Console.WriteLine(result2);
            
            // 3rd approach
            var result3 = carpool.GetMaxDistance(countOfCars, capacityForCar);
            Console.WriteLine(result3);

            Console.ReadKey();
        }
    }
}