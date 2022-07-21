using System;
using System.Collections.Generic;

namespace Task_2
{
    public static class FeatureMessages
    {
        public const string WrongIdValueError =
            @"You've just entered a wrong value for ID";
        public const string PersonNotFoundError =
            @"Person not found";
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int N = 7;
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            uint inputID;
            string inputName;

            Console.WriteLine($"Enter ID and name for {N} persons.");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"person #{i}:\nID >> ");
                if (!uint.TryParse(Console.ReadLine(), out inputID))
                {
                    Console.WriteLine(FeatureMessages.WrongIdValueError);
                    --i;
                    continue;
                }
                Console.Write("name >> ");
                inputName = Console.ReadLine();
                if (persons.ContainsKey(inputID))
                {
                    Console.WriteLine($"person (ID: {inputID}, name: {persons[inputID]}) was updated");
                    --i;
                }
                persons[inputID] = inputName;
            }
            Console.Write("Enter a person's ID to find one:\nID >> ");
            if (uint.TryParse(Console.ReadLine(), out inputID))
            { 
                if (persons.ContainsKey(inputID))
                {
                    Console.WriteLine($"person (ID: {inputID}, name: {persons[inputID]})");
                }
                else
                {
                    Console.WriteLine(FeatureMessages.PersonNotFoundError);
                }
            }
            else
            {
                Console.WriteLine(FeatureMessages.WrongIdValueError);
            }
        }
    }
}