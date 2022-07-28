using System;
using System.Collections.Generic;
using System.Linq;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Point origin = new Point(0, 0);
            List<Triangle> triangles = new List<Triangle>() {
                new Triangle(new Point(1, 5), new Point(2, 3), new Point(0, 1)),
                new Triangle(new Point(7, 10), new Point(1, 1), new Point(82, 4)),
                new Triangle(new Point(75, 33), new Point(327, 332), new Point(5, 5)),
                new Triangle(new Point(1, 5), new Point(2, 5), new Point(4, 6))
            };

            foreach (Triangle triangle in triangles)
            {
                triangle.Print();
            }
			
            triangles.OrderBy(x => 
                new List<double> {
                    x.Distance(x.Vertex1, origin),
                    x.Distance(x.Vertex2, origin),
                    x.Distance(x.Vertex3, origin)
                }.Min()).First().Print();
        }
    }
}