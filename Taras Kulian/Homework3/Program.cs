using Homework3;

class Program
{

    enum ShapeType
    {
        Circle = 1, Square = 2
    }

    static void Main(string[] args)
    {
        const int shapesAmount = 3;
        List<Shape> shapes = new();

        for (int i = 0; i < shapesAmount; i++)
        {
            Console.WriteLine($"Write name for shape #{i + 1}");
            string? name = Console.ReadLine();
            if (name == string.Empty)
            {
                Console.WriteLine($"Shape name can't be empty! Try again!");
                i--;
                continue;
            }
            Console.WriteLine("Please enter 1 to create circle and 2 to create square:");
            if (int.TryParse(Console.ReadLine(), out int inputNumber))
            {
                if (inputNumber == (int)ShapeType.Circle)
                {
                    Console.WriteLine($"Write radius for your {(ShapeType)inputNumber}");
                    if (double.TryParse(Console.ReadLine(), out double radius))
                    {
                        shapes.Add(new Circle(name, radius));
                    } else
                    {
                        Console.WriteLine($"Wrong value radius! Try again!");
                        i--;
                        continue;
                    }
                    
                } else if (inputNumber == (int)ShapeType.Square)
                {
                    Console.WriteLine($"Write side for your {(ShapeType)inputNumber}");
                    if (double.TryParse(Console.ReadLine(), out double side))
                    {
                        shapes.Add(new Square(name, side));
                    }
                    else
                    {
                        Console.WriteLine($"Wrong value side! Try again!");
                        i--;
                        continue;
                    }
                } else
                {
                    Console.WriteLine("Wrong number! Please try again!");
                    i--;
                }
            } else
            {
                i--;
            }
        }

        Console.WriteLine($"\n-- Here are ur shapes:");
        foreach (Shape shape in shapes)
        {
            shape.Output();
            Console.WriteLine($"Perimeter: {shape.Perimeter()}, Area: {shape.Area()}");
        }

        Shape? maxShape = null;
        foreach (Shape shape in shapes)
        {
            if (maxShape == null) maxShape = shape;
            else if (shape.Perimeter() > maxShape.Perimeter()) maxShape = shape;
        }
        Console.WriteLine($"The shape with max Perimeter is {maxShape.Name} " +
            $"with Perimeter {maxShape.Perimeter()}.");

        Console.WriteLine($"\n-- Sorted list of shapes:");
        shapes.Sort();
        foreach (Shape shape in shapes)
        {
            shape.Output();
        }
    }
}