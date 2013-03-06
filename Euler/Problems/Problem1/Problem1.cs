using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Problem1 : IntEulerItem
    {
        private const int CONFIRMED_ANSWER = 233168;
        public override int ConfirmedAnswer
        {
            get { return CONFIRMED_ANSWER; }
        }
        public override string Problem 
        {
            get
            {
                return @"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.";
            }
        }

        public Problem1() :
            this(new Solution1())
        {
        }

        public Problem1(IProblemSolver<Problem1, int> solver)
            : base((IProblemSolver<IEulerItem<string, int>, int>)solver)
        {
        }
    }
}
