// https://crackstation.net/
// https://www.mscs.dal.ca/~selinger/md5collision/
namespace consoleApp
{
    class DataSec
    {
        public static string Encrypt(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                //Console.WriteLine(c);
                // get the character with code that doubles ascii code of current char
                char t = (char)(c * 2);
                //Console.WriteLine(t);
                result += t;
            }
            return result;
        }

        public static string Decrypt(string input)
        {
            string result = "";
            foreach (char c in input)
            {
                //Console.WriteLine(c);
                // get the character with code that doubles ascii code of current char
                char t = (char)(c / 2);
                //Console.WriteLine(t);
                result += t;
            }
            return result;
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return Convert.ToHexString(hashBytes); // .NET 5 +
            }
        }

        //SHA3_256 

        public static string CreateSHA256(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.SHA256 md5 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return Convert.ToHexString(hashBytes); // .NET 5 +
            }
        }


    }
}
