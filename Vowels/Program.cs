using System;

namespace Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sentence = new int [100];
 
            int i, vowels = 0, consonants = 0, special = 0, n;
            Console.WriteLine("Enter the Length of the sentence");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sentence");
            for (i = 0; i < n; i++)
            {
                sentence[i] = Convert.ToInt32(Console.Read());
            }
            for (i = 0; sentence[i] != '\0'; i++)
            {
                if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] ==
                'i' || sentence[i] == 'o' || sentence[i] == 'u') ||
                (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
                'I' || sentence[i] == 'O' || sentence[i] == 'U'))
                {
                    vowels = vowels + 1;
                }
                else
                {
                    consonants = consonants + 1;
                }
                if ( sentence[i] == '\0' || sentence[i] == ' ' || sentence[i] == 1 || sentence[i] == 0 || sentence[i] == 2 
                || sentence[i] == 3 || sentence[i] == 4 || sentence[i] == 5 || sentence[i] == 6 || sentence[i] == 7
                || sentence[i] == 8 || sentence[i] == 9)
                {
                    special = special + 1;
                }
            }
 
            consonants = consonants - special;
            Console.WriteLine("No. of vowels {0}", vowels);
            Console.WriteLine("No. of consonants {0}", consonants);
            
        }
    }
}
