using System.IO;

//Select from directory D only .txt files and print the text from it into console.
//Catch appropriative exceptions.

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fileType = ".txt";
            string dirPath = @"D:Projects\Homeworks\Homework4\testDirectory";
            string[] filePaths =
                {
                    dirPath + @"\file1.txt",
                    dirPath + @"\file2.json",
                    dirPath + @"\file3.txt"
                };

            try
            {

                // Comment if u don't want to create directory automatically
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                // Comment if u don't want to create files automatically
                foreach (string file in filePaths)
                {
                    if (!File.Exists(file))
                    {
                        File.Create(file);
                    }
                }

                if (Directory.Exists(dirPath))
                {
                    string[] files = Directory.GetFiles(dirPath);
                    foreach (string file in files)
                    {
                        if (Path.GetExtension(file) == fileType)
                        {
                            Console.WriteLine($"File {Path.GetFileName(file)}");
                            using (StreamReader sr = new StreamReader(file))
                            {
                                Console.WriteLine(sr.ReadToEnd());
                            }
                        }
                    }
                }
                else Console.WriteLine("Directory doesn't exist! :c");
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