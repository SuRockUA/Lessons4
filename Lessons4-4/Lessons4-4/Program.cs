using System;

namespace Lessons4_4;

class Program
{
    static void Main()
    {
        char[] alphabet = new char[26];
        
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)('a' + i); 
        }
        
        foreach (char letter in alphabet)
        {
            int ascii = (int)letter;
            Console.WriteLine($"Letter: {letter}, ASCII code: {ascii}");
        }
    }
}
