using System;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Enter your number(double)");
            double.TryParse(Console.ReadLine(), out num);
            num = Math.Floor((num - Math.Truncate(num))*100);
            num = Math.Floor(num % 10) + Math.Floor((num/10)%10);
            Console.WriteLine(num);
        }
    }
}