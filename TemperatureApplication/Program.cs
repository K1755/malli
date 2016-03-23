/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace TemperatureApplication
{
    /// <summary> 
    /// This class demonstrates static methods using in OOP.
    /// </summary> 
    class Program
    {
        static void Main(string[] args)
        {
            double F = TemperatureConverter.CelsiusToFahrenheit(100);
            Console.WriteLine("100 Celsius is {0:F2} in Fahrenheit", F);

            double C = TemperatureConverter.FahrenheitToCelsius(100);
            Console.WriteLine("100 Fahrenheit is {0:F2} in Celsius", C);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadKey();
        }
    }
}
