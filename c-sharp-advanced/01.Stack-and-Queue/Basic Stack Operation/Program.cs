using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (nsx.Length < 3)
            {
                return;
            }

            int n = nsx[0];
            //representing the amount of elements to push onto the stack
            int s = nsx[1];
            //the amount of elements to Pop() from the stack
            int x = nsx[2];
            //an element that you should check whether is present in the stack

            if (s > n)
            {
                return;
            }
            
            int[] arr = Console.ReadLine()
                .Trim()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(arr);

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
