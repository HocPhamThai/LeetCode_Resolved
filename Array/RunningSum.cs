namespace Array
{
    public static class RunningSum
    {
        public static int[] RunningSum_Solve(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i] + arr[i - 1];
            }
            return arr;
        }
    }
}
