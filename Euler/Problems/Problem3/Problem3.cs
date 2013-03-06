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

        public Problem3() :
            this(new Solution3())
        {
        }

        public Problem3(IProblemSolver<Problem3, long> solver)
            : base((IProblemSolver<IEulerItem<string, long>, long>)solver)
        {
        }
    }
}
