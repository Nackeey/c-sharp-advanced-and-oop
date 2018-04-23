using System;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        var tuple1 = new Tuple<string, string, string>
                              ($"{input[0]} {input[1]}", input[2], input[3]);

        var input2 = Console.ReadLine().Split();
        var tuple2 = new Tuple<string, int, bool>
                              (input2[0], int.Parse(input2[1]), input2[2] == "drunk" ? true : false);

        var input3 = Console.ReadLine().Split();
        var tuple3 = new Tuple<string, double, string>
                              (input3[0], double.Parse(input3[1]), input3[2]);

        Console.WriteLine(tuple1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);

    }
}

