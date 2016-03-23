/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */

namespace T2
{
    /// <summary> 
    /// Washer class...
    /// </summary> 
    class Washer
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string EnergyClass { get; set; }
        public int SpinSpeed { get; set; }
        public int LaundryAmount { get; set; }

        public Washer()
        {

        }

        public Washer(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public void AddLaundry(int laundry)
        {
            LaundryAmount += laundry;
        }

        public void RemoveLaundry()
        {
            LaundryAmount = 0;
        }

        public override string ToString()
        {
            return "Brand: "+ Brand + " Model: "+ Model + " EnergyClass: "+ EnergyClass + " SpinSpeed "+ SpinSpeed + " LaundryAmount: "+LaundryAmount;
        }
    }
}
