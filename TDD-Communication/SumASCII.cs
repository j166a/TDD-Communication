using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Communication
{
    public class SumASCII
    {
        public static int SumASCIICodes(string input)
        {
            if (input.Length == 1) { return (int)input[0]; }
            return 0;
        }
    }
}
