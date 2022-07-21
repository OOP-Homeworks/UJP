using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> devs = new()
            {
                    new Programmer("C#"),
                    new Programmer("Java"),
                    new Programmer("Python")
                };
            devs.Add(new Builder("JS"));
            devs.Add(new Builder("C++"));

            foreach (IDeveloper dev in devs)
            {
                dev.Create();
                dev.Destory();
            }

            devs.Sort();

            Console.WriteLine("~ Sorting ~");
            foreach (IDeveloper dev in devs)
            {
                dev.Create();
                dev.Destory();
            }
        }
    }
}