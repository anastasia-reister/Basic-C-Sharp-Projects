using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1234321;
            bool isPalindrome = Solution.IsPalindrome(x);
            Console.WriteLine(isPalindrome);
            Console.Read();
        }
    }
}