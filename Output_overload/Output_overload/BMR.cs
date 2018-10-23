using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_overload
{
    static class BMR //6. Declare a class to be static.
    {

        public static void CaloricCount(string gender, double weight, double height, int age, int actFact, out double calC)//4. Create a method with output parameters.
        {
            calC = 0;
            double BMR = 0;
            if (gender == "f") 
            {
                BMR = 655 + (4.35 * weight) + (4.7 * height) - (4.7 * age);
            }
            else if (gender == "m") 
            {
                BMR = 66 + (6.23 * weight) + (12.7 * height) - (6.8 * age);
            }

            if (actFact == 1)
            {
                calC = BMR * 1.2;
            }
            else if (actFact == 2)
            {
                calC = BMR * 1.375;
            }
            else if (actFact == 3)
            {
                calC = BMR * 1.55;
            }
            else if (actFact == 4)
            {
                calC = BMR * 1.725;
            }
            else if (actFact == 5)
            {
                calC = BMR * 1.9;
            }

        }
    }
}
