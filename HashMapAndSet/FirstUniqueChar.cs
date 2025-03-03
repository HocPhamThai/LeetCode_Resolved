using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapAndSet
{
    public static class FirstUniqueChar
    {
        public static int FirstUniqChar_Resolve_1(string s) // Time O(n^2), Space O(1)
        {
            // leetcode => 0
            // loveleetcode => 2
            // aabb => -1
            for (int i = 0; i < s.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j] && isUnique && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FirstUniqChar_Resolve_2(string s)
        {
            // leetcode => 0
            // loveleetcode => 2
            // aabb => -1
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                charCount[c] = charCount.GetValueOrDefault(c) + 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int FirstUniqChar_Resolve_3(string s)
        {
            // leetcode => 0
            // loveleetcode => 2
            // aabb => -1
            int[] alphabets = new int[26];

            foreach (var c in s)
            {
                alphabets[c - 'a']++;
            }


            for (int i = 0; i < s.Length; i++)
            {
                if (alphabets[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }

}
