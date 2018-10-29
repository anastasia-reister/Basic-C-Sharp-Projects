using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Enter a number of hours:");
            TimeSpan Xhours = TimeSpan.FromHours(Convert.ToDouble(Console.ReadLine()));
            DateTime inXHours = now + Xhours;
            Console.WriteLine(inXHours);
            Console.Read();
        }
    }
}
