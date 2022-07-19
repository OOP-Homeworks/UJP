using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 6;
            Person[] people = new Person[N];

            for (int i = 0; i < N; i++)
            {
                people[i] = Person.Input();
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"name: {people[i].Name}, age: {people[i].Age()}");
            }

            for (int i = 0; i < N; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName("Very Young");
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(people[i]);
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"{{{people[i]}}} & {{{people[j]}}} are equal");
                    }
                }
            }
        }
    }
}
