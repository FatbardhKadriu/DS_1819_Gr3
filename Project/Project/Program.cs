using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookCipher
{   
    class Program
    {
        //Fajlli
        static readonly string textFile = @"C:\Users\Bardhi\Desktop\libri\bardhi.txt";

        public static string readFile(string textFile)
        {
            if(File.Exists(textFile))
            {
                string txt = File.ReadAllText(textFile);
                return txt;
            }
            return "Fajlli nuk ekziston\n";
        }
        static string Encrypt(string plaintext, string book)
        {
            string[] wordArray = book.Split(' ');
            string[] plainTextArray = plaintext.Split(' ');
            string cipherText = "";
            for (int i = 0; i < plainTextArray.Length; i++)
            {
                string word = plainTextArray[i];
                int index = Array.IndexOf(wordArray, word);
                if (index < 0)
                {
                    throw new Exception();
                }

                cipherText += index + 1;
                cipherText += " ";
            }

            return cipherText.TrimEnd();
        }
        static string Decrypt(string ciphertext, string book)
        {
            int[] indexes = ciphertext
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n) - 1)
                .ToArray();

            string plaintext = "";
            string[] wordArray = book.Split(' ');
            foreach (int index in indexes)
            {
                plaintext += wordArray[index] + " ";
            }

            return plaintext.TrimEnd();
        }
        static void Main(string[] args)
        {
            Console.Write("Plaintext : ");
            String plaintext = Console.ReadLine();
            String ciphertext = Encrypt(plaintext, readFile(textFile));
            String plaintextAgain = Decrypt(ciphertext, readFile(textFile));
            Console.WriteLine("Clear Text : " + plaintext);
            Console.WriteLine("CipherText : " + ciphertext);
            Console.WriteLine("Clear Text Again : " + plaintextAgain); 
        }
    }
}
