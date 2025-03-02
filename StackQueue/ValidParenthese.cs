using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public static class ValidParenthese // Time complexity: O(n), Space complexity: O(n)
    {
        public static bool IsValid(string str)
        {
            Stack<char> stackChar = new Stack<char>();

            foreach (char c in str)
            {
                if (c.Equals('(') || c.Equals('[') || c.Equals('{'))
                {
                    stackChar.Push(c);
                }
                else
                {
                    if (stackChar.Count == 0)
                    {
                        return false;
                    }

                    if (c == ')')
                    {
                        if (stackChar.Pop() != '(')
                        {
                            return false;
                        }
                    }
                    else if (c == ']')
                    {
                        if (stackChar.Pop() != '[')
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (stackChar.Pop() != '{')
                        {
                            return false;
                        }
                    }
                }
            }

            return stackChar.Count == 0;
        }
    }
}
