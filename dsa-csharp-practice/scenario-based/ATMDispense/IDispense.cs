using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.ATMDispense
{
    public  interface IDispense
    {
		Dictionary<int, int> Dispense(int amount);
	}
}
