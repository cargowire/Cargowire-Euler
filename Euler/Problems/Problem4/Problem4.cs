using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Problem4 : IntEulerItem
    {
        private const int BASE_N = 101; // 100 times anything will never be a palindrome
        private const int LIMIT = 1000;

        private const int CONFIRMED_ANSWER = 906609;
        public override int ConfirmedAnswer
        {
            get { return CONFIRMED_ANSWER; }
        }
        public override string Problem {
            get
            {
                return @"A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91  99.

Find the largest palindrome made from the product of two 3-digit numbers.";
            }
        }
        
        public Problem4() :
            this(new Solution4())
        {
        }

        public Problem4(IProblemSolver<Problem4, int> solver)
            : base((IProblemSolver<IEulerItem<string, int>, int>)solver)
        {
        }
    }
}
