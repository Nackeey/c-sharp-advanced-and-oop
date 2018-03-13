using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<IBuyer> buyers = new List<IBuyer>();
        GetInfoForPeople(buyers);
        BuyersBuyFood(buyers);

        int totalFood = buyers.Sum(f => f.Food);

        Console.WriteLine(totalFood);
    }

    private static void BuyersBuyFood(List<IBuyer> buyers)
    { 
        string inputName = string.Empty;
        while ((inputName = Console.ReadLine()) != "End")
        {
            var buyer = buyers.FirstOrDefault(b => b.Name == inputName);
            if (buyer != null)
            {
                buyer.BuyFood();
            }
        }
    }

    private static void GetInfoForPeople(List<IBuyer> buyers)
    {
        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (input.Length == 4)
            {
                var buyer = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                buyers.Add(buyer);
            }
            else
            {
                var buyer = new Rebel(input[0], int.Parse(input[1]), input[2]);
                buyers.Add(buyer);
            }
        }
    }
}

