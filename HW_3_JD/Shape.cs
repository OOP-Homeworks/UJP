using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Shape : IComparable
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();
        public abstract int CompareTo(object obj);

    }
}
