/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace StructApplication
{
    /// <summary> 
    /// This class demonstrates struct use case.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            // default constructor used
            Coords coords1 = new Coords();
            coords1.WriteData();

            // parameter constructor used
            Coords coords2 = new Coords(100, 50);
            coords2.WriteData();

            // you can even use it without new-keyword
            Coords coords3;
            coords3.X = 25;
            coords3.Y = 75;
            coords3.WriteData();

            Coords coords4;
            coords4.X = 200;
            //coords4.Y = 200;
            // you can't use struct until all its variables are initialized
            // you need uncomment above line
            //coords4.WriteData();

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
