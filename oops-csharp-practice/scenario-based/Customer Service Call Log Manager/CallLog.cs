using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Customer_Service_Call_Log_Manager
{
    public class CallLog
    {
        public string phoneNumber; 
        public DateTime callTime;

        public CallLog(string phoneNumber, DateTime callTime)
        {
            this.phoneNumber = phoneNumber;
            this.callTime = callTime;
		}

        public void displayCallLog()
        {
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Call Time: { callTime}");
		}
	}
}
