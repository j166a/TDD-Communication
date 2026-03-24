using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Communication
{
    public class Sums
    {
        public static int SumNumbers(int[] input)
        {
            if (input.Length == 0) return 0;
            Array.Sort(input);
            int output = 0;

            for (int i = 1; i < input.Length - 1; i++)
            {
                output += input[i];
            }
            return output;
        }
    }
}
