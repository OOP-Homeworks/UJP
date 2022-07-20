using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numbersAfterPoint = 2;
            const int numeralSystem = 10;
            double inputDouble = 0;
            double inputDoubleCopy = 0;
            bool isInputCorrent;
            int sum = 0;
            int currentNumberAfterPoint;

            do
            {
                Console.WriteLine("Please, enter a double number: ");
                isInputCorrent = double.TryParse(Console.ReadLine(), out double result);
                if (isInputCorrent)
                {
                    inputDouble = result;
                    inputDoubleCopy = result;
                } else
                {
                    Console.WriteLine("Incorrect input! :c");
                }
            } while (!isInputCorrent);
            
            for (int i = 0; i < numbersAfterPoint; i++)
            {
                currentNumberAfterPoint = (int)Math.Truncate(inputDouble * numeralSystem)
                    - (int)(Math.Truncate(inputDouble) * numeralSystem);
                inputDouble = inputDouble * numeralSystem;
                sum += currentNumberAfterPoint;
            }

            Console.WriteLine($"The sum of {numbersAfterPoint} numbers after point " +
                $"of double {inputDoubleCopy} is equal: {sum}" );
        }
    }
}