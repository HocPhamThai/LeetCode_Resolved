using Array;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestRunningSum();
            //TestReverseString();
            //TestMergeSortedArray();
            //TestRemoveDuplicate();
            TestThirdMaximumNumber();
        }

        private static void TestThirdMaximumNumber()
        {
            //int[] nums = [3, 2, 1]; // return 1
            int[] nums = [1, 2]; // return 2
            //int[] nums = [2, 2, 3, 1]; // return 1
            //int[] nums = { 8, 8, 4, 7, 6, 2, 7, 5 };

            //int result = ThirdMaximumNumber.ThirdMaximumNumber_Resolve_1(nums);
            //int result = ThirdMaximumNumber.ThirdMaximumNumber_Resolve_2(nums);
            int result = ThirdMaximumNumber.ThirdMaximumNumber_Resolve_3(nums);

            Console.WriteLine(result);
        }

        private static void TestRemoveDuplicate()
        {
            // TestCase 01
            //int[] nums = [1, 1, 2]; // => 2
            // TestCase 02
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]; // => 5

            int result = RemoveDuplicates.RemoveDuplicates_Solve(nums);

            Console.WriteLine(result);
        }

        static void TestRunningSum()
        {
            // RunningSum 
            // ex1: [1, 2, 3, 4] => [1, 3, 6, 10]
            int[] ints = { 1, 2, 3, 4 };
            ArrayHelper.PrintArray(ints);
            ints = RunningSum.RunningSum_Solve(ints);
            ArrayHelper.PrintArray(ints);
            // ex2: [1, 1, 1, 1, 1] => [1, 2, 3, 4, 5]
            int[] ints2 = { 1, 1, 1, 1, 1 };
            ArrayHelper.PrintArray(ints2);
            ints2 = RunningSum.RunningSum_Solve(ints2);
            ArrayHelper.PrintArray(ints2);
            // ex3: [3, 1, 2, 10, 1] => [3, 4, 6, 16, 17]
            int[] ints3 = { 3, 1, 2, 10, 1 };
            ArrayHelper.PrintArray(ints3);
            ints3 = RunningSum.RunningSum_Solve(ints3);
            ArrayHelper.PrintArray(ints3);
        }

        static void TestReverseString()
        {
            char[] testCase = { 'h', 'e', 'l', 'l', 'o' };

            ArrayHelper.PrintArray(testCase);
            //ReverseString.ReverseString_Solve_1(testCase);
            //ReverseString.ReverseString_Solve_2(testCase);
            ReverseString.ReverseString_Solve_3(testCase);
            ArrayHelper.PrintArray(testCase);
        }

        static void TestMergeSortedArray()
        {
            // testcase 01
            //int[] arr = [1, 2, 3, 0, 0, 0];
            //int[] arr2 = [2, 5, 6];
            // testcase 02
            int[] arr = [1];
            int[] arr2 = [];
            // testcase 03
            //int[] arr = [0];
            //int[] arr2 = [1];
            //arr = MergeSortedArray.MergeSortedArray_Solve_1(arr, 3, arr2, 3);
            //arr = MergeSortedArray.MergeSortedArray_Solve_1(arr, 1, arr2, 0);
            //arr = MergeSortedArray.MergeSortedArray_Solve_1(arr, 0, arr2, 1);
            //arr = MergeSortedArray.MergeSortedArray_Solve_2(arr, 3, arr2, 3);
            //arr = MergeSortedArray.MergeSortedArray_Solve_2(arr, 1, arr2, 0);
            //arr = MergeSortedArray.MergeSortedArray_Solve_2(arr, 0, arr2, 1);
            //arr = MergeSortedArray.MergeSortedArray_Solve_3(arr, 3, arr2, 3);
            arr = MergeSortedArray.MergeSortedArray_Solve_3(arr, 1, arr2, 0);
            //arr = MergeSortedArray.MergeSortedArray_Solve_3(arr, 0, arr2, 1);
            ArrayHelper.PrintArray(arr);
        }
    }
}
