namespace Array
{
    public static class ReverseString
    {
        public static void ReverseString_Solve_1(char[] s) // Time: O(n/2), Space: O(1)
        {
            int l = 0;
            int r = s.Length - 1;

            char temp;
            while (l < r)
            {
                temp = s[l];
                s[l++] = s[r];
                s[r--] = temp;
            }
        }

        public static void ReverseString_Solve_2(char[] s) // Time O(apprx n/2), Space: O(n/2)
        {
            Reverse(s, 0, s.Length - 1);
        }

        public static void Reverse(char[] c, int l, int r)
        {
            if (l >= r)
            {
                return;
            }

            char temp = c[l];
            c[l] = c[r];
            c[l] = temp;

            Reverse(c, l + 1, r - 1);
        }

        public static void ReverseString_Solve_3(char[] s) // Time O(2n), Space: O(n)
        {
            Stack<char> chars = new Stack<char>();

            foreach (char c in s)
            {
                chars.Push(c);
            }

            int i = 0;
            while (chars.Count > 0)
            {
                s[i++] = chars.Pop();
            }
        }
    }
}
