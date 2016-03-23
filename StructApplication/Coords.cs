/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 12/01/2016 
 * Authors: Pasi Manninen
 */

using System;

namespace StructApplication
{
    /// <summary> 
    /// Sturct Coords...
    /// </summary> 
    struct Coords
    {
        public int X, Y;

        public Coords(int x, int y)
        {
            X = x;
            Y = y;
        }


        // you cant initialize field members
        //public int X = 100;

        // you cant do parameterless constructor
        /*
        public Coors()
        {

        }
        */

        public void WriteData()
        {
            Console.WriteLine("({0},{1})",X,Y);
        }


    }
}
