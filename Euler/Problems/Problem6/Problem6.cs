using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
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
        
        public Problem6() :
            this(new Solution6())
        {
        }

        public Problem6(IProblemSolver<Problem6, int> solver)
            : base((IProblemSolver<IEulerItem<string, int>, int>)solver)
        {
        }
    }
}
