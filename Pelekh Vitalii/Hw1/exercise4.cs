using System;
using System.Net;

namespace Hw1
{
    internal class exercise4
    {
        static void Main(string[] args)
        {
            int httpEnter;
            Console.Write("Enter the code of HTTP Error: ");
            httpEnter = int.Parse(Console.ReadLine());

            foreach (HttpStatusCode code in (HttpStatusCode[])Enum.GetValues(typeof(HttpStatusCode)))
            {
                if(httpEnter == (int)code)
                {
                    Console.WriteLine($"Name of entered HTTP Error: {code}");
                }
            }
        }
    }
}
