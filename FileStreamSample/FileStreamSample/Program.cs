using System;
using System.IO;
using System.Text;

namespace FileStreamSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadText();
        }

        async static void ReadText()
        {
            string filename = @"E:\temp\test.txt";
            char[] result;
            StringBuilder builder = new StringBuilder();

            using (StreamReader reader = File.OpenText(filename))
            {
                result = new char[reader.BaseStream.Length];
                await reader.ReadAsync(result, 0, (int)reader.BaseStream.Length);
            }

            foreach (char c in result)
            {
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                {
                    builder.Append(c);
                }
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
