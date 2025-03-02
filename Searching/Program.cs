

namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestBinarySearch();
            TestValidPerfectSquare();
            //TestMinimumInRotatedSortedArray();
        }

        private static void TestMinimumInRotatedSortedArray()
        {
            int[] nums1 = { 3, 4, 5, 1, 2 };
            int[] nums2 = { 4, 5, 6, 7, 0, 1, 2 };
            int[] nums3 = { 11, 13, 15, 17 };

            //Console.WriteLine(MinimumInRotatedSortedArray.MinimumInRotatedSortedArray_Resolve_1(nums1));
            //Console.WriteLine(MinimumInRotatedSortedArray.MinimumInRotatedSortedArray_Resolve_1(nums2));
            //Console.WriteLine(MinimumInRotatedSortedArray.MinimumInRotatedSortedArray_Resolve_1(nums3));

            Console.WriteLine(MinimumInRotatedSortedArray.MinimumInRotatedSortedArray_Resolve_2(nums1));
            Console.WriteLine(MinimumInRotatedSortedArray.MinimumInRotatedSortedArray_Resolve_2(nums2));
            Console.WriteLine(MinimumInRotatedSortedArray.MinimumInRotatedSortedArray_Resolve_2(nums3));

            Console.WriteLine(MinimumInRotatedSortedArray.MinimumInRotatedSortedArray_Resolve_3(nums1));
            Console.WriteLine(MinimumInRotatedSortedArray.MinimumInRotatedSortedArray_Resolve_3(nums2));
            Console.WriteLine(MinimumInRotatedSortedArray.MinimumInRotatedSortedArray_Resolve_3(nums3));
        }

        private static void TestValidPerfectSquare()
        {
            //int num = 16; // return true
            int num = 14; // return false
            //Console.WriteLine(ValidPerfectSquare.ValidPerfectSquare_Resolve_1(num));
            Console.WriteLine(ValidPerfectSquare.ValidPerfectSquare_Resolve_2(num));
        }

        public static void TestBinarySearch()
        {
            int[] nums = [-1, 0, 3, 5, 9, 12];

            Console.WriteLine(BinarySearch.BinarySearch_Resolve(nums, 9));
        }
    }
}
