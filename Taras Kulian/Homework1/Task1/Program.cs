using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int peopleNumber = 6;
            Person[] people = new Person[peopleNumber];

            Console.WriteLine("Enter people data:");
            for(int i = 0; i < peopleNumber; i++)
            {
                people[i] = new Person();
                people[i].Input();
            }

            foreach (Person p in people)
            {
                if (p.Age() < 16)
                {
                    p.ChangeName("Very Young");
                }
            }

            Console.WriteLine("Here are your friends:");
            foreach (Person p in people)
            {
                Console.WriteLine($"{p}");
            }

            for(int i = 0; i < peopleNumber; i++)
            {
                for (int j = i + 1; j < peopleNumber; j++)
                {
                    if (i != j && people[i] == people[j])
                    {
                        Console.WriteLine($"These people '{people[i]}' and '{people[j]}' are equal");
                    }
                }
            }


        }
    }
}