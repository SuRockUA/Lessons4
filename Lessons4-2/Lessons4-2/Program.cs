using System;
using System.Collections.Generic;

namespace Lessons4_2;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int arrayLength = 30; 

        int[] numbers = new int[arrayLength];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 101);
        }
        
        List<int> evenNumbers = new List<int>();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }
        
        Console.WriteLine($"Arrays include {evenNumbers.Count} pair numbers.");
        Console.WriteLine("It`s: " + string.Join(", ", evenNumbers));
    }
}
