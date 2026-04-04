using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.ATMDispense
{
    public class ATMDispenser
    {
        public IDispense Idispense;

        public ATMDispenser(IDispense Idispense)
        {
            this.Idispense = Idispense;
        }
        public void Dispense(int amount)
        {
            var notes = Idispense.Dispense(amount);
			Console.WriteLine("Currency Count ->");
			foreach (var note in notes)
			{
				Console.WriteLine($"{note.Key} : {note.Value}");
			}
			Console.WriteLine();
		}
    }
}
