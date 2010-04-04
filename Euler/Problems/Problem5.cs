using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Euler.Common;

namespace Euler.Problems
{
    public class Problem5 : IntEulerItem
    {
        private const int CONFIRMED_ANSWER = 232792560;
        public override int ConfirmedAnswer
        {
            get { return CONFIRMED_ANSWER; }
        }
        public override string Problem {
            get
            {
                return @"2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest number that is evenly divisible by all of the numbers from 1 to 20?";
            }
        }
        
        public override int Calculate()
        {
            int num = 0;
            // If divisible by 20 then divisible by 10,5,2
            bool found = false;
            while(!found){
                num += 20;
                for (int div = 2; div < 21; div++)
                {
                    if(num % div != 0)
                        break;
                    else if(div == 20)
                        found = true;
                }
            }
            
            return num;
        }

        public override string ShowWorkings(bool debug)
        {
            if (string.IsNullOrEmpty(_workings))
            {
                int num = 0, count = 0;
                // If divisible by 20 then divisible by 10,5,2
                bool found = false;
                while (!found)
                {
                    num += 20;
                    for (int div = 2; div < 21; div++)
                    {
                        count++;
                        if (num % div != 0)
                            break;
                        else if (div == 20)
                            found = true;
                    }
                }
                _workings = _debugWorkings = string.Format("{0} ({1} iterations)", num, count);
            }
            return _workings;
        }
    }
}
