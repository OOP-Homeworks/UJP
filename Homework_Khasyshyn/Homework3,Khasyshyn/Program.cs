using System;
using System.Collections.Generic;
using System.IO;

namespace Task_HW3
{ 
    public abstract class Shape: IComparable
    {
       private string name;
        public string Name { get { return name; } }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
        public virtual void Print()
        {
            Console.WriteLine("Shape: name - {0}",this.name);
        }
       public abstract int CompareTo(object obj);
    
    }

    public class Circle : Shape
    {
        private double radius;
        public double Radius { get { return radius; } }
        public Circle(string name, double radius):base(name)
        {
            this.radius = radius;
        }
        public override  double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double Perimeter()
        {
            return 2*Math.PI * radius;
        }
        override public void Print()
        {
            Console.WriteLine("Shape: name - {0}, area - {1}, perimeter - {2}",Name, Area(), Perimeter());
        }
        public override int CompareTo(object obj)
        {
            return this.Perimeter().CompareTo((obj as Shape).Perimeter());
        }
    }

    public class Square : Shape
    {
        private double side;
        public double Radius { get { return side; } }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return Math.Pow(side, 2);
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
        override public void Print()
        {
            Console.WriteLine("Shape: name - {0}, area - {1}, perimeter - {2}", Name, Area(), Perimeter());
        }
        public override int CompareTo(object obj)
        {
            return this.Perimeter().CompareTo((obj as Shape).Perimeter());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
           const int numberOfShapes = 4;

            for (int i = 0; i < numberOfShapes; i++)
            {
                Console.WriteLine($"Please, write name for shape №{i + 1}: ");
                string? name = Console.ReadLine();
                if (name == string.Empty)
                {
                    Console.WriteLine($"Name can't be empty. Please, try again");
                    i--;
                    continue;
                }
                Console.WriteLine("Please enter 0 to create circle and 1 to create square:");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    if (inputNumber == 0)
                    {
                        Console.WriteLine($"Write radius for your circle");
                        if (double.TryParse(Console.ReadLine(), out double radius))
                        {
                            shapes.Add(new Circle(name, radius));
                        }
                        else
                        {
                            Console.WriteLine($"Wrong value radius");
                            i--;
                            continue;
                        }

                    }
                    else if (inputNumber == 1)
                    {
                        Console.WriteLine($"Write side for your square");
                        if (double.TryParse(Console.ReadLine(), out double side))
                        {
                            shapes.Add(new Square(name, side));
                        }
                        else
                        {
                            Console.WriteLine($"Wrong value side");
                            i--;
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong number");
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }

            foreach (Shape shape in shapes)
            {
               shape.Print();
            }
            double max = 0;
            string nameShape = "";

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() > max)
                {
                    max = shapes[i].Perimeter();
                    nameShape = shapes[i].Name;
                }
            }
            Console.WriteLine($"Shape with max Perimeter:{nameShape} , perimeter = {max}");

            Console.WriteLine("\n\n_______Sorting by area_______\n");
            shapes.Sort(delegate (Shape a, Shape b)
            {
                return a.Area().CompareTo(b.Area());
            });

            foreach (Shape shape in shapes)
            {
                shape.Print();
            }

        }
    }
}