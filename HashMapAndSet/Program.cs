
namespace HashMapAndSet
{
    public class Program
    {
        static void Main(string[] args)
        {


            // Contains Duplicate
            TestContainDuplicate();
        }

        private static void TestContainDuplicate()
        {
            int[] nums1 = [1, 2, 3, 1]; // => true
            int[] nums2 = [1, 2, 3, 4];// => false
            int[] nums3 = [1, 1, 1, 3, 3, 2, 4, 3]; // return true

            var result = ContainsDuplicate.ContainsDuplicate_Resolve_1(nums1);
            Console.WriteLine(result);
            result = ContainsDuplicate.ContainsDuplicate_Resolve_1(nums2);
            Console.WriteLine(result);
            result = ContainsDuplicate.ContainsDuplicate_Resolve_1(nums3);
            Console.WriteLine(result);

            result = ContainsDuplicate.ContainsDuplicate_Resolve_2(nums1);
            Console.WriteLine(result);
            result = ContainsDuplicate.ContainsDuplicate_Resolve_2(nums2);
            Console.WriteLine(result);
            result = ContainsDuplicate.ContainsDuplicate_Resolve_2(nums3);
            Console.WriteLine(result);

            result = ContainsDuplicate.ContainsDuplicate_Resolve_3(nums1);
            Console.WriteLine(result);
            result = ContainsDuplicate.ContainsDuplicate_Resolve_3(nums2);
            Console.WriteLine(result);
            result = ContainsDuplicate.ContainsDuplicate_Resolve_3(nums3);
            Console.WriteLine(result);
        }
    }
}
