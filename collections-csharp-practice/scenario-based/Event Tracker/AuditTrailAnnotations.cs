using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_And_Annotation.Event_Tracker
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AuditTrailAttribute : Attribute
    {
        public string ActionName { get;}

        public AuditTrailAttribute(string actionName)
        {
            ActionName = actionName;
        }
        
    }
}
