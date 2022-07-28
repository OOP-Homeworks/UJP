using System;
using System.Collections.Generic;
using System.Linq;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            string shapeName;
            double shapeValue;
            Shape newShape;
            List<Shape> shapes = new List<Shape>();
            Random rand = new Random();

            for (int i = 0; i < N; ++i)
            {
                try
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.Write("Create new circle:\nname >> ");
                        shapeName = Console.ReadLine();
                        Console.Write("radius >> ");
                        shapeValue = double.Parse(Console.ReadLine());
                        newShape = new Circle(shapeName, shapeValue > 0 ? shapeValue : Math.Abs(shapeValue));
                    }
                    else
                    {
                        Console.Write("Create new square:\nname >> ");
                        shapeName = Console.ReadLine();
                        Console.Write("side >> ");
                        shapeValue = double.Parse(Console.ReadLine());
                        newShape = new Square(shapeName, shapeValue > 0 ? shapeValue : Math.Abs(shapeValue));
                    }
                    shapes.Add(newShape);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    --i;
                }
            }

            Console.WriteLine("Shapes:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine("The shape with max area value:");
            Console.WriteLine(shapes.Aggregate((i, j) => i.Area() > j.Area() ? i : j));

            shapes.Sort();
            Console.WriteLine("Shapes sorted by area value:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}