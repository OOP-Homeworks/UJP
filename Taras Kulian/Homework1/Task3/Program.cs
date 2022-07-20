using System;

namespace Task3
{
    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;

        public RGB(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override string ToString()
        {
            return $"R={red}, G={green}, B={blue}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RGB blackColorRGB = new(0, 0, 0);
            Console.WriteLine($"Black color RGB: {blackColorRGB}.");

            RGB whiteColorRGB = new(255, 255, 255);
            Console.WriteLine($"White color RGB: {whiteColorRGB}.");
            
        }
    }
}