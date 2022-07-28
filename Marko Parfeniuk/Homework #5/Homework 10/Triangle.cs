using System;
using System.Collections.Generic;

namespace homework
{
    public class Triangle
    {
        Point vertex1;
        Point vertex2;
        Point vertex3;

        public Triangle() { }

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            double a = Distance(vertex1, vertex2);
            double b = Distance(vertex1, vertex3);
            double c = Distance(vertex2, vertex3);

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Triangle does not exist.");
            }

            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }

        public double Distance(Point p, Point q)
        {
            return Math.Sqrt(Math.Pow(q.X - p.X, 2) + Math.Pow(q.Y - p.Y, 2));
        }

        public double Perimeter()
        {
            return Distance(vertex1, vertex2) + Distance(vertex1, vertex3) + Distance(vertex2, vertex3);
        }

        public double Square()
        {
            double semiPerimeter = Perimeter() / 2;
            return Math.Sqrt(semiPerimeter
                * (semiPerimeter - Distance(vertex1, vertex2))
                * (semiPerimeter - Distance(vertex1, vertex3))
                * (semiPerimeter - Distance(vertex2, vertex3)));
        }

        public void Print()
        {
            Console.WriteLine($"vertex #1: {vertex1}, vertex #2: {vertex2}, vertex #3: {vertex3}; " +
                $"P = {Perimeter()}, S = {Square()}");
        }

        public Point Vertex1 { get { return vertex1; } }
        public Point Vertex2 { get { return vertex2; } }
        public Point Vertex3 { get { return vertex3; } }
    }
}