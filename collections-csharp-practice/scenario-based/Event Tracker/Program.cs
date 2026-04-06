using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_And_Annotation.Event_Tracker
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            EventTracker tracker = new EventTracker();
            int choice;

            do
            {
                Console.WriteLine("Event Tracker Menu");
                Console.WriteLine("1. Scan Audited Events");
                Console.WriteLine("2. View JSON Audit Logs");
                Console.WriteLine("3. Exit");

                Console.WriteLine("Enter Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        tracker.ScanAudit();
                        break;

                    case 2:
                        tracker.ShowJsonLogs();
                        break;

                    case 3:
                        Console.WriteLine("Event Tracker");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            } while (choice != 3);
        }
    }
}
