using System;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        var tuple1 = new Tuple<string, string>($"{input[0]} {input[1]}", input[2]);

        var input2 = Console.ReadLine().Split();
        var tuple2 = new Tuple<string, int>(input2[0], int.Parse(input2[1]));

        var input3 = Console.ReadLine().Split();
        var tuple3 = new Tuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));

        Console.WriteLine(tuple1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);

    }
}

