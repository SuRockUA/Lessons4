using System;

namespace Lessons4_3;

class Program
{
    static void Main()
    {
        Console.Write("Write text: ");
        string inputText = Console.ReadLine();
        
        int length = inputText.Length;
        Console.WriteLine($"Text \"{inputText}\" include: {length} symbols");
        
        Console.Write("Which character do you want to find? ");
        string searchChar = Console.ReadLine();

        if (string.IsNullOrEmpty(searchChar) || searchChar.Length != 1)
        {
            Console.WriteLine("You must enter a single character.");
            return;
        }

        char target = char.ToLower(searchChar[0]);
        int count = 0;
        
        foreach (char c in inputText)
        {
            if (char.ToLower(c) == target)
            {
                count++;
            }
        }

        Console.WriteLine($"Symbol '{searchChar}' found {count} time(s) in the text.");
    }
}
