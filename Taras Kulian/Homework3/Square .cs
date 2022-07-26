using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Square : Shape
    {
        private double side;
        public double Side { get => side; set => side = value; }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area() => Math.Pow(side, 2);

        public override double Perimeter() => 4 * side;

        public override string ToString()
        {
            return base.ToString() + $"; side = {side}.";
        }
        public override void Output()
        {
            Console.WriteLine(ToString());
        }

        public int CompareTo(Circle? obj)
        {
            if (obj != null)
                return this.Side.CompareTo(obj.Radius);
            else
                throw new Exception("Unable to compare two objects");
        }
    }
}
