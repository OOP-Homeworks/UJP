using System;

namespace Hw1
{
    internal class exercise3
    {
        struct RGB
        {
            public byte r;
            public byte g;
            public byte b;
        }
        static void Main(string[] args)
        {
            RGB colorWhite = new RGB();
            colorWhite.r = colorWhite.g = colorWhite.b = 255; // fill fields by white color
            Console.WriteLine($"colorWhite: {colorWhite.r}.{colorWhite.g}.{colorWhite.b}");
            
            RGB colorBlack = new RGB();
            colorBlack.r = colorBlack.g = colorBlack.b = 0; // fill fields by black color
            Console.WriteLine($"colorBlack: {colorBlack.r}.{colorBlack.g}.{colorBlack.b}");
        }
    }
}
