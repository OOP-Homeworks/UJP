using System;

namespace Hw34
{
    class Task3
    {
        static void Main(string[] args)
        {

            MyColorRGB whiteColor;
            MyColorRGB blackColor;

            whiteColor.red = 255;
            whiteColor.green = 255;
            whiteColor.blue = 255;

            blackColor.red = 0;
            blackColor.green = 0;
            blackColor.blue = 0;


            Console.ReadKey();
        }
    }
}


struct MyColorRGB
{
    public byte red;
    public byte green;
    public byte blue;
};


