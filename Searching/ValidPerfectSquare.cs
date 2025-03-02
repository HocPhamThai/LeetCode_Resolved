namespace Searching
{
    public static class ValidPerfectSquare
    {
        public static bool ValidPerfectSquare_Resolve_1(int num) // Time: O(sqrt(n)), Space(1)
        {
            long i = 1;

            while (i * i <= num)
            {
                if (i * i == num)
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        public static bool ValidPerfectSquare_Resolve_2(int num) // Time: O(log(sqrt(n)), Space(1)
        {
            int left = 1;
            int right = num;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int square = mid * mid;
                if (square == num)
                {
                    return true;
                }
                else if (square < num)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }
    }
}
