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
            Stack<string> myStack = new Stack<string>();
            string xString = x.ToString();
            for ( int i = 0; i<xString.Length; i++)
            {
                myStack.Push(xString[i].ToString());
            }

            StringBuilder reverse = new StringBuilder();
            do { reverse.Append(myStack.Pop()); }
            while (myStack.Count > 0); 
           

            if(xString == reverse.ToString())
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
