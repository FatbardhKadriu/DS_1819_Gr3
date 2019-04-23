using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

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

        static readonly string PDFFile = @"C:\Users\eduar\Desktop\FK\Semestri 4\Rrjetet Kompjuterike\pdfFile.pdf";

        public static string GetText(string filePath)
        {
            var sb = new StringBuilder();
            try
            {
                using (PdfReader reader = new PdfReader(filePath))
                {
                    string prevPage = "";
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        ITextExtractionStrategy its = new SimpleTextExtractionStrategy();
                        var s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                        if (prevPage != s) sb.Append(s);
                        prevPage = s;
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return sb.ToString();
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
            String ciphertext = Encrypt(plaintext, GetText(PDFFile));
            String plaintextAgain = Decrypt(ciphertext, GetText(PDFFile));
            Console.WriteLine("Clear Text : " + plaintext);
            Console.WriteLine("CipherText : " + ciphertext);
            Console.WriteLine("Clear Text Again : " + plaintextAgain);
            Console.ReadLine();
        }
    }
}
