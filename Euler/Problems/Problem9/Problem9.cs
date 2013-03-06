using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Problem9 : IntEulerItem
    {
        private const int CONFIRMED_ANSWER = 31875000;
        public override int ConfirmedAnswer
        {
            get { return CONFIRMED_ANSWER; }
        }
        public override string Problem {
            get
            {
                return @"A Pythagorean triplet is a set of three natural numbers, a  b  c, for which,
a^2 + b^2 = c^2

For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.";
            }
        }

        public Problem9() :
            this(new Solution9())
        {
        }

        public Problem9(IProblemSolver<Problem9, int> solver)
            : base((IProblemSolver<IEulerItem<string, int>, int>)solver)
        {
        }
    }
}