namespace Array
{
    public static class RemoveDuplicates
    {
        public static int RemoveDuplicates_Solve(int[] nums)
        {
            int n = nums.Length;
            if (n == 0 || n == 1)
            {
                return n;
            }

            int i = 1;
            int j = 1;
            while (j < n)
            {
                if (nums[j] != nums[j - 1])
                {
                    nums[i++] = nums[j];
                    j++;
                }
                j++;
            }
            return i;
        }
    }
}
