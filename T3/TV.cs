/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */

namespace T3
{
    /// <summary> 
    /// TV class...
    /// </summary> 
    class TV
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private bool isOpen;
        public bool IsOpen {
            get
            {
                return isOpen;
            }
            set
            {
                isOpen = value;
                if (value == false)
                {
                    Channel = 0;
                    Volume = 0;
                }
            }
        }
        public int Channel { get; set; }
        public int Volume { get; set; }

        public override string ToString()
        {
            return "Brand: " + Brand + " Model: " + Model + " IsOpen: " + IsOpen + " Channel " + Channel + " Volume: " + Volume;
        }
    }
}
