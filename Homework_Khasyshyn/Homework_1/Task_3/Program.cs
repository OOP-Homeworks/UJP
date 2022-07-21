using System;

namespace Task__3
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            RGB white = new RGB(255, 255, 255);
            Console.WriteLine($"White color: {white}") ;
            RGB black = new RGB(0, 0, 0);
            Console.WriteLine($"Black color: {black}");
        }
    }
}