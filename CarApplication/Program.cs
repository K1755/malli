/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace CarApplication
{
    /// <summary> 
    /// This class uses Car class to create a few objects. Learning OOP...
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car instance
            Car datsun = new Car();
            datsun.Model = "Datsun 100A";
            datsun.Color = "red";
            datsun.Engine = 1.0;
            datsun.Speed = 0;
            datsun.FuzzyDices = true;
            datsun.DoorCount = 2;
            // set static property value
            Car.SomeProperty = 10;

            // display car data
            datsun.printData();
            Console.ReadLine();

            // accelerate, change car's speed value
            datsun.accelerate();
            // display car data again, notice changed speed value!
            datsun.printData();
            Console.ReadLine();

            // create one more car
            Car nascar = new Car { Model = "Speedster", Engine = 2.0 };
            nascar.Color = "Yellow";
            nascar.printData();

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
