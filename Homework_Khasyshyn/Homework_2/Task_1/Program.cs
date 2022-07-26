using System;
using System.Collections.Generic;
using Task1;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("Java"));
            developers.Add(new Programmer("С++"));
            developers.Add(new Programmer("Python"));
            developers.Add(new Builder("Сhainsaw"));
            developers.Add(new Builder("Saw"));
            developers.Add(new Builder("Hammer"));
            developers.Add(new Builder("Drill"));
            

            foreach (IDeveloper develop in developers)
            {
                develop.Create();
                develop.Destroy();
                Console.WriteLine();
            }

            developers.Sort();
            Console.WriteLine();
            Console.WriteLine("Sosted:\n");
            foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
                Console.WriteLine();
            }
        }
    }
}