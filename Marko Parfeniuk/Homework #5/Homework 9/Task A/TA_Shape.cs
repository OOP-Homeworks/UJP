using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            return this.Area().CompareTo(other.Area());
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return $"name: {Name}, area: {Area()}, perimeter: {Perimeter()}";
        }
    }
}
