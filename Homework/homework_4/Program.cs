using System;
using System.Net;

namespace ConsoleApplication1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int error;
            Console.WriteLine("Enter Http error");
            Int32.TryParse(Console.ReadLine(), out error);
            foreach (HttpStatusCode i in Enum.GetValues(typeof(HttpStatusCode)))  
            {
                if (error == (int)i)
                {
                    Console.WriteLine($"{error} - {i}" );  
                }
                
            } 
        }
        
    }
}