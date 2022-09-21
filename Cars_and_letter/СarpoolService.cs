using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CarsAndLetter
{
    public interface IСarpoolService
    {
        
    }

    public class Carpool : IСarpoolService
    {
        private readonly uint countOfCars;
        public Carpool(uint countOfCars = 0)
        {
            this.countOfCars = countOfCars;
        }

        public double GetMaxDistance(double countOfCars, double flueCapacity)
        {
            if (countOfCars == 1) return flueCapacity;
            return  (flueCapacity / countOfCars) 
                    + GetMaxDistance(countOfCars - 1, flueCapacity);
        }
        
        public double GetMaxDistance(double flueCapacity)
        {
            var maxDistance = 0d;
            
            for (var i = countOfCars; i >= 1; i--)
            {
                maxDistance += flueCapacity / i;
            }

            return maxDistance;
        }
        
        public double GetMaxDistance(IEnumerable<Car> cars)
        {
            var maxDistance = 0d;
            int j = 0;
            
            foreach (var car in cars)
            {
                try
                {
                    maxDistance += car.fuelCapacity / (cars.Count() - j);
                    j++;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e);
                }
                
            }

            return maxDistance;
        }
    }
}