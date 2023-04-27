using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }    
        }

        int total = 0;
        int largestNum = 0;
        int smallestPositiveNum = 9999;
    
        foreach (int num in numbers)
        {
            // sum total
            total += num;
            // determine the largest number in the list
            if (num > largestNum)
            {
                largestNum = num;
            }
            // determine smalles positive number in the list
            if (num > 0 && num < smallestPositiveNum)
            {
                smallestPositiveNum = num;
            }
        }
        Console.WriteLine($"The sum is: {total}");

        // calculate average number of the list
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largestNum}");

        Console.WriteLine($"The smallest positive number is: {smallestPositiveNum}");

        // sort the list and display the sorted list
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}