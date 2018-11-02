using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[4] { 3, 8, 11, 6 };
            int target = 14;

            int[] result = new int[2];
            result = Solution.TwoSum(nums, target);


            Console.Read();
        }
    }
}
