

namespace HashMapAndSet
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Contains Duplicate
            //TestContainDuplicate();
            TestFirstUniqueCharacter();
        }

        private static void TestFirstUniqueCharacter()
        {
            string s1 = "leetcode"; // => 0
            string s2 = "loveleetcode"; // => 2
            string s3 = "aabb"; // => -1

            var result = FirstUniqueChar.FirstUniqChar_Resolve_1(s1);
            Console.WriteLine(result);
            result = FirstUniqueChar.FirstUniqChar_Resolve_1(s2);
            Console.WriteLine(result);
            result = FirstUniqueChar.FirstUniqChar_Resolve_1(s3);
            Console.WriteLine(result);

            result = FirstUniqueChar.FirstUniqChar_Resolve_2(s1);
            Console.WriteLine(result);
            result = FirstUniqueChar.FirstUniqChar_Resolve_2(s2);
            Console.WriteLine(result);
            result = FirstUniqueChar.FirstUniqChar_Resolve_2(s3);
            Console.WriteLine(result);

            result = FirstUniqueChar.FirstUniqChar_Resolve_3(s1);
            Console.WriteLine(result);
            result = FirstUniqueChar.FirstUniqChar_Resolve_3(s2);
            Console.WriteLine(result);
            result = FirstUniqueChar.FirstUniqChar_Resolve_3(s3);
            Console.WriteLine(result);
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
