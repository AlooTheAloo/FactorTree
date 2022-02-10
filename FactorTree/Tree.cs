using System;
using System.Linq;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
namespace codewarslmaoo
{
    static class Tree
    {
        private static ArrayList nums = new ArrayList();
        private static String retVal = "";
        public static string Factors(BigInteger num)
        {
            retVal = num.ToString() + "\n";
            Nums(num);
            return retVal;
        }

        private static void Nums(BigInteger num)
        {
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    nums.Add(i);
                    for (int j = 0; j < nums.Count; j++)
                        retVal += (nums[j] + " ");
                    retVal += num / i;
                    retVal += "\n";
                    Nums(num / i);
                    break;
                }
            }

        }

    }
}
