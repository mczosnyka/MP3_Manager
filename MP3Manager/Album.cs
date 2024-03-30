using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3Manager
{
    public class Album
    {
        public string name { get; set; }

        public string artist { get; set; }

        public int releaseYear { get; set; }

        public string date { get; set; }

        public Album(string name, string artist, int releaseYear, string date)
        {
            this.name = name;
            this.artist = artist;
            this.releaseYear = releaseYear;
            this.date = date;
        }
    }
}
