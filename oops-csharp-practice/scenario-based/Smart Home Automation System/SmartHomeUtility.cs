using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Smart_Home_Automation_System
{
    public class SmartHomeUtility
    {
        public static void TurnOnDevice(IControllable device)
        {
            device.TurnOn();
		}
        public static void TurnOffDevice(IControllable device)
        {
            device.TurnOff();
		}
	}
}
