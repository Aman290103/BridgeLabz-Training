using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AeroVigil
{
    public class InvalidFlightException : Exception
    {
        public InvalidFlightException(String message) : base(message) { }
    }
}
