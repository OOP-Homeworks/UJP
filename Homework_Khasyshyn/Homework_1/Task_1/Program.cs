using System;


namespace Task1_
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfPerson = 5;
            const int minAge = 16;

            Person[] people = new Person[numberOfPerson];

            for (int i = 0; i < numberOfPerson; i++)
            {
                people[i] = Person.Input(i);

            }
            for (int i = 0; i < people.Length; i++)
            {
                people[i].Output();
            }


            for (int i = 0; i < numberOfPerson; i++)
            {
                if (people[i].Age(people[i].BirthYear) < minAge)
                {
                    people[i].ChangeName("Very Young");
                }
            }


            for (int i = 0; i < people.Length; i++)
            {
                people[i].Output();
            }


            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"{people[i].Name} and {people[j].Name} have the same names");
                    }
                }
            }
        }
    }
}
