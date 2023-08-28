using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;

namespace SecondTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            int vowels = 0;
            int consonants = 0;
            string input = "HEllo world";
            string lowLetter = input.ToLower();
            char[] vowelsChar = { 'a', 'e', 'i', 'o', 'u' };
          
            foreach(char c in lowLetter)
            {
                if (char.IsLetter(c))
                {

                    if ("aeiou".Contains(c))
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }
            Console.WriteLine($"You have {vowels} vowels and {consonants} consonants in your word.") ;
        }
    }
}