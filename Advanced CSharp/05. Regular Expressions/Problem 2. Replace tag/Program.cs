using System;
using System.Text.RegularExpressions;

namespace Problem_2.Replace_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "<ul> <li> <a href='http://softuni.bg'>SoftUni</a> </li> </ul>";
            string pattern = @"<a\shref=\W(?<link>[^>]*)\W>(?<name>[^<]*)</a>";
            string replacement = "[URL href=${link}]${name}[/URL]";
            string replaced = Regex.Replace(input, pattern, replacement);
			Console.WriteLine(replaced);
        }
    }
}
