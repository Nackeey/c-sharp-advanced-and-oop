using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            var maximumElements = new Stack<int>();
            var maxValue = 0; 

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                switch (nums[0])
                {
                    case 1:

                        stack.Push(nums[1]);
                        if (maxValue < nums[1])
                        {
                            maxValue = nums[1];
                            maximumElements.Push(maxValue);
                        }
                        break;

                    case 2:

                        if (stack.Pop() == maxValue)
                        {
                            maximumElements.Pop();
                            if (maximumElements.Count() > 0)
                            {
                                maxValue = maximumElements.Peek();
                            }
                            else
                            {
                                maxValue = 0;
                            }
                        }
                        break;

                    case 3:

                        Console.WriteLine(maxValue);
                        break;
                }
            }
        }
    }
}
