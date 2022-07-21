using System;

namespace Task1
{
    public class Person
    {
        private string name;
        private DateTime birthYear;

        public string GetName() => name;
        public int GetBirthYear() => birthYear.Year;

        public Person()
        {
            name = "No Name";
            birthYear = DateTime.Now;
        }

        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = new DateTime(birthYear, 1, 1);
        }

        public int Age() => (DateTime.Now.Month <= birthYear.Month &&
                DateTime.Now.Day < birthYear.Day) ?
                DateTime.Now.Year - birthYear.Year - 1 :
                DateTime.Now.Year - birthYear.Year;

        public void Input()
        {
            string newName;
            string ?newYear;
            bool isYearValueIncorrect;
            bool isNameValueIncorrect;
            int newBirthDate;

            do
            {
                Console.WriteLine("Please, enter a name:");
                newName = Console.ReadLine();
                isNameValueIncorrect = String.IsNullOrEmpty(newName);
                if (isNameValueIncorrect)
                {
                    Console.WriteLine("Incorrect value for a name! :c");
                }
            } while (isNameValueIncorrect);
           

            do
            {
                Console.WriteLine("Please, enter the year of birthday:");
                newYear = Console.ReadLine();
                isYearValueIncorrect = !(Int32.TryParse(newYear, out newBirthDate) &&
                    newBirthDate >= DateTime.MinValue.Year && newBirthDate <= DateTime.Now.Year);
                if (isYearValueIncorrect)
                {
                    Console.WriteLine("Incorrect value for the year of birthday! :c");
                }
            } while (isYearValueIncorrect);

            name = newName;
            birthYear = new DateTime(newBirthDate, 1, 1);
        }

        public void ChangeName(string newName)
        {
            this.name = newName;
        }

        public override string ToString()
        {
            return $"Name: {name}, Birth year: {birthYear.Year}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person firstPerson, Person secondPerson)
        {
            return firstPerson.name == secondPerson.name;
        }

        public static bool operator !=(Person firstPerson, Person secondPerson)
        {
            return !(firstPerson == secondPerson);
        }
    }
}
