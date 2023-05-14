using System;

public class Entry 
// Responsibility: 
// * to hold and display entries in the correct format.
{
    public string _date = "";
    public  string _prompt = "";
	public string _message = "";

    public Entry()
    {
    }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt} - Answer: {_message}");
    }
}