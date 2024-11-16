// See https://aka.ms/new-console-template for more information
using Encryption.Blowfish;
using System.Security.Cryptography;
using JeanLouisEtFils;

class Program
{
    static void Main(string[] args)
    {
        // ask the user the path for the file
        Console.WriteLine("Enter the path of the file to encrypt:");
        string path = Console.ReadLine();
        // read the file into a string array with one line per element
        string[] lines = System.IO.File.ReadAllLines(path);
        // for each line, 
        foreach (string line in lines)
        {
            // encrypt the line
            BlowFishCrypto bfc = new BlowFishCrypto();
            // split the line with " @ " 
            
            string first = line.Split(" @ ")[0];
            string decrypted = bfc.Decrypt(first);
            // write the encrypted line to the console
            Console.WriteLine(decrypted + " @ " + line.Split(" @ ")[1]);
        }
        
    }
}