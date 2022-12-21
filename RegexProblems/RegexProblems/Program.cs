// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Email");
        var data = Console.ReadLine();
        string pattern = "^[0-9A-Za-z]+([.][0-9A-Za-z]+)[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})$";
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
