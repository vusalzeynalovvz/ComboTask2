using System;
public class Program
{
    public static void Main()
    {
        string str;
        int i;
        int len;
        int vowel;
        int cons;
        Console.Write("Input the string : ");
        str = Console.ReadLine();

        vowel = 0;
        cons = 0;
        len = str.Length;

        for (i = 0; i < len; i++)
        {

            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
            {
                vowel++;
            }
            else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
            {
                cons++;
            }
        }
        Console.Write("Total number of vowels : {0}\n", vowel);
        Console.Write("Total number of constant : {0}\n\n", cons);
    }
}




//2) Write a C# Sharp program to count the number of vowels (sait) or consonants (samit) in a string.
