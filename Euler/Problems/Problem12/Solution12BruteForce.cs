using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    /// <remarks>Brute force approach took 4314.3707679 seconds</remarks>
    public class Solution12BruteForce : BaseProblemSolver<Problem12, long>
    {
        public override long Calculate()
        {
            long currentNumber = 1;
            long currentTriangleNumber = 1;

            while (CalculateFactorsForNumber(currentTriangleNumber) <= 500)
            {
                currentNumber++;
                currentTriangleNumber += currentNumber;
            }

            return currentTriangleNumber;
        }

        public long CalculateFactorsForNumber(long number)
        {
            long noOfFactors = 0;
            long divisor = 1;
            while (divisor <= number)
            {
                if (number % divisor == 0)
                {
                    noOfFactors++;
                }
                divisor++;
            }
            return noOfFactors;
        }
    }
}
