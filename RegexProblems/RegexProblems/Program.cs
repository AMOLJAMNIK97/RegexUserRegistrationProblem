﻿// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Name");
        var data = Console.ReadLine();
        string pattern = "^[A-Z]{1}[a-z]{2,}";
        Regex regex = new Regex(pattern);

        if(regex.IsMatch(data))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(data + " is Valid");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(data + " is Not Valid");
            Console.ResetColor();
        }
    }
}
