using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;//vyn per me lexu te fajlli .txt



namespace BookCipher
{
    public partial class Form1 : Form
    {
        private string bookCipherPDFFileName { get; set; }
        private string plainTexti { get; set; }
        private string EncryptedTexti { get; set; }
        private string DecryptedTexti { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.SecureData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBookCipher.Text = openFileDialog1.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string GetText(string filePath)
        {
            /*Nese deshirojme ta marrim permbajtjen prej nje fajlli .txt 
            static readonly string textFile = @"C:\Users\Bardhi\Desktop\libri\bardhi.txt";
            public static string readFile(string textFile)
            {
                if (File.Exists(textFile))
                {
                    string txt = File.ReadAllText(textFile);
                    return txt;
                }
                return "Fajlli nuk ekziston\n";
            }*/
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
        private string Encrypt(string plaintext, string book)
        {
            string[] wordArray = book.Split(' ');
            string[] plainTextArray = plaintext.Split(' ');
            string cipherText = "";
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ky tekst nuk mund të enkriptohet!\nJu lutem provoni një tekst tjetër.", "Vërejtje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return cipherText.TrimEnd();
        }
        private string Decrypt(string ciphertext, string book)
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

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            plainTexti = txtPlainText.Text.TrimEnd();
            bookCipherPDFFileName = txtBookCipher.Text.TrimEnd();
            EncryptedTexti = Encrypt(plainTexti, GetText(bookCipherPDFFileName));
            txtEncryptedText.Text = EncryptedTexti;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            DecryptedTexti = Decrypt(EncryptedTexti, GetText(bookCipherPDFFileName));
            txtDecryptedText.Text = DecryptedTexti;
        }

        private void TxtBookCipher_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPlainText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblBookCipher_Click(object sender, EventArgs e)
        {

        }
    }
}
