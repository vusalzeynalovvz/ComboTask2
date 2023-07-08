using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "CodeAcademy is a good place to study";
            int count = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ' && Char.IsLetter(sentence[i + 1]) && (i > 0))
                {
                    count++;
                }
            }
            count++;
            Console.WriteLine("Total number of words in the string is:" + count);
        }
    }
}

