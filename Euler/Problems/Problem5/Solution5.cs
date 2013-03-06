using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Solution5 : BaseProblemSolver<Problem5, int>
    {
        public override int Calculate()
        {
            int num = 0;
            // If divisible by 20 then divisible by 10,5,2
            bool found = false;
            while (!found)
            {
                num += 20;
                for (int div = 2; div < 21; div++)
                {
                    if (num % div != 0)
                        break;
                    else if (div == 20)
                        found = true;
                }
            }

            return num;
        }

        public override string ShowWorkings(bool debug)
        {
            if (string.IsNullOrEmpty(_workings))
            {
                int num = 0, count = 0;
                // If divisible by 20 then divisible by 10,5,2
                bool found = false;
                while (!found)
                {
                    num += 20;
                    for (int div = 2; div < 21; div++)
                    {
                        count++;
                        if (num % div != 0)
                            break;
                        else if (div == 20)
                            found = true;
                    }
                }
                _workings = _debugWorkings = string.Format("{0} ({1} iterations)", num, count);
            }
            return _workings;
        }
    }
}
