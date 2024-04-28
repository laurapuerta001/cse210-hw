using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int answer = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (answer != 0) {
            Console.Write("Enter a number: ");
            answer = int.Parse(Console.ReadLine());
            if (answer != 0) {
                numbers.Add(answer);
            }
        }
    
        Console.WriteLine("The total is: " + numbers.Sum());
        Console.WriteLine("The average is: " + (numbers.Sum() / numbers.Count).ToString());
        Console.WriteLine("The largest number is: " + numbers.Max());

    }
}