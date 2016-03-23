/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T3
{
    /// <summary> 
    /// This class creates a few TV class objects, just learning OOP
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create TV object
            TV tv = new TV();
            tv.Brand = "Sony";
            tv.Model = "X809C";
            tv.IsOpen = false;
            Console.WriteLine(tv.ToString());

            // put tv on
            tv.IsOpen = true;
            tv.Channel = 22;
            tv.Volume = 8;
            Console.WriteLine(tv.ToString());

            // close tv
            tv.IsOpen = false;
            Console.WriteLine(tv.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
