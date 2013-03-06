using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Solution1 : BaseProblemSolver<Problem1, int>
    {
        public override int Calculate()
        {
            int ret = 0;
            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    ret += i;
            }
            return ret;
        }
    }
}
