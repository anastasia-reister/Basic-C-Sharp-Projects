using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    public class Solution
    {
        public static int RomanToInt(string Roman)
        {
            Hashtable romans = new Hashtable();
            romans.Add("I", 1);
            romans.Add("V", 5);
            romans.Add("X", 10);
            romans.Add("L", 50);
            romans.Add("C", 100);
            romans.Add("D", 500);
            romans.Add("M", 1000);


            List<string> romanNumList = new List<string>();
            for ( int i = 0; i < Roman.Length; i++)
            {
                romanNumList.Add(Roman[i].ToString());
            }

            int result = 0;

            for(int i = 0; i<romanNumList.Count; i++)
            {
                if(i == 0)
                {
                    result += Convert.ToInt32(romans[romanNumList[i]]);
                }
                else if(Convert.ToInt32(romans[romanNumList[i-1]]) < Convert.ToInt32(romans[romanNumList[i]]))
                {
                    result = result - Convert.ToInt32(romans[romanNumList[i - 1]]) * 2 + Convert.ToInt32(romans[romanNumList[i]]);
                }
                else
                {
                    result += Convert.ToInt32(romans[romanNumList[i]]);
                }
            }
          

            return result;
        }
        
        
      
    }
}
