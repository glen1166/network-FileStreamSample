using System;
using System.IO;
using System.Text;

namespace FileStreamSample
{
    class Program
    {
        const string fileName = @"E:\temp\test.txt";
        const string desFileName = @"E:\temp\test-des.txt";

        static void Main(string[] args)
        {
            // Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader(desFileName))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);  
                }
            }
        }
    }
}
