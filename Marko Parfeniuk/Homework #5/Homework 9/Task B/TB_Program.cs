using System;
using System.IO;
using System.Linq;

namespace Task_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"TB_Code.txt";
            string[] textLines;
            string shortestLine, longestLine;

            try
            {
                textLines = File.ReadAllLines(filePath);
                Console.WriteLine("Number of symbols in every line:");
                foreach (int number in from line in textLines
                                       select line.Length)
                {
                    Console.WriteLine(number);
                }

                shortestLine = textLines.OrderBy(line => line.Length).First();
                Console.WriteLine("Shortest line:\n{0}", shortestLine);
                longestLine = textLines.OrderByDescending(line => line.Length).First();
                Console.WriteLine("Longest line:\n{0}", longestLine);

                Console.WriteLine("Lines, which consist of word \"var\":");
                foreach (string line in textLines.Where(line => line.Contains("var")))
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}