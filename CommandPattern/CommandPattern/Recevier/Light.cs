using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Light
    {
        string location;

        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine("{0} Light is on", this.location);
        }

        public void Off()
        {
            Console.WriteLine("{0} Light is off", this.location);
        }
    }
}
