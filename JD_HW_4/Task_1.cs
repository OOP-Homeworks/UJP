using System;

namespace HW4
{
    class Task1
    {
        static void Main(string[] args)

        {

            var persons = new Person[6];

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
            }

            Console.WriteLine("\n\t Persons name and age : \n");

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine("\tNAME - " + persons[i].Name + "\tAGE - " + Person.Age(persons[i]));
            }

            Console.WriteLine("\nPersons : \t");
            for (int i = 0; i < persons.Length; i++)
            {
                if (Person.Age(persons[i]) < 16) { Person.ChangeName(persons[1], "Very Young"); }
                persons[i].Output();

            }

            Console.WriteLine("\n\tPersons with the same names : \t");
            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i].Name.Equals(persons[j].Name))
                    {
                        Console.WriteLine("**");
                        persons[i].Output();
                        persons[j].Output();
                        Console.WriteLine("** \n");
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
        

        class Person
        {
            private string name;
            private DateTime birthYear;
            public string Name
            {
                get { return name; }
            }
            public int BirthYear
            {
                get { return birthYear.Year; }
            }

            public Person()
            {
                name = "Iryna";
                birthYear = new DateTime(2000, 1, 1);
            }

            public Person(string name, int year)
            {
                this.name = name;
                this.birthYear = new DateTime(year, 1, 1);
            }

            public static int Age(Person person)
            {
                DateTime todayYear = DateTime.Now;
                int age = todayYear.Year - person.birthYear.Year ;
                return age;
            }

            public static Person ChangeName(Person person, string newName)
            {
                person.name = newName;
                return person;
            }

            public override string ToString()
            {
                return "Person name - " + name + "; \t\t Person  birthday year -" + birthYear.Year;
            }


            public static Person Input(int i)
            {
                Console.Write($"\nEnter { i + 1} person name - ");
                string name = Console.ReadLine();
                Console.Write($"\nEnter  { i + 1} person birthday year - ");
                int year = Convert.ToInt32(Console.ReadLine());
                Person person = new Person(name, year);
                return person;
            }

            public void Output()
            {
                Console.WriteLine(ToString());
            }


            public static bool operator ==(Person person1, Person person2)
            {
                return (person1.name == person2.name);
            }

            public static bool operator !=(Person person1, Person person2)
            {
                return !(person1.name == person2.name);
            }
        }
    

