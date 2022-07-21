using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> shapeD = new Dictionary<int, string>();
            shapeD.Add(0, "Circle");
            shapeD.Add(1, "Square");

            const int count = 3;
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < count; i++)
            {
                Console.Write("\n\nPlease write number 0 or 1.\n0 - circle  1 - square \n\nNumber -  ");
                int KEY = int.Parse(Console.ReadLine());

                if(KEY == 0 || KEY == 1)
                {
                    Console.Write($"\nWrite name for {shapeD[KEY]} - ");
                    string name = Console.ReadLine();
                    Console.Write($"\nWrite side for {shapeD[KEY]} - ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    if (shapeD[KEY] ==  "Square")
                    {
                        shapes.Add(new Square(name, length));
                    }
                    else if (shapeD[KEY] == "Circle")
                    {
                        shapes.Add(new Circle(name, length));
                    }
                }
                 else
                {
                    Console.WriteLine("\n You wrote wronge number!");
                    i--;
                }
            }
            Console.WriteLine();
           
            Print(shapes);

            Console.WriteLine("\n\n...Finding shape with MAX Perimeter\n");

            string nameShape = "";
            double maxValue = -1;

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() > maxValue)
                {
                    maxValue = shapes[i].Perimeter();
                    nameShape = shapes[i].Name;
                }
            }
            Console.WriteLine($"\n > Shape with MAX Perimeter is {nameShape} with value {maxValue} .");

            Console.WriteLine("\n\n...Sorting by perimeter\n");
            shapes.Sort();
            Print(shapes);

            Console.WriteLine("\n\n...Sorting by area\n");
            shapes.Sort(delegate (Shape a, Shape b)
            {
                return a.Area().CompareTo(b.Area());
            });
            Print(shapes);

            Console.WriteLine("\nEND!");
        }

        static void Print(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($" > Name - {shape.Name}  area : {shape.Area()}  perimeter : {shape.Perimeter()}");
            }
        }
    }
}


