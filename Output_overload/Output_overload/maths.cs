using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_overload
{
     class maths // 1. Create a class. 
    {
        public  void divideByTwo (int num, out float divided) //In that class, create a void method that outputs an integer. 
        {
            divided = num / 2; // Have the method divide the data passed to it by 2.
        }

        public void divideByTwo(string word, out string half1, out string half2) //5. Overload a method. 
        {
            half1 = "";
            half2 = "";
            for (int i = 0; i < word.Length / 2; i++)
            {
                half1 = half1 + word[i];
            }
            for (int k = word.Length/2; k < word.Length; k++)
            {
                half2 = half2 + word[k];
            }
        }


    }
}
