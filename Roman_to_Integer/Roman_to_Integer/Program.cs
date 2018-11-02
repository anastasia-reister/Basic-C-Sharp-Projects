using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string romanNumber = "MCDXLVI";
            int result = Solution.RomanToInt(romanNumber);
            Console.WriteLine(result);
            Console.Read();

        }
    }
}
