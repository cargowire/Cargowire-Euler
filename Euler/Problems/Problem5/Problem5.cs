using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
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
        
        public Problem5() :
            this(new Solution5())
        {
        }

        public Problem5(IProblemSolver<Problem5, int> solver)
            : base((IProblemSolver<IEulerItem<string, int>, int>)solver)
        {
        }
    }
}
