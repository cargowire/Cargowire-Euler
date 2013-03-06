using System;

using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Solution3 : BaseProblemSolver<Problem3, long>
    {
        public override long Calculate()
        {
            long item = 600851475143;
            // Do not check higher than sqrt as we will find the smaller half of the factor for prime testing
            long check = (long)System.Math.Round(System.Math.Sqrt(item), 0, MidpointRounding.AwayFromZero);
            if (check % 2 == 0) check -= 1; // Can't be prime if its even
            while (check > 0) // Start from highest numbers as we want largest
            {
                // Check if factor, before prime - to avoid loop
                if (item % check == 0)
                {
                    if (Math.IsPrime((int)check))
                        return check;
                }
                check -= 2; // jump in 2 steps to avoid even numbers
                if (check % 5 == 0) check -= 2; // avoid 5 divisible items as they are not prime
            }
            return item; // If none found then the item itself must be prime?
        }
    }
}
