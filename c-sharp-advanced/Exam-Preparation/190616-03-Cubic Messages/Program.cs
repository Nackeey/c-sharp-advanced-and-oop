using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _190616_03_Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^(\d+)([a-zA-Z]+)([^a-zA-Z]*)$";

            string inputLine = string.Empty;
            while ((inputLine = Console.ReadLine()) != "Over!")
            {
                var messageLength = int.Parse(Console.ReadLine());
                var match = Regex.Match(inputLine, pattern);
                if (match.Success)
                {
                    var prefix = match.Groups[1].Value;
                    var message = match.Groups[2].Value;
                    var ending = string.Empty;
                    if (match.Groups[3].Value != "")
                    {
                        ending = match.Groups[3].Value;
                    }

                    if (message.Length != messageLength)
                    {
                        continue;
                    }

                    var indexes = Regex.Replace(prefix + ending, @"\D*", string.Empty);
                    var sb = new StringBuilder();

                    foreach (var index in indexes)
                    {
                        var ind = int.Parse(index.ToString());
                        if (ind >= 0 && ind < messageLength)
                        {
                            sb.Append(message[ind]);
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }
                    Console.WriteLine($"{message} == {sb}");
                }
            }
        }
    }
}
