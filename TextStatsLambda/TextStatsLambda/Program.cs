using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            textStats("Hello my name is Josh. I like to code a wholeeeee lot. SeedPaths is the greatest.");
            Console.ReadKey();
        }

        static void textStats(string input)
        {
            List<char> vowels = new List<char> {'a', 'e', 'i', 'o', 'u' };
            string consonant = "bcdfghjklmnpqrstvwxyz";
            consonant.Split(' ').ToList();
            List<char> specialCharacters = new List<char> {'?', '.', ',', '!'};
            Console.WriteLine("Input: {0}", input);
            Console.WriteLine("Number of characters: " + input.Length);
            Console.WriteLine("Number of words: " + input.Split(' ').ToList().Count());
            Console.WriteLine("Number of vowels: " + input.Count(x => vowels.Contains(char.ToLower(x))));
            Console.WriteLine("Number of consonants: " + input.Count(x => consonant.Contains(char.ToLower(x))));
            Console.WriteLine("Number of special characters: " + input.Split(' ').ToList().Count());
            Console.WriteLine("Longest word: " + input.Split(' ').ToList().OrderByDescending(x => x.Length).First());
            Console.WriteLine("Shortest word: " + input.Split(' ').ToList().OrderBy(x => x.Length).First());
        }
    }
}
