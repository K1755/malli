/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T4
{
    /// <summary> 
    /// This class creates a few Vehicle class objects, just learning OOP
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buss = new Vehicle();
            buss.Name = "Volvo";
            buss.Speed = 20;
            buss.Tyres = 8;
            buss.PrintData();
            buss.Speed = 65;
            Console.WriteLine(buss.ToString());

            Vehicle car = new Vehicle();
            car.Name = "Honda";
            car.Speed = 100;
            car.Tyres = 4;
            car.PrintData();
            car.Speed = 200;
            Console.WriteLine(car.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
