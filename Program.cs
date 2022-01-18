using System;

namespace DataEncodingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];
            Console.WriteLine($"Loading '{filePath}'.");

            string message;
            message = System.IO.File.ReadAllText(filePath);
            Console.WriteLine($"The encrypted message is: {message}");



            int shift = 1;

            while (shift <= 10)
            {
                Cipher cipher;
                cipher = new Cipher(shift);
                string decrypt;
                decrypt = cipher.Decrypt(message);
                Console.WriteLine($"The decrypted message is: '{decrypt}'");
                shift = shift + 1;
            }




            // string message;
            // message = System.IO.File.ReadAllText("secrets/1.txt");
            // Console.WriteLine($"The encrypted message is: '{message}");



            // string encrypted;
            // encrypted = cipher.Encrypt("rosebud");
            // Console.WriteLine($"The encrypted message is: '{encrypted}'");

            // string decrypted;
            // decrypted = cipher.Decrypt(message);
            // Console.WriteLine($"The decrypted message is: '{decrypted}'");


        }
    }
}
