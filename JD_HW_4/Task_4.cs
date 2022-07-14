using System;
using System.Drawing;


namespace Hw44
{
    class Task4
    {
        static void Main(string[] args)
        {

            int error = 400;
            switch (error)
            {
                case 400:
                    Console.WriteLine("Bad Request");
                    break;
                case 401:
                    Console.WriteLine("Unauthorized");
                    break;
                case 404:
                    Console.WriteLine("Not Found");
                    break;
                default:
                    Console.WriteLine("Error not recognized.");
                    break;
            }

            Console.ReadKey();
        }
    }
}





