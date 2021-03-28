using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Interface
{
    class MusicFile
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        private int yearOfRelease;

        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }

        private int durationInSeconds;

        public int DurationInSeconds
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }

        public MusicFile() { }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }

        public void ChangeTitle(string title)
        {
            this.title = title;
        }
    }
}