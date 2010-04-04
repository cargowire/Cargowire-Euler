using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        
        public override int Calculate()
        {
            int ret = 0;
            int first = 1, second = 1;
            int lastAnswer = 0;
            for (int i = BASE_N; i < LIMIT; i++)
            {
                for (int j = i; j < LIMIT; j++)
                {
                    int answer = i * j;
                    if ((Math.IsPalindrome(answer)) && (answer > lastAnswer))
                    {
                        //Console.Write(answer + ",");
                        first = i;
                        second = j;
                        ret = answer;
                        lastAnswer = answer;
                    }
                }
            }
            return ret;
        }

        public override string ShowWorkings(bool debug)
        {
            if ((!debug && string.IsNullOrEmpty(_workings))||
                (debug && string.IsNullOrEmpty(_debugWorkings)))
            {
                double ret = 0;
                int first = 1, second = 1;
                int count = 0;
                int lastAnswer = 0;
                for (int i = BASE_N; i < LIMIT; i++)
                {
                    for (int j = i; j < LIMIT; j++)
                    {
                        count++;
                        if (debug)
                        {
                            if(debug)_debugWorkings += ("(i:" + i);
                            if (debug) _debugWorkings += ("j:" + j + "),");
                        }
                        int answer = i * j;
                        if ((Math.IsPalindrome(answer)) && (answer > lastAnswer))
                        {
                            if (debug) _debugWorkings += answer + ",";
                            first = i;
                            second = j;
                            ret = answer;
                            lastAnswer = answer;
                        }
                        if (debug) Console.Write(_debugWorkings);
                    }
                }
                _workings = string.Format("{0}x{1} = {2} ({3} iterations)", first, second, ret, count);
                if (debug) _debugWorkings += string.Format("{0}{1}", Environment.NewLine, _workings);
            }
            return (debug) ? _debugWorkings:_workings;
        }
    }
}
