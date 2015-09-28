using System;
using System.Text.RegularExpressions;

namespace Problem_4.Sentence_Extractor
{
    class Program
    {
        static void Main()
        {
            string keyword = String.Format(@"\b{0}\b", Console.ReadLine());
            string text = Console.ReadLine();
            string[] splittedText = Regex.Split(text, @"(?<=[.!?])");

            for (int i = 0; i < splittedText.Length; i++)
            {
                if (Regex.IsMatch(splittedText[i], @"[!.?]$") && Regex.IsMatch(splittedText[i], keyword))
                {
                    Console.WriteLine(splittedText[i].Trim());
                }
            }
        }
    }
}
