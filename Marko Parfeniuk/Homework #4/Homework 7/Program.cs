using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string readPath = @"../../../phones (read).txt";
            string writePath = @"../../../Phones (write).txt";
            string newFormatPath = @"../../../New1.txt";
            string line, name, phoneNumber;
            int numberOfReadContacts = 0, numberOfContactsToRead = 9, separatorPosition;
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            Dictionary<string, string> contactsToUpdate = new Dictionary<string, string>();

            try
            {
                using (StreamReader sr = new StreamReader(readPath))
                using (StreamWriter sw = new StreamWriter(writePath))
                {
                    do
                    {
                        line = sr.ReadLine();
                        separatorPosition = line.LastIndexOf('-');
                        name = line.Substring(0, separatorPosition);
                        phoneNumber = line.Substring(separatorPosition + 1);
                        ++numberOfReadContacts;
                        phoneBook.Add(name, phoneNumber);
                        sw.WriteLine(phoneNumber);
                    } while (numberOfReadContacts < numberOfContactsToRead && !sr.EndOfStream);
                }

                Console.Write("Enter the contact name to find it's number:\n" +
                    "name >> ");
                name = Console.ReadLine();
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine($"{name}'s number: {phoneBook[name]}");
                }
                else
                {
                    Console.WriteLine($"No contact with {name} name");
                }

                contactsToUpdate = phoneBook
                    .Where(i => Regex.Match(i.Value, @"^80[0-9]{8}").Success)
                    .ToDictionary(j => j.Key, j => j.Value.Insert(0, "+3"));
                foreach (var contactToUpdate in contactsToUpdate)
                {
                    phoneBook[contactToUpdate.Key] = contactToUpdate.Value;
                }
                using (StreamWriter sw = new StreamWriter(newFormatPath))
                {
                    foreach (var contact in phoneBook)
                    {
                        sw.WriteLine($"{contact.Key}-{contact.Value}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}