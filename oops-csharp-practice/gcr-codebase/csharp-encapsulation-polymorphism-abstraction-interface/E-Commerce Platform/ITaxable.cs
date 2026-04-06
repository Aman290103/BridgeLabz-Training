using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.E_Commerce_Platform
{
    public interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
         
	}
}
