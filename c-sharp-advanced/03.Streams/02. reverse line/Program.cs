using System;
using System.IO;

namespace _02._reverse_line
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var readStream = new StreamReader("Program.cs"))
            {
                using (var writeStream = new StreamWriter("reversed.txt"))
                {
                    var lineNumber = 1;
                    string line;
                    while ((line = readStream.ReadLine()) != null)
                    {
                        for (int i = line.Length - 1; i >= 0; i--)
                        {
                            writeStream.Write(line[i]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
