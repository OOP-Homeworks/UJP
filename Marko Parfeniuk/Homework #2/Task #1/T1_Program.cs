using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>()
            {
                new Programmer("C++"),
                new Programmer("JavaScript"),
                new Programmer("Python"),
                new Builder("Drill"),
                new Builder("Hammer"),
                new Builder("Saw")
            };

            foreach(IDeveloper dev in developers)
            {
                dev.Create();
                dev.Destory();
            }

            developers.Sort();

            Console.WriteLine();
            foreach (IDeveloper dev in developers)
            {
                dev.Create();
                dev.Destory();
            }
        }
    }
}