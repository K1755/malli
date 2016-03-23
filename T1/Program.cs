/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
 using System;

namespace T1
{
    /// <summary> 
    /// This class creates a few Heater class objects, just learning OOP
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create one heater object
            Heater heater = new Heater();
            // set some values
            heater.IsOn = true;
            heater.Temperature = 100;
            heater.Humidity = 78;
            // print values
            Console.WriteLine("Is heater on : {0}", heater.IsOn);
            Console.WriteLine("Heater temperature : {0}", heater.Temperature);
            Console.WriteLine("Heater humidity : {0}", heater.Humidity);

            // changes values
            heater.Temperature = 0;
            heater.Humidity = 0;
            heater.IsOn = false;
            // print values
            Console.WriteLine("Is heater on : {0}", heater.IsOn);
            Console.WriteLine("Heater temperature : {0}", heater.Temperature);
            Console.WriteLine("Heater humidity : {0}", heater.Humidity);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
