using System;
using System.Collections.Generic;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Triumph";
            myCar.Model = "Spitfire";
            myCar.Year = 1972;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "cx-5",
                Year = 2016

            };

            var chevy = new Car("Chevy", "Impala", 2001);

            var carList = new List<Car>() { myCar, mazda, chevy };

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }
        }
    }
}
