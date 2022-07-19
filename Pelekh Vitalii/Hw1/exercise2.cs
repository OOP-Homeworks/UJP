using System;

namespace Hw1
{
    internal class exercise2
    {
        static void Main(string[] args)
        {
            double enteredNumber;
            Console.Write("Enter float number (with coma symbol): ");
            enteredNumber = double.Parse(Console.ReadLine());

            double fractionalPart = enteredNumber - Math.Floor(enteredNumber);
            int fractionalPartInt = (int)(fractionalPart * 100);
            int digitFirst = fractionalPartInt % 10;
            int digitSecond = fractionalPartInt / 10 % 10;
            int res = digitFirst + digitSecond;
            Console.WriteLine($"Sum: {res}");
        }
    }
}
