using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string parenthesesLine = Console.ReadLine();

        var openedParentheses = new Stack<char>();
        var openCases = new char[] { '{', '[', '(' };

        for (int i = 0; i < parenthesesLine.Length; i++)
        {
            if (openCases.Contains(parenthesesLine[i]))
            {
                openedParentheses.Push(parenthesesLine[i]);
            }
            else
            {
                if (openedParentheses.Count == 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                switch (parenthesesLine[i])
                {
                    case '}':
                        if (openedParentheses.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;

                    case ']':
                        if (openedParentheses.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;

                    case ')':
                        if (openedParentheses.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }
        }
        Console.WriteLine("YES");
    }
}

