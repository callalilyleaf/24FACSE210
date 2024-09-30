using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    List<int> numbers = new List<int>();
    int input_num = -1;

    Console.WriteLine("Enter a list of numbers, type 0 when finished.");

    while (input_num != 0)
    {
        Console.WriteLine("Enter number: ");
        string str_num = Console.ReadLine();
        input_num = int.Parse(str_num);
        numbers.Add(input_num);
    }
    
    int sum = numbers.Sum();
    float avg = ((float)sum)/ numbers.Count();
    int max = numbers.Max();
    Console.WriteLine($"The sum is: {sum}");
    Console.WriteLine($"The average is: {avg}");
    Console.WriteLine($"The largest number is: {max}");







    }
}