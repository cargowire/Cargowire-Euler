using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Problem7 : IntEulerItem
    {
        private const int CONFIRMED_ANSWER = 104743;
        public override int ConfirmedAnswer
        {
            get { return CONFIRMED_ANSWER; }
        }
        public override string Problem {
            get
            {
                return @"By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10001st prime number?";
            }
        }
        
        public Problem7() :
            this(new Solution7())
        {
        }

        public Problem7(IProblemSolver<Problem7, int> solver)
            : base((IProblemSolver<IEulerItem<string, int>, int>)solver)
        {
        }
    }
}