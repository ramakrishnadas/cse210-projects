using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        // ask user for grade percentage
        Console.Write("Please enter your grade percentage: ");
        string userPercentage = Console.ReadLine();

        // convert grade percentage entered by user into an integer and determine the corresponding letter (A, B, C, D, or F)
        int gradePercentage = int.Parse(userPercentage);
        string letter = "A";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
        }

        // calculate remainder of grade percentage and determine the corresponding sign of the letter grade
        // "+" if equal to or greater than 7 and "-" if below 3. Otherwise, there is no sign.
        int remainder = gradePercentage % 10;
        string sign = "";
        if (remainder >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (remainder < 3 && letter != "F")
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // print letter grade and sign
        Console.WriteLine($"Your letter grade is {letter}{sign}");

        // determine whether the user passed the course or not and print the corresponding message.
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You didn't pass the course. Good luck next time!");
        }
    }
}