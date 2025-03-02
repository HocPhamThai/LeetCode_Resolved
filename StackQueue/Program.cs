
namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestValidParenthese();
        }

        private static void TestValidParenthese()
        {
            //string s = "{}";
            //string s = "()[]{}";
            //string s = "(]";
            string s = "([])";
            Console.WriteLine(ValidParenthese.IsValid(s));
        }

    }
}
