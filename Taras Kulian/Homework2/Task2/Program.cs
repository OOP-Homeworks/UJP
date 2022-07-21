using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> massages = new();
            massages.Add("Wrong ID", "Please try again. Enter unsigned integer!");
            massages.Add("ID is used", "Please try again. Person with that ID " +
                "already exists!");
            massages.Add("Wrong name", "Please try again. Field name can't be empty!");
            massages.Add("Person not found", "Can't find a person with this ID :c");

            const int PEOPLE_AMOUNT = 3;
            Dictionary<uint, string> people = new();
            uint inputID;
            string ?inputName;
            bool isInputCorrect;

            Console.WriteLine($"Please, enter info 'bout {PEOPLE_AMOUNT} people" +
                $" in the following form: {{ID, name}}");
            for (int i = 0; i < PEOPLE_AMOUNT; i++)
            {
                Console.WriteLine($"Person #{i + 1}");
                do
                {
                    Console.WriteLine("Enter ID:");
                    isInputCorrect = uint.TryParse(Console.ReadLine(), out inputID);
                    if (!isInputCorrect)
                    {
                        Console.WriteLine(massages["Wrong ID"]);
                    } else if (people.ContainsKey(inputID))
                    {
                        Console.WriteLine(massages["ID is used"]);
                        isInputCorrect = false;
                    }
                } while (!isInputCorrect);
                do
                {
                    Console.WriteLine("Enter name");
                    inputName = Console.ReadLine();
                    isInputCorrect = (inputName != null);
                    if (!isInputCorrect)
                    {
                        Console.WriteLine(massages["Wrong name"]);
                    }
                } while (!isInputCorrect);
               
                people.Add(inputID, inputName);
            }
            do
            {
                Console.WriteLine("Please, enter a person's ID you want to find:");
                isInputCorrect = uint.TryParse(Console.ReadLine(), out inputID);
                if (!isInputCorrect)
                {
                    Console.WriteLine(massages["Wrong ID"]);
                } else
                {
                    if (people.TryGetValue(inputID, out string value))
                    {
                        Console.WriteLine($"Person is found: {{ID: {inputID}," +
                            $"name: {value}}}");
                    }
                    else
                    {
                        Console.WriteLine(massages["Person not found"]);
                    }
                }
            } while (!isInputCorrect);
            
        }
    }
}