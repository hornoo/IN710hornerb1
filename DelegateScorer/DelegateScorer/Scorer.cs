using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateScorer
{
    public static class Scorer
    {
        public static int ChildScore(int correct, int incorrect)
        {
            int returnValue = (correct * 10) - incorrect;

            return returnValue;
        }


        public static int AdultScore(int correct, int incorrect)
        {
            int returnValue = correct * 15;

            return returnValue;
        }

    }
}
