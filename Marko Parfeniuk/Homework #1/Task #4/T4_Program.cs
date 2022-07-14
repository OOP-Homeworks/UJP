using System;

namespace Task_4
{
    enum HTTPError { Bad_Request = 400, Unauthorized, Payment_Required, Forbidden, Not_Found, Method_Not_Allowed, Gone = 410 }

    public static class FeatureMessages
    {
        public const string UndefindedErrorCodeError =
            @"You've just entered an undefined error code. Please, try again";
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool isSessionActive = true;

            do
            {
                Console.Write("Enter an error code:\n" +
                    "code >> ");
                if (Enum.TryParse<HTTPError>(Console.ReadLine(), out var inputErrorCode))
                {
                    switch (inputErrorCode)
                    {
                        case HTTPError.Bad_Request:
                            Console.WriteLine("Bad Request");
                            break;
                        case HTTPError.Forbidden:
                            Console.WriteLine("Forbidden");
                            break;
                        case HTTPError.Method_Not_Allowed:
                            Console.WriteLine("Method Not Allowed");
                            break;
                        case HTTPError.Not_Found:
                            Console.WriteLine("Not Found");
                            break;
                        case HTTPError.Payment_Required:
                            Console.WriteLine("Payment Required");
                            break;
                        case HTTPError.Unauthorized:
                            Console.WriteLine("Unauthorized");
                            break;
                        case HTTPError.Gone:
                            Console.WriteLine("Gone");
                            break;
                        default:
                            Console.WriteLine(FeatureMessages.UndefindedErrorCodeError);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(FeatureMessages.UndefindedErrorCodeError);
                }

                Console.Write("Continue? (Y/N) >> ");
                isSessionActive = Console.ReadLine() == "Y";

            } while (isSessionActive);

        }
    }
}