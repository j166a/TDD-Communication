using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Communication
{
    public class LikeDislike
    {
        public static Outcome LikeDislikeNeutral(List<Outcome> input)
        {

            if (input.Count() == 1) { return input[0]; }

            if (input.Count() == 2) { return Outcome.NEUTRAL; }

            return 0;
        }
    }
}
// 1 like 1 disline -> neutral 