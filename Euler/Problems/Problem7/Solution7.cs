using System.Collections.Generic;

using Cargowire.Euler.Common;

namespace Cargowire.Euler.Problems
{
    public class Solution7 : BaseProblemSolver<Problem7, int>
    {
        public override int Calculate()
        {
            const int desiredPrimeNumberPostion = 10001;
            int num = 5;
            /* We know: After 5 A prime number must be an odd number ending in 1,3,7,9 */
            int primeCount = 3;
            IList<int> primes = new List<int>(new int[] { 2, 3, 5 });

            while (primeCount < desiredPrimeNumberPostion)
            {
                num++;
                string snum = num.ToString();
                short lastdigit = short.Parse(snum.Substring(snum.Length - 1));
                // Rule out def nots (saves on unnecessary division to check for even/odd too
                if ((lastdigit == 1 || lastdigit == 3 || lastdigit == 7 || lastdigit == 9))
                {
                    bool isPrime = true;
                    // check all current primes, if none then must also be prime (all composite
                    // numbers have prime factors
                    foreach (int prime in primes)
                        if (num % prime == 0) isPrime = false;

                    if (isPrime)
                    {
                        primes.Add(num);
                        primeCount++;
                    }
                }
            }
            return num;
        }
    }
}
