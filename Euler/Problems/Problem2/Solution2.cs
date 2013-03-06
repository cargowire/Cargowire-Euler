using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Solution2 : BaseProblemSolver<Problem2, int>
    {
        public override int Calculate()
        {
            int ret = 0;
            int start = 1;
            int end = 2;
            while (end < 4000000)
            {
                // 1 isn't even so don't include that and don't do start as it repeats
                if (end % 2 == 0) ret += end;
                int tmp = end;
                end = start + end;
                start = tmp;
            }
            return ret;
        }
    }
}
