using System;

namespace Programming.Model.Classes
{
    public class Song 
    {
        private string SongName { get; set; }
        private string SongGenre { get; set; }
        private string Artist { get; set; }

        public Song MakeClearSong()
        {
            return new Song();
        }

        public Song MakeSong(string songName, string songGenre, string artist)
        {
            Song song = new Song();
            return song;
        }
    }


}
