using System;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person[] persons = new Person[6];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
            }

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }

            for (int i = 0; i < persons.Length; i++)
            {
                if (Person.Age(persons[i].BirthYear) <16)
                {
                    persons[i].ChangeName("Very young");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }
            
            Console.WriteLine();
            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i+1; j < persons.Length; j++)
                {
                    if (persons[i]==persons[j])
                    {
                        Console.WriteLine($"{persons[i]} and \n {persons[j]} \n are equal");
                    }
                }
            }
        }
    }
}