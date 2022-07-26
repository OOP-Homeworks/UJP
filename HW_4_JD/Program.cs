using System;
using System.Collections.Generic;
using System.IO;
namespace Homework4
{
    //Task 7_2
    private void PrintDiscDInfo()
    {
        try
        {
            string path = @"D:\";
            string pathWrite = @"D:\\Info.txt";
            DirectoryInfo dir = new(path);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                using (StreamWriter sw = new(pathWrite, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(file.Name);
                    sw.WriteLine(file.CreationTime);
                    sw.WriteLine(file.Length);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    //Task 7_3
    private void PrintFromDiscDTXTFiles()
    {
        try
        {
            string path = @"D:\";
            DirectoryInfo dir = new(path);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Extension == ".txt")
                {
                    using (StreamReader sr = new(file.FullName, System.Text.Encoding.Default))
                    {
                        Console.WriteLine(file.Name + " content:");
                        Console.WriteLine(sr.ReadToEnd());
                    }
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

   internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            Console.WriteLine("------------Task7_2---------------");
            //Task 7_2
            Console.WriteLine("Write info about file in disc D");
            obj.PrintDiscDInfo();

            Console.WriteLine("------------Task7_3---------------");
            //Task 7_3
            Console.WriteLine("Finding .txt files in disc D and print content");
            obj.PrintFromDiscDTXTFiles();

            Console.WriteLine("--------------HW_4---------------");

            //HW_7
            string curDir = Environment.CurrentDirectory;
            string prjDir = Directory.GetParent(curDir).Parent.Parent.FullName;
            Console.WriteLine(prjDir);
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(Path.Join(prjDir, "dictionary.txt"), System.Text.Encoding.Default))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] personData = line.Split(' ');
                    PhoneBook.Add(personData[0], personData[1]);
                }
                reader.Close();
                using (StreamWriter writer = new StreamWriter(Path.Join(prjDir, "Phones.txt")))
                {
                    foreach (var ph in PhoneBook)
                    {
                        writer.WriteLine(ph.Key);
                    }
                }
                foreach (var ph in PhoneBook)
                {
                    Console.WriteLine(ph);
                }
                Console.Write("\nPlease, write person name : \n > ");
                string name = Convert.ToString(Console.ReadLine());
                string message = "Error, not exist person by given name!";
                foreach (var ph in PhoneBook)
                {
                    if (ph.Value == name)
                    {
                        message = ph.Key;
                        break;
                    }
                }
                Console.WriteLine(name + "- phone (" + message+ ")");
                Console.ReadKey();
            }

            string writePath = Path.Join(prjDir, "New.txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach (var ph in PhoneBook)
                    {
                        if (!ph.Key.StartsWith("+3"))
                        {
                            writer.WriteLine("+3" + ph.Key + " " + ph.Value);
                        }
                        else
                        {
                            writer.WriteLine(ph.Key + " " + ph.Value);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
