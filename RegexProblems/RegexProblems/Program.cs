// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Phone Number");
        var data = Console.ReadLine();
        string pattern = "^[6-9]{1}[0-9]{8}$";
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
