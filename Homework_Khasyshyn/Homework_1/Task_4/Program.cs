using System;
using System.Net;//

namespace Hw1
{
    internal class exercise4
    {
        static void Main(string[] args)
        {
            int httpEnter;
            Console.Write("Please, enter the codeError of HTTP Error: ");

            httpEnter = int.Parse(Console.ReadLine());

            foreach (HttpStatusCode codeError in (HttpStatusCode[])Enum.GetValues(typeof(HttpStatusCode)))
            {
                if (httpEnter == (int)codeError)
                {
                    Console.WriteLine($"Name of entered HTTP Error: {codeError}");
                }
            }
        }
    }
}