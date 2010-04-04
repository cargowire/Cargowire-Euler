using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Euler.Common;

namespace Euler.Problems
{
    public class Problem6 : IntEulerItem
    {
        private const int CONFIRMED_ANSWER = 25164150;
        public override int ConfirmedAnswer
        {
            get { return CONFIRMED_ANSWER; }
        }
        public override string Problem {
            get
            {
                return @"The sum of the squares of the first ten natural numbers is,
1^2 + 2^2 + ... + 10^2 = 385

The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)^2 = 55^2 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025  385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";
            }
        }
        
        public override int Calculate()
        {
            int num = -1;
            int sumOfSquares = 0;
            int squareOfSums = 0;
            for (int i = 1; i < 101; i++)
            {
                sumOfSquares += (i * i);
                squareOfSums += i;
            }
            squareOfSums *= squareOfSums;

            return System.Math.Abs(sumOfSquares - squareOfSums);
        }
    }
}
