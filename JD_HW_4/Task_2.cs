using System;

namespace HW4
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter double  number at least with 3 digits after point : ");
            string number = Console.ReadLine();
            string[] splitNum = number.Split(".");
            int leghtFrac = splitNum[1].Length;

            if(leghtFrac > 2)
            {
               string frac = splitNum[1];
               int  sumFrac = int.Parse(frac[0].ToString()) + int.Parse(frac[1].ToString());
             Console.WriteLine($"Sum of the first 2 digits after the point of  {number} - " + sumFrac);
            } else {
               
              Console.WriteLine("ERROR, Please enter at least with 3 digits after point ");
            }
          

            Console.ReadKey();
        }
    }
}


