using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.ATMDispense
{
    internal class FallBackDispense : IDispense
    {
        public Dictionary<int, int> Dispense(int amount)
        {
            int[] notes = { 100, 50, 20, 10 };
            Dictionary<int, int> result = new Dictionary<int, int>();

            foreach (int note in notes)
            {
                if (amount >= note)
                {
                    int count = amount / note;
                    result[note] = count;
                    amount %= note;
                }
            }
            if (amount > 0)
            {
				Console.WriteLine("Exact change not possible. Fallback applied.");
			}
            return result;
        }

    }
}
