using System;

namespace Task_1
{
    class Person
    {
        string name;
        DateTime birthYear;

        public Person()
        {
            name = "Unknown";
            birthYear = DateTime.Now;
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }

        public static Person Input()
        {
            string name;
            int? yearValue;
            DateTime birthYear = DateTime.Now;

            Console.Write("To define a new person, please, enter the data below:\n" +
                "name >> ");
            name = Console.ReadLine();
            Console.Write("birthYear >> ");
            yearValue = (int.TryParse(Console.ReadLine(), out int res)
                && (res >= DateTime.MinValue.Year && res <= DateTime.Now.Year))
                ? res : null;
            if (yearValue.HasValue)
            {
                birthYear = birthYear.AddYears(yearValue.Value - birthYear.Year);
            }

            return new Person(name, birthYear);
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"name: {name}, birthYear: {birthYear.Year}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }

        public string Name { get { return name; } }
        public int BirthYear { get { return birthYear.Year; } }
    }
}
