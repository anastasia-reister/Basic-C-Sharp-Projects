using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Practice
{
    public class someMath
    {
        public static float threeQuarters (int num)
        {
            float result = num * 3 / 4;
            return result;
        }

        public static int percent150 (int num)
        {
            int result = num * 150 / 100;
            return result;
        }

        public static int inQuarters (int dollars)
        {
            int quantity = Convert.ToInt32(dollars * 4);
            return quantity;
        }
    }
}
