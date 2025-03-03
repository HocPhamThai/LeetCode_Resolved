using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HashMapAndSet
{
    public static class ContainsDuplicate
    {
        public static bool ContainsDuplicate_Resolve_1(int[] nums) // Time O(n^2), Space O(1)
        {
            // [1, 2, 3, 1] => true
            // [1, 2, 3, 4] => false
            // [1, 1, 1, 3, 3, 2, 4, 3] => true
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool ContainsDuplicate_Resolve_2(int[] nums) // Time O(nlogn), Space O(n)
        {
            int[] numsCopy = new int[nums.Length];
            Array.Copy(nums, numsCopy, nums.Length);
            Array.Sort(numsCopy);
            for (int i = 1; i < numsCopy.Length; i++)
            {
                if (numsCopy[i] == numsCopy[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsDuplicate_Resolve_3(int[] nums) // Time O(n), Space O(n)
        {
            HashSet<int> hashSetNumber = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!hashSetNumber.Contains(num))
                {
                    hashSetNumber.Add(num);
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
