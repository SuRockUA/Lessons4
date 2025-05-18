using System;

namespace Lessons4_1;


class Program
{
    static void Main()
    {
        int[] numbers = new int[51]; 
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 2;
        }
        
        foreach (int number in numbers)
        {
            Console.WriteLine($"Element: {number}");
        }
    }
}
