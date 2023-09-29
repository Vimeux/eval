using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string to convert to upper case:");
        string stringInput = Console.ReadLine();
        Console.WriteLine(ConvertToUpper(stringInput));
    }

    public static string ConvertToUpper(string text)
    {
        return text.ToUpper();
    }
}