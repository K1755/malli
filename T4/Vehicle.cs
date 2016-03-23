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
    /// Vehicle class...
    /// </summary> 
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Name: {0} Speed: {1} Tyles: {2}", Name, Speed, Tyres);
        }

        public override string ToString()
        {
            return "Name: " + Name + " Speed: " + Speed + " Tyres: " + Tyres;
        }
    }
}
