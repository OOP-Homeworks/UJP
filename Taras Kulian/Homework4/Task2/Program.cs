using System.IO;

//In Main() method declare Dictionary PhoneBook for keeping pairs
//PersonName-PhoneNumber.
//From file "phones.txt" read 9 pairs into PhoneBook.
//Write only PhoneNumbers into file "Phones.txt".
//Find and print phone number by the given name (name input from console)
//Change all phone numbers, which are in format 80#########
//into new format +380#########.
//The result write into file "New.txt"


namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dirPath = @"D:Projects\Homeworks\Homework4\testDirectory";
            string sourseFile = dirPath + @"\phones.txt";
            string phonesFile = dirPath + @"\onlyPhones.txt";
            string newPhonesFile = dirPath+ @"\newPhones.txt";

            string nameStrStart = "name: ";
            string nameStrEnd = ",";
            string phoneStrStart = "phone: ";
            string phoneStrEnd = ";";

            Dictionary<string, string> phoneBook = new();

            try
            {
                // Comment if u don't want to create directory automatically
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                // Comment if u don't want to create file automatically
                if (!File.Exists(sourseFile))
                {
                    File.Create(sourseFile);
                }

                using (var sr = new StreamReader(sourseFile))
                {
                    string? strSource;
                    while ((strSource = sr.ReadLine()) != null)
                    {

                        if (strSource.Contains(nameStrStart) &&
                            strSource.Contains(nameStrEnd) &&
                            strSource.Contains(phoneStrStart) &&
                            strSource.Contains(phoneStrEnd))
                        {
                            int nameStart, nameEnd, phoneStart, phoneEnd;
                            nameStart = strSource.IndexOf(nameStrStart, 0) + 
                                nameStrStart.Length;
                            nameEnd = strSource.IndexOf(nameStrEnd, nameStart);
                            phoneStart = strSource.IndexOf(phoneStrStart, 0) + 
                                phoneStrStart.Length;
                            phoneEnd = strSource.IndexOf(phoneStrEnd, phoneStart);
                            phoneBook.Add(strSource[nameStart..nameEnd], 
                                strSource[phoneStart..phoneEnd]);
                        }
                    }
                }

                // Comment if u don't want to create file automatically
                if (!File.Exists(phonesFile))
                {
                    File.Create(phonesFile);
                }

                using (var sw = new StreamWriter(phonesFile, false))
                {
                    foreach (KeyValuePair<string, string> phone in phoneBook)
                    {
                        sw.WriteLine($"phone: {phone.Value};");
                    }
                }

                Console.WriteLine("Enter the name of user to get phone number:");
                string? inputName = Console.ReadLine();
                if (!phoneBook.TryGetValue(inputName, out string? outputPhone))
                {
                    Console.WriteLine("There is no any user with that name! :c");
                } else
                {
                    Console.WriteLine($"The phone of {inputName} is {outputPhone}.");
                }

                // Comment if u don't want to create file automatically
                if (!File.Exists(newPhonesFile))
                {
                    File.Create(newPhonesFile);
                }

                using (var sw = new StreamWriter(newPhonesFile, false))
                {
                    string newPhone;
                    foreach (KeyValuePair<string, string> phone in phoneBook)
                    {
                        if (phone.Value.StartsWith("80"))
                        {
                            newPhone = "+3" + phone.Value;
                        }
                        else newPhone = phone.Value;
                        sw.WriteLine($"phone: {newPhone};");
                    }
                }

            }

            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine(dnfe.Message);
            }

            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }

            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }

            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}