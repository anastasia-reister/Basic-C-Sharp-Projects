using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    class Solution
    {
        public static  int Reverse(int x)
        {
            try
            {
                StringBuilder result = new StringBuilder(50);
                if (x >= 0)
                {
                    string xString = x.ToString();
                    for (int i = xString.Length - 1; i >= 0; i--)
                    {
                        result.Append(xString[i]);
                    }
                    return Convert.ToInt32(result.ToString());

                }
                else
                {
                    string xString = x.ToString();
                    for (int i = xString.Length - 1; i > 0; i--)
                    {
                        result.Append(xString[i]);
                    }

                    int resultInt = 0 - Convert.ToInt32(result.ToString());
                    return resultInt;
                }
            }
            catch (OverflowException) { return 0; }
            
        }
    }
}
