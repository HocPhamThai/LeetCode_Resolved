namespace Array
{
    public static class ArrayHelper
    {
        public static void PrintArray<T>(T[] arr)
        {
            Console.Write('[');
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1)
                    Console.Write(arr[i] + ", ");
                else
                {
                    Console.Write(arr[i]);
                }
            }
            Console.Write(']');
            Console.WriteLine();
        }
    }
}
