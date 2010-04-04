using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cargowire.Euler
{
    public static class Math
    {
        public static bool IsPrime(long check)
        {
            long div = 3;
            if (check > div)
                for (div = 3; (check % div != 0); div++) ;

            return (div == check);
        }
        public static bool IsPalindrome(long check)
        {
            char[] nums = check.ToString().ToCharArray();
            for (int k = 0; k <= nums.Length / 2; k++)
            {
                if (nums[k] != nums[nums.Length - k - 1])
                    return false;
            }
            return true;
        }
    }
}
