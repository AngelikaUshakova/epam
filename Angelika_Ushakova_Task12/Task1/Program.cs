using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\disposable_task_file.txt";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            string str = "\n" + Fill(path) + "\r\n";
            MatchCollection numbers = FindNumbers(str);
            str = Square(str, numbers);

            WriteFile(path, str);

            Console.WriteLine("Finish");
            Console.ReadKey();
        }

        private static void WriteFile(string path, string str)
        {
            using (StreamWriter file = new StreamWriter(path))
            {
                file.Write(str);
            }
        }

        private static MatchCollection FindNumbers(string str)
        {
            string pattern = @"[0-9]+";
            MatchCollection numbers = Regex.Matches(str, pattern);

            if (numbers.Count == 0)
            {
                throw new Exception("No numbers in file");
            }

            return numbers;
        }

        private static string Fill(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                return file.ReadToEnd();
            }
        }

        private static string Square(string str, MatchCollection numbers)
        {
            foreach (Match number in numbers)
            {
                int squareOfNumber = int.Parse(number.Value) * int.Parse(number.Value);
                string pattern = $"(\n{number.Value}\r)";

                str = Regex.Replace(str,pattern,$"{squareOfNumber.ToString()}\0\r\n");
            }

            str = Regex.Replace(str, "\0", "");
            str = str.Remove(str.Length - 3);

            return str;
        }
    }
}
