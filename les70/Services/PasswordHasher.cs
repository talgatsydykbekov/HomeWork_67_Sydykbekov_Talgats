using System;
using System.Security.Cryptography;
using System.Text;

namespace WebApplication3.Services
{
    public class PasswordHasher
    {
        /// <summary>
        /// Метод принимает в себя пароль, после чего производит его хеширование в MD5
        /// </summary>
        /// <param name="password"></param>
        public byte[] Md5HashPassword(string password)
        {
            
            return new byte[16]; 
        }
        /// <summary>
        /// Метод принимает в себя MD5 hash (массив байт)
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>Возвращается значение хэша в hexCode</returns>
        public string ToHex(byte[] bytes)
        {
           // byte[] byteArray = Encoding.UTF8.GetBytes("Hello World");

            // Convert byte array to string
            string result = BytesToString(bytes, Encoding.UTF8);
           // string? result = Encoding.Default.GetString(bytes);
            return result;
        }
        static string BytesToString(byte[] bytes, Encoding encoding)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes), "Byte array cannot be null.");

            if (encoding == null)
                throw new ArgumentNullException(nameof(encoding), "Encoding cannot be null.");

            return encoding.GetString(bytes);
        }
    }
}