using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double? inputNumber;
            bool isSessionActive = true;

            do
            {
                do
                {
                    Console.Write("Enter a double number:\n" +
                        "value >> ");
                    inputNumber = double.TryParse(Console.ReadLine(), out double res) ? res : null;
                    if (!inputNumber.HasValue)
                    {
                        Console.WriteLine("You've just entered the wrong value. Please, try again.");
                    }
                    else
                    {
                        string inputString = inputNumber.Value.ToString();
                        string inputFracPart = inputString.Contains('.') 
                            ? inputString.Substring(inputString.IndexOf('.') + 1) : String.Empty;
                        while (inputFracPart.Length < 2)
                        {
                            inputFracPart = inputFracPart.Insert(inputFracPart.Length, "0");
                        }
                        char[] fracPartChars = inputFracPart.ToCharArray(0, 2);
                        int firstFracPartDigit = fracPartChars[0] - '0';
                        int secondFracPartDigit = fracPartChars[1] - '0';
                        Console.WriteLine($"{firstFracPartDigit} + {secondFracPartDigit} " +
                            $"= {firstFracPartDigit + secondFracPartDigit}");
                    }

                } while (!inputNumber.HasValue);

                Console.Write("Continue? (Y/N) >> ");
                isSessionActive = Console.ReadLine() == "Y";

            } while (isSessionActive);
        }
    }
}