using System;
using System.Text.RegularExpressions;

namespace Problem_3.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\w)+([\.\-\]w+)+([\w]+)@([\w\-\.]+)(([a-z]){2,3})";
            Match validEmail = Regex.Match(input, pattern);

            while (validEmail.Success)
            {
                Console.WriteLine(validEmail);
                validEmail = validEmail.NextMatch();
            }
        }
    }
}
