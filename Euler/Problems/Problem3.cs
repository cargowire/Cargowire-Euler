using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Problem3 : LongEulerItem
    {
        private const long CONFIRMED_ANSWER = 6857;
        public override long ConfirmedAnswer
        {
            get { return CONFIRMED_ANSWER; }
        }
        public override string Problem {
            get
            {
                return @"The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?";
            }
        }

        public override long Calculate()
        {
            long item = 600851475143;
            // Do not check higher than sqrt as we will find the smaller half of the factor for prime testing
            long check = (long)System.Math.Round(System.Math.Sqrt(item), 0, MidpointRounding.AwayFromZero);
            if (check % 2 == 0) check -= 1; // Can't be prime if its even
            while (check > 0) // Start from highest numbers as we want largest
            {
                // Check if factor, before prime - to avoid loop
                if(item % check == 0){
                    if (Math.IsPrime((int)check))
                        return check;
                }
                check -= 2; // jump in 2 steps to avoid even numbers
                if(check % 5 == 0) check -= 2; // avoid 5 divisible items as they are not prime
            }
            return item; // If none found then the item itself must be prime?
        }
    }
}
