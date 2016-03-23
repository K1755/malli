/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T5
{
    /// <summary> 
    /// This class creates a few Student class objects, just learning OOP
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student { Firstname = "Pekka", Lastname = "Peloton", Email = "pekka@domain.fi", StudenID = "S000", GroupID = "TTVS00" };
            students[1] = new Student { Firstname = "Kirsi", Lastname = "Keloton", Email = "kirsi@domain.fi", StudenID = "T100", GroupID = "TTVS01" };
            students[2] = new Student { Firstname = "Matti", Lastname = "Merkkel", Email = "matti@domain.fi", StudenID = "VV00", GroupID = "TTVS02" };
            students[3] = new Student { Firstname = "Maija", Lastname = "Junnila", Email = "maija@domain.fi", StudenID = "S0S0", GroupID = "TTVS03" };
            students[4] = new Student { Firstname = "Jussi", Lastname = "Nikkilä", Email = "jussi@domain.fi", StudenID = "BB90", GroupID = "TTVS04" };

            foreach(Student student in students)
            {
                Console.Write(student.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
