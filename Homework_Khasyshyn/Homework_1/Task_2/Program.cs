using System;

namespace Homework_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool incorrectEnteredNumber;
               
            do
            {
                incorrectEnteredNumber = false;
                Console.Write("Enter a double number:");
                string num = Console.ReadLine();
               
                if (num.IndexOf('.')!= -1)
                {
                    string numAfterDot = num.Split('.')[1];
                    if(numAfterDot.Length>1)

                    {
                        int digitAfterDot1 = int.Parse(numAfterDot.Substring(0, 2)[0].ToString());
                        int digitAfterDot2 = int.Parse(numAfterDot.Substring(0, 2)[1].ToString());

                        Console.Write(($" {digitAfterDot1} + {digitAfterDot2} " + $"= {digitAfterDot1 + digitAfterDot2}"));
                    }
                    else incorrectEnteredNumber = true;

                }
                else incorrectEnteredNumber = true;


            } while (incorrectEnteredNumber);

        }
            
    }
}
