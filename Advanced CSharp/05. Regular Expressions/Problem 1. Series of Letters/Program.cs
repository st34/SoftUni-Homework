using System;
using System.Text.RegularExpressions;

namespace Problem_1.Series_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<letter>\w)\<letter>+";
            string replacement = "${letter}";
            string replaced = Regex.Replace(input, pattern, replacement);
            Console.WriteLine(replaced);		
        }
    }
}
