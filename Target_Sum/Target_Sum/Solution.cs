using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Sum
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            int [] indicesOfTarget = new int[2] { i, j };
            //            return indicesOfTarget;
            //        }

            //    }
            //}


            Hashtable table = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                table.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (table.ContainsKey(complement) && Convert.ToInt32(table[complement]) != i)
                {
                    return new int[] { i, Convert.ToInt32(table[complement]) };
                }
            }
            return null;



        }
    }
}
