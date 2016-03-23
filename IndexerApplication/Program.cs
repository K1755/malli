/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace IndexerApplication
{
    /// <summary> 
    /// This class demonstrates indexer in C#.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StringCollector stringCollector = new StringCollector();

            stringCollector[0] = "Hello!";
            stringCollector[1] = "Terve!";
            stringCollector[2] = "Hej!";

            Console.WriteLine(stringCollector[0]);
            Console.WriteLine(stringCollector[1]);
            Console.WriteLine(stringCollector[2]);

            Console.WriteLine("Press enter key to continue..");
            Console.ReadLine();
        }
    }
}
