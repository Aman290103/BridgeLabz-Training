using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.ATMDispense
{
    public class ATMMain
    {
        public static void Main(String[] args)
        {
            ATMDispenser atm;

			Console.WriteLine("Scenario A: With 500rs note");
			atm = new ATMDispenser(new With500Strategy());
			atm.Dispense(880);

			Console.WriteLine("Scenario B: Without 500rs note");
			atm = new ATMDispenser(new Without500Strategy());
			atm.Dispense(880);

			Console.WriteLine("Scenario C: Fallback");
			atm = new ATMDispenser(new FallBackDispense());
			atm.Dispense(885);
		}
    }
}
