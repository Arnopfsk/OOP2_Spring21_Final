using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ipod Player: ");
            Ipod ip1 = new Ipod();

            ip1.Switch(true);
            ip1.Play(true);
            ip1.PlayNext();
            ip1.PlayPrevious();
            ip1.SetVolume(8);

            Console.WriteLine();

            Console.WriteLine("Phone Player: ");
            Phone ph1 = new Phone();

            ph1.Switch(true);
            ph1.Retune(69.9);
            ph1.SetVolume(6);
            ph1.ChangeChannel();

            Console.WriteLine();
        }
    }
}