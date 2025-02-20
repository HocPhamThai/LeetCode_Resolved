namespace Array
{
    public static class ThirdMaximumNumber
    {
        public static int ThirdMaximumNumber_Resolve_1(int[] nums) // Time: O(n); Space: O(n)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int[] sortedNums = nums.ToArray();
            Bubble_Sort(sortedNums); // Sort bản sao, nums không bị thay đổi  

            int first = sortedNums[0];
            int? second = null;
            int? third = null;
            int count = 1;

            foreach (var num in sortedNums)
            {
                if (num == first || num == second || num == third) continue;

                if (count == 1) second = num;
                else if (count == 2) third = num;
                else break;

                count++;
            }

            return third ?? first;
        }

        public static int[] Bubble_Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
            return arr;
        }

        public static int ThirdMaximumNumber_Resolve_2(int[] nums) // Time O(n); Space: O(1)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;

            foreach (int num in nums)
            {
                if (num > first)
                {
                    first = num;
                }
            }

            foreach (int num in nums)
            {
                if (num > second && num < first)
                {
                    second = num;
                }
            }

            foreach (int num in nums)
            {
                if (num > third && num < second)
                {
                    third = num;
                }
            }
            return third != int.MinValue ? third : first;
        }

        public static int ThirdMaximumNumber_Resolve_3(int[] nums) // Time: O(n), Space: O(1)
        {
            int? first = null;
            int? second = null;
            int? third = null;

            foreach (int num in nums)
            {
                if (num.Equals(first) || num.Equals(second) || num.Equals(third)) continue;

                if (num > first || first == null)
                {
                    third = second;
                    second = first;
                    first = num;
                }
                else if (num > second || second == null)
                {
                    third = second;
                    second = num;
                }
                else if (num > third || third == null)
                {
                    third = num;
                }
            }
            return third ?? first.Value;
        }
    }
}
