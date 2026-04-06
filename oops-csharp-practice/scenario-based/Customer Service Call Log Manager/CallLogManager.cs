using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Customer_Service_Call_Log_Manager
{
    public class CallLogManager
    {
        private CallLog[] logs;
        private int count;
		public CallLogManager(int size)
		{
			logs = new CallLog[size];
			count = 0;
		}

		public void AddCallLog(CallLog log)
		{
			if(count< logs.Length)
			{
				logs[count] = log;
				count++;
			}
			else
			{
				Console.WriteLine("Call log is full. Cannot add more logs.");
			}
		}

		public void SearchByKeyword(string keyword)
		{	
			foreach(CallLog log in logs)
			{
				if(log!= null && log.phoneNumber.Contains(keyword,StringComparison.OrdinalIgnoreCase))
				{
					log.displayCallLog();
				}
			}
		}

		public void FilterByTime(DateTime startTime, DateTime endTime)
		{
			foreach(CallLog log in logs) 
			{
				if(log != null && log.callTime>=startTime && log.callTime<=endTime)
				{
					log.displayCallLog();
				}
			}
		}
	}
    
} 

