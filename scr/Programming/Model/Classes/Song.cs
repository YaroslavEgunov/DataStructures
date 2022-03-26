using System;

namespace Programming.Model.Classes
{
    public class Song 
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Artist { get; set; }

        public Song()
        {
        }

        public Song(string artist, string genre, string name)
        {
            Artist = artist;
            Name = name;
            Genre = genre;
        }
    }
}
