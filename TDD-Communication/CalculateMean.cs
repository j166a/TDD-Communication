using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Communication
{
    public class CalculateMean
    {
        public static double CalculateTheMean(double[] input)
        {
            if (input.Length == 0)
            {
                return 0;
            }

            double output = (double)(input.Sum() / input.Length);

            return output;
        }
    }
}
