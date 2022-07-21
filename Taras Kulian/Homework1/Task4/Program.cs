namespace Task4
{
    enum HTTPError
    {
        Bad_Request = 400, Unauthorized, Payment_Required, Forbidden,
        Not_Found, Method_Not_Allowed, Not_Acceptable, Proxy_Authentication_Required,
        Request_Timeout, Conflict, Gone, Length_Required, Precondition_Failed,
        Payload_Too_Large, URI_Too_Long, Unsupported_Media_Type, Range_Not_Satisfiable,
        Expectation_Failed, Im_a_Teapot, Misdirected_Request = 421,
        Unprocessable_Entity, Locked, Failed_Dependency, Too_Early, Upgrade_Required,
        Precondition_Required = 428, Too_Many_Requests,
        Request_Header_Fields_Too_Large = 431, Unavailable_For_Legal_Reasons = 451
    }
    class Program
    {

        static void Main(string[] args)
        {
            bool isInputCorrect;
            int counter = 1;
            string inputCode = string.Empty;
            HTTPError outputError = HTTPError.Gone;
            Console.WriteLine("Here are the codes you can find out more about:\n");
            foreach (int code in Enum.GetValues(typeof(HTTPError))) {
                if (counter == 10)
                {
                    Console.Write("\n");
                    counter = 1;
                }
                Console.Write($"{code} ");
                counter++;
            }
            
            do
            {
                Console.WriteLine("\n\nPlease, enter the code:");
                inputCode = Console.ReadLine();
                isInputCorrect = Enum.TryParse<HTTPError>(inputCode, 
                    out HTTPError result);
                if (isInputCorrect)
                {
                    
                    outputError = result;
                } else
                {
                    Console.WriteLine("Incorrect value! :c");
                }
            } while (!isInputCorrect);

            isInputCorrect = false;
            foreach (int code in Enum.GetValues(typeof(HTTPError)))
            {
                if (code == int.Parse(inputCode))
                {
                    isInputCorrect = true;
                    break;
                }
            }

            if(isInputCorrect)
            {
                Console.WriteLine($"The meaning of your status code: {outputError}");
            } else
            {
                Console.WriteLine("Seem's like I have no info about this code! :c");
            }

                
        }
    }
}