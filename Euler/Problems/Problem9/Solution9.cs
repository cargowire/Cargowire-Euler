using System.Collections.Generic;

using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Solution9 : BaseProblemSolver<Problem9, int>
    {
        /// <summary>
        /// a^2 + b^2 = c^2
        /// a + b + c = 1000
        /// a,b,c less than 1000
        /// Sqrt of 1000 is approx 31
        /// 
        /// </summary>
        public override int Calculate()
        {
            IDictionary<int, int> squares = new Dictionary<int, int>();
            for (int i = 1; i < 1001; i++)
            {
                squares.Add(i, i * i);
            }
            IList<int[]> pythag = new List<int[]>();
            int foundPythag = 0;
            foreach (KeyValuePair<int, int> checkA in squares)
            {
                foreach (KeyValuePair<int, int> checkB in squares)
                {
                    foreach (KeyValuePair<int, int> checkC in squares)
                    {
                        if (checkA.Value + checkB.Value == checkC.Value)
                        {
                            pythag.Add(new int[] { checkA.Key, checkB.Key, checkC.Key });
                            if (checkA.Key + checkB.Key + checkC.Key == 1000)
                            {
                                foundPythag = pythag.Count - 1;
                            }
                        }
                    }
                }
            }
            _debugWorkings = _workings = string.Format("{0} + {1} + {2}", pythag[foundPythag][0], pythag[foundPythag][1], pythag[foundPythag][2]);
            return pythag[foundPythag][0] * pythag[foundPythag][1] * pythag[foundPythag][2];
        }
    }
}
