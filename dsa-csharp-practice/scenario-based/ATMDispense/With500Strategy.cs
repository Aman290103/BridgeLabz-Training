using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.ATMDispense
{
    public class With500Strategy : IDispense

    {
        public Dictionary<int, int> Dispense(int amount)
        {
            int[] notes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            Dictionary<int,int> result = new Dictionary<int, int>();

            foreach (int note in notes) 
            {
                if (amount >= note)
                {
                    int count = amount / note;
                    result[note] = count;
                    amount %= note;

                }
            }
            return result;

        }

    }
}
