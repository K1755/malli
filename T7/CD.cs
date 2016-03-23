/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 12/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T7
{
    /// <summary> 
    /// CD class...
    /// </summary> 
    class CD
    {
        private const int MaxSongs = 20;
        private int SongsAdded = 0;
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public Song[] Songs;

        public CD()
        {
            Songs = new Song[MaxSongs];
        }
        public void AddSong(Song song)
        {
            if (SongsAdded < MaxSongs)
            {
                Songs[SongsAdded] = song;
                SongsAdded++;
            } else
            {
                Console.WriteLine("Can't added more songs to CD!");
            }
        }

        public override string ToString()
        {
            string data = "CD:";
            data += "\n-Artist: " + Artist + "\n-Name: " + Name + "\n-Genre: " + Genre + "\n-Price: " + Price +"$";
            data += "\nSongs:";
            
            foreach(Song song in Songs)
            {
                if (song != null) data += "\n--"+song.ToString();
            }
            return data;
        }
    }
}
