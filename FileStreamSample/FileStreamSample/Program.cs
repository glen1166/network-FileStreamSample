using System;
using System.IO;
using System.Text;

namespace FileStreamSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadCharacters();
        }

        static async void ReadCharacters()
        {
            StringBuilder stringToRead = new StringBuilder();
            stringToRead.AppendLine("Characters in 1st line to read");
            stringToRead.AppendLine("and 2nd line");
            stringToRead.AppendLine("and the end");

            using (StringReader reader = new StringReader(stringToRead.ToString()))
            {
                string readText = await reader.ReadToEndAsync();
                Console.WriteLine(readText);
            }
        }
    }
}
