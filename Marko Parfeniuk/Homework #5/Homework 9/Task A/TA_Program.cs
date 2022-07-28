using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Task_A
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = @"shapes.txt";
            List<Shape> shapes = new List<Shape>() {
                new Circle("Circle #1", 5),
                new Circle("Circle #2", 10),
                new Circle("Circle #3", 0.5),
                new Square("Square #1", 5),
                new Square("Squ_re #2", 10),
                new Square("Square #3", 1)
            };

            try
            {
                using (StreamWriter sr = new StreamWriter(filePath))
                {
                    foreach (Shape shape in
                        from shape in shapes
                        where shape.Area() >= 10 && shape.Area() <= 100
                        select shape)
                    {
                        sr.WriteLine(shape);
                    }

                    foreach (Shape shape in shapes.Where(shape => shape.Name.Contains('a')))
                    {
                        sr.WriteLine(shape);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            shapes.RemoveAll(x => x.Perimeter() < 5);
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}