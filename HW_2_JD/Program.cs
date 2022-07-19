using System;
using System.Collections.Generic;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("C"));
            developers.Add(new Programmer("C++"));
            developers.Add(new Builder("Design Pattern"));
            developers.Add(new Builder("Cloud Based"));

            Console.WriteLine("-------- Task 1---------");

            foreach (IDeveloper developer in developers)
            {
                developer.Create(developer.Tool);
                developer.Destroy(developer.Tool);
            }

            Console.WriteLine("\n\nSorted developers:");

            developers.Sort();
           
            foreach (IDeveloper developer in developers)
            {
                developer.Create(developer.Tool);
            }




            Console.WriteLine("\n\n\n\n-------- Task 2---------");

            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            int countPerons = 7;

            Console.WriteLine("\n\tPlease enter some info");

            for (int i = 0; i < countPerons; i++)
            {
                Console.Write("\nEnter people id : ");
                uint id = (uint)Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter people name : ");
                string name = Console.ReadLine();
                persons.Add(id, name);
            }


            Console.WriteLine("\n\tList of people : ");

            foreach (KeyValuePair<uint, string> keyValue in persons)
            {
                Console.Write($"\n id({ keyValue.Key}) - name ({keyValue.Value})");
            }

            Console.Write("\n\nPlease enter search id - ");

            uint searchId = (uint)Convert.ToInt32(Console.ReadLine());

            foreach (KeyValuePair<uint, string> id in persons)
            {
                if (id.Key == searchId)
                {
                    Console.WriteLine($"\nPerson with id({searchId}) is {id.Value}!");
                    break;
                }
                
            }
     
            Console.ReadKey();
        }
    }
}
