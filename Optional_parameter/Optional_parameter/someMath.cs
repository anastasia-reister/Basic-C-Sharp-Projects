using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_parameter
{
    class someMath //1. Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return a integer result.
    {
        public int multiply(int first, int second = 5)
        {
            int result = first * 5 * second;
            return result;
        }
    }
}
