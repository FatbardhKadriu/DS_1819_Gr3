using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Testtt
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Original String: ");
                string originalString = Console.ReadLine();
                string cryptedString = DES.Encrypt(originalString);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEncrypted Result: {0}", cryptedString);
                Console.WriteLine("Decrypt Result: {0}", DES.Decrypt(cryptedString));
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("From: {0}.\nDetail: {1}", ex.Source, ex.Message);
               
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
