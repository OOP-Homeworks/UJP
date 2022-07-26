using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfPersons = 3;
            Dictionary<int, string> persons = new Dictionary<int, string>();
            int ID;
            string Name;

            Console.WriteLine($"Enter ID and name for {numberOfPersons} persons.");
            for (int i = 0; i < numberOfPersons; i++)
            {
                Console.Write($"ID person's {i+1}: ");
                ID = Int32.Parse(Console.ReadLine());
                Console.Write($"Name person's {i+1}: ") ;
                Name = Console.ReadLine();
                if (persons.ContainsKey(ID))
                {
                    Console.WriteLine($"person (ID: {ID}, name: {persons[ID]}) was updated");
                    --i;
                }
                persons[ID] = Name;
            }
            Console.Write("Enter a person's ID to find one:\nID: ");
            ID = Int32.Parse(Console.ReadLine());
            if (persons.ContainsKey(ID))
                {
                    Console.WriteLine($"person: \n ID: {ID}, name: {persons[ID]}");
                }
                else
                {
                    Console.WriteLine("Person not found");
                }
           
        }
    }
}