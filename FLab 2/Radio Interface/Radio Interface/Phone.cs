using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Interface
{
    class Phone : IMusicPlayerInterface, IRadioPlayerInterface
    {
        public void ChangeChannel()
        {
            Console.WriteLine("The Channel is Changing");
        }

        public void Play(bool on)
        {
            Console.WriteLine("The Music is playing");
        }

        public void SetVolume(int loudness)
        {
            Console.WriteLine("Setting volume to:" + loudness);
        }

        public void PlayNext()
        {
            Console.WriteLine("The Next Music is playing");
        }

        public void PlayPrevious()
        {
            Console.WriteLine("The Previous Music is playing");
        }

        public void Retune(double frequency)
        {
            Console.WriteLine("Retuning to Frequency:" + frequency);
        }


        public void Switch(bool on)
        {
            Console.WriteLine("The Switch is Turning  ON");
        }
    }
}