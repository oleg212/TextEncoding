using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncoding
{
    public abstract class TextEncryptor
    {
        public TextEncryptor() { }

        public abstract string Encrypt(string plainText, string key);
        public abstract string Decrypt(string encryptedText, string key);


    }
    public class VigenereCipher : TextEncryptor
    {
        public override string Encrypt(string plainText, string key)
        {
            string encryptedText = "";
            int len = plainText.Length;
            int key_ind = 0;
            int key_len = key.Length;
            for (int i = 0; i < len; i++)
            {
                char c = (char)(Convert.ToInt32(plainText[i]) + Convert.ToInt32(key[key_ind]));
                encryptedText += c;
                key_ind = (key_ind + 1) % key_len;

            }

            return encryptedText.ToString();
        }
        public override string Decrypt(string encryptedText, string key)
        {
            string decryptedText = "";
            int len = encryptedText.Length;
            int key_ind = 0;
            int key_len = key.Length;
            for (int i = 0; i < len; i++)
            {
                char c = (char)(Convert.ToInt32(encryptedText[i]) - Convert.ToInt32(key[key_ind]));
                decryptedText += c;
                key_ind = (key_ind + 1) % key_len;

            }

            return decryptedText.ToString();
        }
    }
    class VernamCipher : TextEncryptor
    {
        public override string Encrypt(string plainText, string key)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] encryptedBytes = new byte[plainBytes.Length];

            for (int i = 0; i < plainBytes.Length; i++)
            {
                encryptedBytes[i] = (byte)(plainBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return Convert.ToBase64String(encryptedBytes);
        }

        public override string Decrypt(string encryptedText, string key)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] decryptedBytes = new byte[encryptedBytes.Length];

            for (int i = 0; i < encryptedBytes.Length; i++)
            {
                decryptedBytes[i] = (byte)(encryptedBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }
    class TranspositionCipher : TextEncryptor
    {
        public override string Encrypt(string plainText, string key)
        {
            int int_key = Int32.Parse(key);
            int columns = int_key;
            int rows = (int)Math.Ceiling((double)plainText.Length / columns);

            char[,] grid = new char[rows, columns];
            int index = 0;

            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (index < plainText.Length)
                    {
                        grid[i, j] = plainText[index];
                        index++;
                    }
                    else
                    {
                        grid[i, j] = ' ';
                    }
                }
            }

            string encryptedText = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    encryptedText += grid[i, j];
                }
            }

            return encryptedText;
        }

        public override string Decrypt(string encryptedText, string key)
        {
            int int_key = Int32.Parse(key);
            int columns = int_key;
            int rows = (int)Math.Ceiling((double)encryptedText.Length / columns);

            char[,] grid = new char[rows, columns];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (index < encryptedText.Length)
                    {
                        grid[i, j] = encryptedText[index];
                        index++;
                    }
                    else
                    {
                        grid[i, j] = ' ';
                    }
                }
            }

            string decryptedText = "";
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    decryptedText += grid[i, j];
                }
            }

            return decryptedText;
        }
    }
}
