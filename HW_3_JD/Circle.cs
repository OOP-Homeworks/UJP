using System;

namespace ConsoleApp1
{
   public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; } 
        }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * radius;
        }

        public override string ToString()
        {
            return "Name is " + Name + ", Radius is " + radius;
        }

        public override int CompareTo(object obj)
        {
            return this.Perimeter().CompareTo((obj as Shape).Perimeter());
        }
    }
}