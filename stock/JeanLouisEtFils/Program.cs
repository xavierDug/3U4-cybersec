// See https://aka.ms/new-console-template for more information
using Encryption.Blowfish;
using System.Security.Cryptography;
using JeanLouisEtFils;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BlowFishCrypto bfc = new BlowFishCrypto();
        string source = "super duper password 1! le plus dur à deviner du monde 1@4$";
        Console.WriteLine("Sym source   :" + source);
        string encrypted = bfc.Encrypt(source);
        Console.WriteLine("Sym encrypt  :" + encrypted);
        string decrypted = bfc.Decrypt(encrypted);
        Console.WriteLine("Sym decrypt  :" + decrypted);
        
        
        Console.WriteLine("------------------------------------------- Asym");
        var rsaCrypto = new RSACrypto();
        string originalData = source;
        Console.WriteLine("Asym Original Data: " + originalData);
        string encryptedData = rsaCrypto.Encrypt(originalData);
        Console.WriteLine("Asym Encrypted Data: " + encryptedData);
        string decryptedData = rsaCrypto.Decrypt(encryptedData);
        Console.WriteLine("Asym Decrypted Data: " + decryptedData);
    }
}