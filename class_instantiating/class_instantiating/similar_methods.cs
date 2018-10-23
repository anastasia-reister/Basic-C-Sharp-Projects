using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_instantiating
{
    class similar_methods
    {
        public int one_method( int num)
        {
            int result = num + 5;
            return result;
        }

        public int one_method(decimal num)
        {
            int result = Convert.ToInt32(num) + 10;
            return result;
        }

        public int one_method(string num)
        {
            int result = Convert.ToInt32(num) + 20;
            return result;
        }
    }
}
