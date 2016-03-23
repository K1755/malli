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
    /// Car class...
    /// </summary> 
    class Car
    {
        // public field variables
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty { get; set;  }

        // don't create any constructor, so default one will be used

        // method to give more speed
        public void accelerate()
        {
            Speed += 5;
        }

        // method to slow down
        public void brake()
        {
            Speed -= 5;
        }

        // method to display car data
        public void printData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + Engine);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzy dices : " + FuzzyDices);
            Console.WriteLine("- door count : " + DoorCount);
            Console.WriteLine("- some static property : " + SomeProperty);
        }

        // destructor
        ~Car()
        {
            Console.WriteLine("Car object destroyed.");
        }
    }
}
