namespace Searching
{
    public static class GuessNumberHighOrLower
    {
        public static int GuessNumber(int n, int pick)
        {
            int low = 1;
            int high = n;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int searchGuess = guess(mid);


                if (searchGuess == 0)
                {
                    return mid;
                }
                else if (searchGuess == -1)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            throw new InvalidOperationException();
        }

        private static int guess(int mid)
        {
            // API for problem here
            return -1;
        }
    }
}
