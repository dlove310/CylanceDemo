using System;
using System.Collections.Generic;
using TestConsoleApp;

namespace TestExecutable
{
    class TestApplication
    {
        static void Main(string[] args)
        {
            string[] replacement = new string[2];
            int[] divisableBy = new int[2];
            for (int i = 0; i < 2; i++)
            {
                string input = null;
                while (string.Equals(input,"0") || string.Equals(input, null)) 
                {
                    Console.Write("Write a Divisable By number: WARNING cannot divide by 0 ");

                    input = Console.ReadLine();
                    if (!int.TryParse(input, out divisableBy[i]))
                    {
                        Console.WriteLine("Sorry, '{0}' is not a valid number.", input);
                        i--;
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Write your first replacement for your devisable by number: ");
                replacement[i] = Console.ReadLine();
            }
            List<string> output = IntArray.NumberToString(replacement, divisableBy);
            output.ForEach(Console.WriteLine);
        }
    }
}
