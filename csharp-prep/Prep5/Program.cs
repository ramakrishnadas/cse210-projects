using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);

        DisplayResult(username, squaredNumber); 
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;

        return squaredNumber;
    }
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}