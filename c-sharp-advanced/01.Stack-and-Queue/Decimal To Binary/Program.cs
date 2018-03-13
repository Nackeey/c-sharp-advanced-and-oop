using System;
using System.Collections.Generic;

namespace Decimal_To_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> st = new Stack<int>();

            if (num == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (num != 0)
                {
                    
                    st.Push(num % 2);
                    num /= 2;
                }

                while (st.Count > 0)
                {
                    Console.Write(st.Pop());
                }
            }
        }
    }
}
