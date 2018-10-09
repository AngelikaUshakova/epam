using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "<h3 style=''><p>Привет<p><h3> Как дела";

            string pattern = "<[^<>]*>";
            str =  Regex.Replace(str, pattern, "_");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
