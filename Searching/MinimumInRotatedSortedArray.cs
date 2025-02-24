namespace Searching
{
    public static class MinimumInRotatedSortedArray
    {
        public static int MinimumInRotatedSortedArray_Resolve_1(int[] nums) // Time: O(nlog(n)), Space: O(1)
        {
            Array.Sort(nums);

            return nums[0];
        }

        public static int MinimumInRotatedSortedArray_Resolve_2(int[] nums) // Time: O(n), Space: O(1)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            return min;
        }

        public static int MinimumInRotatedSortedArray_Resolve_3(int[] nums) // Time: O(log(n)), Space: O(1)
        {
            int left = 0;

            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return nums[left];
        }
    }
}
