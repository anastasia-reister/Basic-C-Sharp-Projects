using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Solution
    {
        public static bool IsPalindrome(int x)
        {

            Int64 initNum = x;
            Stack<Int64> newStack = new Stack<Int64>();
            do
            {
                newStack.Push(x % 10);
                x /= 10;
            } while (x > 0);

            int count = newStack.Count();
            Stack<Int64> revertedStack = new Stack<Int64>();
            for (int k = 0; k < count; k++)
            {
                revertedStack.Push(newStack.Pop());
            }

            Int64 num = 0;
            for (int i = revertedStack.Count; i > 0; i--)
            {

                num += (revertedStack.Pop() * Convert.ToInt64(Math.Pow(10, i))) / 10;
            }



            if (initNum == num && initNum >= 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
