using System;

namespace Programming.Model.Classes
{
    public class Song 
    {
        public string SongName { get; set; }
        public string SongGenre { get; set; }
        public string Artist { get; set; }

        public Song()
        {

        }

        public Song(string artist, string songGenre, string songName)
        {
            Artist = artist;
            SongName = songName;
            SongGenre = songGenre;
        }
    }


}
