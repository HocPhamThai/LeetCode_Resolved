
namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestBinarySearch();
            TestValidPerfectSquare();
        }

        private static void TestValidPerfectSquare()
        {
            int num = 16; // return true
            //int num = 14; // return false
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
