using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Faculti.Helpers
{
    /// <summary>
    ///     Helper class for passwords.
    /// </summary>
    internal class Password
    {
        #region Secret

        private const string _securityKey = "992fbd43528da0e45687230ff8acd9ed8ade0125";

        #endregion Secret

        /// <summary>
        ///     Checks if input password is correct matching the email in the AirtableRecord array.
        /// </summary>
        ///
        /// <param name="email">
        ///     Email address of the user.
        /// </param>
        ///
        /// <param name="passwordInHash">
        ///     Password of the email to check.
        /// </param>
        ///
        /// <returns>
        ///     Boolean value if password matched that in the database or not.
        /// </returns>
        public static bool IsCorrect(string userType, string email, string passwordInHash)
        {
            DatabaseClient client = new DatabaseClient();
            var cmdText = $@"select * from {userType} where email = '{email}' and password_in_hash = '{passwordInHash}'";

            try
            {
                OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
                if (cmd.ExecuteScalar() != null)
                {
                    return true;
                }
                client.Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Password.IsCorrect()");
            }
            
            return false;
        }

        /// <summary>
        ///    Converts the encrypted/unreadable password back to plain text.
        /// </summary>
        ///
        /// <param name="passwordInCipherText">
        ///     Password string in cipher text.
        /// </param>
        ///
        /// <returns>
        ///     Decrypted password string in plain text.
        /// </returns>
        public static string Decrypt(string passwordInCipherText)
        {
            byte[] toEncryptArray = Convert.FromBase64String(passwordInCipherText);

            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
            byte[] securityKeyArray = objMD5CryptoService.ComputeHash(Encoding.UTF8.GetBytes(_securityKey));
            objMD5CryptoService.Clear();

            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider
            {
                Key = securityKeyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            var objCrytpoTransform = objTripleDESCryptoService.CreateDecryptor();
            byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            objTripleDESCryptoService.Clear();

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        ///     Converts the password to encrypted/cipher text.
        /// </summary>
        ///
        /// <param name="passwordInPlainText">
        ///     Password string in plain text.
        /// </param>
        ///
        /// <returns>
        ///     Encrypted password string in cipher text.
        /// </returns>
        public static string Encrypt(string passwordInPlainText)
        {
            byte[] toEncryptedArray = Encoding.UTF8.GetBytes(passwordInPlainText);

            MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
            byte[] securityKeyArray = objMD5CryptoService.ComputeHash(Encoding.UTF8.GetBytes(_securityKey));
            objMD5CryptoService.Clear();

            var objTripleDESCryptoService = new TripleDESCryptoServiceProvider
            {
                Key = securityKeyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor();
            byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptedArray, 0, toEncryptedArray.Length);
            objTripleDESCryptoService.Clear();

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
    }
}