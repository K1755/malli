/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */

namespace IndexerApplication
{
    /// <summary> 
    /// This class demonstrates indexer as a string collector.
    /// </summary> 
    class StringCollector
    {
        private string[] strings = new string[100];

        public string this[int i]
        {
            get
            {
                return strings[i];
            }
            set
            {
                strings[i] = value;
            }
        }
    }
}
