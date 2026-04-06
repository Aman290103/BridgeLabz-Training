using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.ChargeMaster
{
    public class InvalidChargingDataException : Exception
    {
        public InvalidChargingDataException(string message) : base(message) { }
    }
}
