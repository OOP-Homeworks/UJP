using System;
using System.Diagnostics.Eventing.Reader;

namespace ConsoleApplication4
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        private DateTime birthYear;
        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
            name = "Mark";
            birthYear = new DateTime(2002, 1, 1, 6, 32, 0);
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public static Person Input(int i)
        {
            Console.WriteLine($"Enter {i+1} person name");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter {i+1} birth year (day/month/year)");
            DateTime birthYear;
            DateTime.TryParse(Console.ReadLine(), out birthYear);
            Person person = new Person(name, birthYear);
            return person;
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public void ChangeName(string name)
        {
            this.name = name;

        }

        public static int Age(DateTime birthYear)
        {
            DateTime year = DateTime.Now;
            return year.Year-birthYear.Year;
        }

        public override string ToString()
        {
            return $"Person's name - {name} \t person's birth year is - {birthYear} \t person's Age - {Age(birthYear)}";
        }
        
        public static bool operator ==(Person first, Person second)
        {
            return (first.name == second.name);
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }
    }
}