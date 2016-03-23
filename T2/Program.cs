/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T2
{
    /// <summary> 
    /// This class creates a few Washer class objects, just learning OOP
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.Brand = "Miele";
            washer.Model = "WMC120FIN";
            washer.EnergyClass = "A";
            washer.LaundryAmount = 0;
            washer.SpinSpeed = 1900;
            washer.AddLaundry(5);
            Console.WriteLine(washer.ToString());

            washer.RemoveLaundry();
            Console.WriteLine(washer.ToString());

            Washer wassheri = new Washer("Upo", "Pesukarhu");
            wassheri.EnergyClass = "B";
            wassheri.SpinSpeed = 2000;
            Console.WriteLine(wassheri.ToString());



            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
