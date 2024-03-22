using Typin.Attributes;
using Typin.Console;
using Typin;
using Microsoft.Extensions.DependencyInjection;
using Typin.Directives;
using Typin.Modes;
using Sharprompt;

// https://github.com/shibayan/Sharprompt for the win
namespace consoleApp;

class Program
{

   
    public static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(DataSec.CreateMD5("Hello, World!"));
        Console.WriteLine(DataSec.CreateSHA256("Hello, World!"));
        string encrypted = DataSec.Encrypt("123456789");
        Console.WriteLine(encrypted);
        Console.WriteLine(DataSec.Decrypt(encrypted));
        var name = Prompt.Input<string>("What's your name?");
        var number = Prompt.Input<int>("Enter any number");
        Console.WriteLine($"{name} {number}");

    }    
}
