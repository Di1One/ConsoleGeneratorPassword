using System.Security.Cryptography;

namespace ConsoleGeneratorPassword
{
    internal class Program
    {
        public static string GetRandomPassword(int length)
        {
            byte[] rgb = new byte[length];

            RNGCryptoServiceProvider rngCrypt = new RNGCryptoServiceProvider();
            rngCrypt.GetBytes(rgb);

            return Convert.ToBase64String(rgb);
        }
        static void Main(string[] args)
        {
            bool endPoint = true;

            do
            {
                Console.Write("Enter a leanght of password: ");
                bool succsessParseOfString = int.TryParse(Console.ReadLine(), out int lengthOfPassword);

                if (succsessParseOfString && lengthOfPassword > 8)
                {
                    string password = GetRandomPassword(lengthOfPassword);
                    endPoint = false;
                    Console.WriteLine(password);
                }
                else
                {
                    Console.WriteLine("Invalid input... " +
                        "\nPlease enter an Integer number and make sure it is greater than 8");
                }

            } while (endPoint);
        }
    }
}