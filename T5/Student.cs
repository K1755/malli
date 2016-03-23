/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 12/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T5
{
    /// <summary> 
    /// Student class...
    /// </summary> 
    class Student
    {
        public string Firstname { get; set; }
        public String Lastname { get; set; }
        public String StudenID { get; set; }
        public String GroupID { get; set; }
        public String Email { get; set; }
        public override string ToString()
        {
            return "Student:\n-Firstname: " + Firstname + "\n-Lastname: " + Lastname + "\n-StudenID: " + StudenID + "\n-GroupID: " + GroupID + "\n-Email: " + Email;
        }
    }
}
