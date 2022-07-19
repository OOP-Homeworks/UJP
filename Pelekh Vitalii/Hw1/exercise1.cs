using System;

namespace Hw1
{
    internal class exercise1
    {
        public class Person
        {
            // two private fields
            private string name;
            private DateTime birthYear;

            // two properties for access to these field
            public string Name 
            { 
                get { return name; } 
            }          
            public DateTime BirthYear
            {
                get { return birthYear; }
            }

            // default constructor and constructor with 2 parameters
            public Person()
            {
                name = "Slayer";
                birthYear = new DateTime(1999, 6, 6);
            }
            public Person(string name, DateTime year)
            {
                this.name = name;
                this.birthYear = year;
            }

            //methods:
            //- Age() - to calculate the age of person
            //- Input() - to enter data about person from console
            //- ChangeName() - to change the name of person
            //- ToString()
            //- Output() - to output information about person(call ToString())
            //- operator== (equal by name)

            public static int Age(DateTime birthYear)
            {
                return DateTime.Now.Year - birthYear.Year;
            }

            public static Person Input(int i)
            {
                Console.Write($"\nEnter {i + 1} person name: ");
                string name = Console.ReadLine();

                Console.Write($"Enter {i + 1} person birthYear: ");
                DateTime birthYear;
                DateTime.TryParse(Console.ReadLine(), out birthYear);
                
                Person person = new Person(name, birthYear);   // створювання об`єкта з конструктором з параметрами 
                return person;
            }

            public void ChangeName()
            {
                Console.Write($"\nEnter new name for {this.name}: ");
                string nameNew = Console.ReadLine();
                this.name = nameNew;
            }

            public override string ToString()
            {
                return "\nPerson's name: " + name + "\nPerson's birthday: " + birthYear;
            }

            public void Output()
            {
                Console.WriteLine(ToString() + "\nPerson's Age: " + Age(this.birthYear));
            }

            public static bool operator !=(Person first, Person second)
            {
                return !(first.name == second.name);
            }

            public static bool operator ==(Person first, Person second)
            {
                return (first.name == second.name);
            }  
        }
        static void Main(string[] args)
        {
            // Create 6 objects of Person type and enter information about them 
            Person[] persons = new Person[6]; // створюємо об'єкт класу за конструктором без параметрів

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
            }

            // Then calculate and output on the console name and Age of each person
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }

            // Change the name of persons, which Age is less then 16, to "Very Young"
            for (int i = 0; i < persons.Length; i++)
            {
                if (Person.Age(persons[i].BirthYear) <= 16)
                {
                    persons[i].ChangeName();
                }
            }

            // Output information about all persons on the console
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }

            // Find and output information about Persons with the same names (use ==)
            for(int i = 0;i < persons.Length; i++)
            {
                for(int j = i+1;j < persons.Length; j++)
                {
                    if(persons[i] == persons[j])
                    {
                        Console.WriteLine($"{persons[i].Name} and {persons[j].Name} have the same names");
                    }
                }
            }
        }
    }
}
