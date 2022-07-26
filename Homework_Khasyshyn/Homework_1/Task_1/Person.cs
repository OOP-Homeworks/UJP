using System;

namespace Task_1
{
    internal class Person
    {
        private string name;
        private DateTime birthYear;
        public string Name
        {
            get { return name; }
        }
        public DateTime BirthYear
        {
            get { return birthYear; }
        }
        public Person()
        {
            name = "Liza";
            birthYear = new DateTime(2002);
        }
        public Person(string name, DateTime newBirthDay)
        {
            this.name = name;
            this.birthYear = newBirthDay;
        }
        public int Age(DateTime birthYear)
        {
            return DateTime.Now.Year - birthYear.Year;
        }
        public static Person Input(int i)
        {
            Console.WriteLine($"Enter {i + 1} person name");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter {i + 1} birth year (year)");
            int newBirthYear;
            int.TryParse(Console.ReadLine(), out newBirthYear);
            Person person = new Person(name, new DateTime(newBirthYear, 1, 1));
            return person;
        }
        public override string ToString()
        {
            return "\nPerson's name: " + name + "\nPerson's birthday: " + birthYear;
        }
        public static bool operator ==(Person first, Person second)
        {
            return (first.name == second.name);
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }
        public void ChangeName(string newName)
        {
            this.name = newName;

        }
        public void Output()
        {
            Console.WriteLine(ToString() + "\nPerson's Age: " + Age(this.birthYear));
        }
    }

}
