using System;

public class StartUp
{
    public static void Main()
    {
        try
        {
            string author = Console.ReadLine();
            string title = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());

            var book = new Book(title, author, price);
            Console.WriteLine(book);
            Console.WriteLine();
            var goldenEditionBook = new GoldenEditionBook(title, author, price);
            Console.WriteLine(goldenEditionBook);
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
    }
}

