using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> wordsSet = new HashSet<string>();
            string text = "Hi, how are you. are you are";
           
            string[] words = Regex.Split(text, @"[\W]+");
            for(int i = 0; i < words.Length; i++)
            {
                wordsSet.Add(words[i].ToLower());
            }

            List<KeyValuePair<string, float>> wordsCount = new List<KeyValuePair<string, float>>();
            foreach ( string word in wordsSet)
            {
                wordsCount.Add(new KeyValuePair<string, float>(word, Regex.Split(text.ToLower(), word).Count()-1)); 
            }
            for (int i = 0; i < wordsCount.Count; i++)
            {
                Console.WriteLine($"{wordsCount[i].Key}  { wordsCount[i].Value / words.Count():0.00}");
            }
            
            Console.ReadKey();
        }
    }
}
