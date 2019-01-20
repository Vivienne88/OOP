using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo power is on!");
        }

        public void Off()
        {
            Console.WriteLine("Stereo power is off!");
        }

        public void SetCd()
        {
            Console.WriteLine("Stereo Cd Mode");
        }

        public void SetDvd()
        {
            Console.WriteLine("Stereo Dvd Mode");
        }

        public void SetRadio()
        {
            Console.WriteLine("Stereo Radio Mode");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Volume is {0}", volume);
        }
    }
}
