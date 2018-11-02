using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = -2147483648;
            int z = Solution.Reverse(y);
            Console.WriteLine(z);
            Console.Read();
        }
    }
}
