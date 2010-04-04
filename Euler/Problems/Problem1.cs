using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Euler.Common;

namespace Euler.Problems
{
    public class Problem1 : IntEulerItem
    {
        private const int CONFIRMED_ANSWER = 233168;
        public override int ConfirmedAnswer
        {
            get { return CONFIRMED_ANSWER; }
        }
        public override string Problem {
            get
            {
                return @"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.";
            }
        }
        
        public override int Calculate()
        {
            int ret = 0;
            for (int i = 3; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                    ret += i;
            }
            return ret;
        }
    }
}
