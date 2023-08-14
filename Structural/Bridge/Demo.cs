using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Demo
    {
        public static void Run()
        {
            var remoteControl = new RemoteControl(new SonyTV());
            remoteControl.TurnOn();
            remoteControl.TurnOff();

            var advancedRemoteControl = new AdvancedRemoteControl(new SamsungTV());
            advancedRemoteControl.TurnOn();
            advancedRemoteControl.SetChannel(1);
            advancedRemoteControl.TurnOff();
        }
    }
}
