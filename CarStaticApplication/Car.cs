/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
namespace CarStaticApplication
{
    /// <summary> 
    /// Car class...
    /// </summary> 
    class Car
    {
        public string Name;
        private static int MaxSpeed = 200;
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value <= MaxSpeed) speed = value;
                else speed = MaxSpeed;
            }
        }

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
