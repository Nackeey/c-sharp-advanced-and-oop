using System;
using System.Collections.Generic;

class StackFibonacci
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        var stackNum = new Stack<long>(new[] { 0, 1L });

        for (int i = 0; i < number - 1; i++)
        {
            long lastNum = stackNum.Pop();
            long beforeLastNum = stackNum.Peek();
            stackNum.Push(lastNum);
            stackNum.Push(lastNum + beforeLastNum);
        }
        Console.WriteLine(stackNum.Peek());
    }
}

