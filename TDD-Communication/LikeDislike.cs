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

            //if (input.Count() % 2 == 0) { return Outcome.NEUTRAL; } // this is the default return so it can be removed.

            if (input.Count() % 2 == 1) { return input[^1]; }

            return Outcome.NEUTRAL;
        }
    }
}
// 1 like 1 disline -> neutral 