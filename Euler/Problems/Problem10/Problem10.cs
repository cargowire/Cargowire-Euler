using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Problem10 : LongEulerItem
    {
        private const long CONFIRMED_ANSWER = 142913828922;
        public override long ConfirmedAnswer
        {
            get { return CONFIRMED_ANSWER; }
        }
        public override string Problem {
            get
            {
                return @"The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.";
            }
        }

        public Problem10() :
            this(new Solution10())
        {
        }

        public Problem10(IProblemSolver<Problem10, long> solver)
            : base((IProblemSolver<IEulerItem<string, long>, long>)solver)
        {
        }
    }
}