using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class LightOffCommand : Command
    {
        Light ligth;

        public LightOffCommand(Light light)
        {
            this.ligth = light;
        }

        public void Execute()
        {
            this.ligth.Off();
        }
    }
}
