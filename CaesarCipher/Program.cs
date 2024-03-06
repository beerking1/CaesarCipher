using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Caesar("Apple"));
            Console.ReadKey();
        }
        public static string Caesar(string word)
        {
            Console.Write("Enter a key: ");
            string key = Console.ReadLine();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string result = string.Empty;
            if (int.TryParse(key, out int resultKey))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    int shift = resultKey % 26; 
                    char currentChar = word[i];
                    if (char.IsLetter(currentChar))
                    {
                        char baseChar = char.IsUpper(currentChar) ? 'A' : 'a'; 
                        int charIndex = (currentChar - baseChar + shift) % 26;
                        if (charIndex < 0) 
                            charIndex += 26;
                        char newChar = (char)(baseChar + charIndex); 
                        result += newChar;
                    }
                    else
                    {
                        result += currentChar; 
                    }
                }
            }
            return result;
        }
    }
}
