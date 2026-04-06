using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_And_Annotation.Event_Tracker
{
    public class UserActions
    {
        [AuditTrail("user Login")]
        public void UserLogin() { }

        [AuditTrail(" file upload")]
        public void FileUpload() { }

        [AuditTrail("Delete")]
        public void Delete() { }

        public void ViewProfile() { }
        
    }
}
