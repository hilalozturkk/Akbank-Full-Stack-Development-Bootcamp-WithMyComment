using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod.Extensions
{//Extension methods must be under static class 
    public static class MathExtension
    {
        public static int Square(this int number)
        {
            return (int)Math.Pow(number, 2);
        }
    }

    public static class WordExtension
    {
        public static string RandomLetter(this Random random)
        {
            int asciiNumber = random.Next(65, 91);
            string result = ((char)asciiNumber).ToString();
            return result;
        }

        public static string RandomWord(this Random random, int wordLenght)
         {
            string randomWord = string.Empty;
            while (randomWord.Length < wordLenght)
            {
                randomWord += random.RandomLetter();
            }
            return randomWord;
        }

    }
}
    






