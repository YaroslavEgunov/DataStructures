using System;

namespace Programming.Model.Classes
{
    public class Song 
    {
        private string _songName { get; set; }
        private string _songGenre { get; set; }
        private string _artist { get; set; }

        public Song()
        {
        }

        public Song(string artist, string songGenre, string songName)
        {
            _artist = artist;
            _songName = songName;
            _songGenre = songGenre;
        }
    }


}
