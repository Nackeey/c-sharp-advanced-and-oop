using System;

public class StartUp
{
    public static void Main()
    {
        string[] studentTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] workerTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        try
        {
           

            Student student = new Student(studentTokens[0], studentTokens[1], studentTokens[2]);

            Worker worker = new Worker
                (workerTokens[0]
                , workerTokens[1]
                , decimal.Parse(workerTokens[2])
                , decimal.Parse(workerTokens[3]));

            Console.WriteLine(student.ToString());
            Console.WriteLine(worker.ToString());
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
        
    }
}

