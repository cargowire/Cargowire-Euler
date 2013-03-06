using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Solution6 : BaseProblemSolver<Problem6, int>
    {
        public override int Calculate()
        {
            int sumOfSquares = 0;
            int squareOfSums = 0;
            for (int i = 1; i < 101; i++)
            {
                sumOfSquares += (i * i);
                squareOfSums += i;
            }
            squareOfSums *= squareOfSums;

            return System.Math.Abs(sumOfSquares - squareOfSums);
        }
    }
}
