namespace Array
{
    public class MergeSortedArray
    {
        // Time O(alog(a)) with a = m + n, Space O(1)
        public static int[] MergeSortedArray_Solve_1(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
            {
                return nums1;
            }
            if (m == 0)
            {
                return nums2;
            }
            int j = 0;
            for (int i = m; i < nums1.Length; i++)
            {
                if (j < n)
                {
                    nums1[i] = nums2[j++];
                }
            }

            nums1 = Bubble_Sort(nums1);
            return nums1;
        }

        public static int[] Bubble_Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        public static int[] MergeSortedArray_Solve_2(int[] nums1, int m, int[] nums2, int n)
        {
            // [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3 => [1,2,2,3,5,6]
            if (n == 0)
            {
                return nums1;
            }
            if (m == 0)
            {
                return nums2;
            }
            int[] temp = new int[m + n];

            int i = 0;
            int j = 0;
            int k = 0;
            while (k < nums1.Length)
            {
                if (i < m && nums1[i] < nums2[j])
                {
                    temp[k++] = nums1[i++];
                }
                else
                {
                    if (j < n)
                        temp[k++] = nums2[j++];
                }
            }
            return temp;
        }

        public static int[] MergeSortedArray_Solve_3(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }
            return nums1;
        }
    }
}
