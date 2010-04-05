using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        /// <summary></summary>
        /// <returns></returns>
        public override long Calculate()
        {
            long num = 7;
            long sum = 10;
            long test = 2000000;
            /* We know: After 5 A prime number must be an odd number ending in 1,3,7,9 */
            IList<long> primes = new List<long>(new long[] { 2, 3, 5 });

            while (num < test)
            {
                string snum = num.ToString();
                short lastdigit = short.Parse(snum.Substring(snum.Length - 1));
                // Rule out def nots (saves on unnecessary division to check for even/odd too
                if ((lastdigit == 1 || lastdigit == 3 || lastdigit == 7 || lastdigit == 9))
                {
                    bool isPrime = true;
                    // check all current primes, if none then must also be prime (all composite
                    // numbers have prime factors
                    foreach (int prime in primes)
                    {
                        if (prime * prime > test)
                            break;
                        if (num % prime == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        primes.Add(num);
                        sum += num;
                    }
                }
                num += 2;
            }
            return sum;
        }
    }
}