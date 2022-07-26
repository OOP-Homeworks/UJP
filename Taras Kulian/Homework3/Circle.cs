using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius { get => radius; set => radius = value; }

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area() => Math.PI * Math.Pow(radius, 2);

        public override double Perimeter() => 2 * Math.PI * radius;

        public override string ToString()
        {
            return base.ToString() + $"; radius = {radius}.";
        }
        public override void Output()
        {
            Console.WriteLine(ToString());
        }

        public int CompareTo(Circle? obj)
        {
            if (obj != null)
                return this.Radius.CompareTo(obj.Radius);
            else
                throw new Exception("Unable to compare two objects");
        }
    }
}
