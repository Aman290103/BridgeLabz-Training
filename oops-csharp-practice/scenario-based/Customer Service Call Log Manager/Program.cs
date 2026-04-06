using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Customer_Service_Call_Log_Manager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CallLogManager logManager = new CallLogManager(10);
            logManager.AddCallLog(new CallLog("123-456-7890", DateTime.Now.AddHours(-1)));
            logManager.AddCallLog(new CallLog("987-654-3210", DateTime.Now.AddHours(-2)));
            logManager.AddCallLog(new CallLog("555-555-5555", DateTime.Now.AddHours(-3)));
            Console.WriteLine("Search Results for:");
            logManager.SearchByKeyword(Console.ReadLine());
			Console.WriteLine("\nEnter number of hours to filter logs from:");
			int hours = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"\nFilter Results from last {hours} hours:");
			DateTime startTime = DateTime.Now.AddHours(-hours);
			DateTime endTime = DateTime.Now;
			logManager.FilterByTime(startTime, endTime);
		}
	}
}
