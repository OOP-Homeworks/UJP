using System;
using System.Collections.Generic;
using System.IO;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string driveName = "D";
            DriveInfo driveInfo;
            string fileNamePattern = "*.txt";
            List<string> txtFilePaths = new List<string>();

            try
            {
                driveInfo = new DriveInfo(driveName);
                txtFilePaths.AddRange(
                    Directory.GetFiles(
                        driveInfo.RootDirectory.FullName,
                        fileNamePattern,
                        SearchOption.TopDirectoryOnly)
                );
                foreach (string filePath in txtFilePaths)
                {
                    Console.WriteLine(File.ReadAllText(filePath));
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}