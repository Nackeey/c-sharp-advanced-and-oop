using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            Queue<string> que = new Queue<string>(input);

            while (que.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    string reminder = que.Dequeue();
                    que.Enqueue(reminder);
                }
                Console.WriteLine($"Removed {que.Dequeue()}");
            }
            Console.WriteLine($"Last is {que.Peek()}");
        }
    }
}
