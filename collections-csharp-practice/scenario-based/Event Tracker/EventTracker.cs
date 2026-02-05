using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Reflection_And_Annotation.Event_Tracker
{
    public class EventTracker
    {
        List<object> auditLogs = new List<object>();
        
        public void ScanAudit()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var classes = assembly.GetTypes().Where(t=>t.IsClass);
            foreach (var Class in classes)
            {
                var methods = Class.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
                foreach (var method in methods) 
                {
					var audit = Class.GetCustomAttribute<AuditTrailAttribute>();
					if (audit != null)
					{
						var log = new
						{
							Action = audit.ActionName,
							Class = Class.Name,
							Method = method.Name,
							Time = DateTime.Now,
						};
						auditLogs.Add(log);

					}
				}
                
                
            }
            Console.WriteLine("Audit Scan Completed");
        }

        public void ShowJsonLogs() 
        {
            if (auditLogs.Count == 0) 
            {
                Console.WriteLine("No Audit Logs Found.");
                return;
            }

            string json = JsonSerializer.Serialize(auditLogs,new JsonSerializerOptions {WriteIndented = true });
            Console.WriteLine("\nAudit logs (json): \n");
            Console.WriteLine(json);
        }


    }
}
