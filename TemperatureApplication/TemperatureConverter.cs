/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */

namespace TemperatureApplication
{
    /// <summary> 
    /// This class converts temperatures from c to f and vice verca.
    /// </summary> 
    class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            // convert Celsius to Fahrenheit.
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            // convert Fahrenheit to Celsius.
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
