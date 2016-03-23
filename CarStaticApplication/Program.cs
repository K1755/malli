/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace CarStaticApplication
{
    /// <summary> 
    /// This class uses car object. Car objects max speed is used as static.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Porcshe", 150);
            Car car2 = new Car("Lada", 80);
            Car car3 = new Car("Lambo", 250);
            Console.WriteLine("Car name is {0} and speed {1}", car1.Name, car1.Speed);
            Console.WriteLine("Car name is {0} and speed {1}", car2.Name, car2.Speed);
            Console.WriteLine("Car name is {0} and speed {1}", car3.Name, car3.Speed);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
