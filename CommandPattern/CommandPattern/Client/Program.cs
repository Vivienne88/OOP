using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living room");
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            LightOnCommand LivingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            RemoteControl remote = new RemoteControl();
            remote.setCommand(0, kitchenLightOn, kitchenLightOff);
            remote.setCommand(1, LivingRoomLightOn, livingRoomLightOff);
            Console.WriteLine(remote.ToString());
            remote.onButtonWasPushed(0);
            remote.offButtonWasPushed(0);
            remote.onButtonWasPushed(1);
            remote.offButtonWasPushed(1);
        }
    }
}