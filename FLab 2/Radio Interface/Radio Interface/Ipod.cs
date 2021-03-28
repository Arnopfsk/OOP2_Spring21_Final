using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Interface
{
    class Ipod : IMusicPlayerInterface
    {
        public void Play(bool on)
        {
            Console.WriteLine("The Music is Playing");
        }

        public void PlayNext()
        {
            Console.WriteLine("The Next Music is Playing");
        }

        public void PlayPrevious()
        {
            Console.WriteLine("The Previous Music is Playing");
        }

        public void SetVolume(int loudness)
        {
            Console.WriteLine("Setting volume to: " + loudness);
        }

        public void Switch(bool on)
        {
            Console.WriteLine("The Switch is Turning  ON");
        }
    }
}