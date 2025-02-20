namespace Searching
{
    public static class BinarySearch
    {
        public static int BinarySearch_Resolve(int[] nums, int target) // Time: O(log(n)); Space: O(1)
        {
            int left = 0;
            int right = nums.Length;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
