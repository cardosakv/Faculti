using Faculti.Services.FacultiDB;
using System;
using System.Data;
using System.Net.Mail;

namespace Faculti.Helpers
{
    /// <summary>
    ///     Helper class for emails.
    /// </summary>
    internal class Email
    {
        /// <summary>
        ///     Sends verification code to the specified recepient email using Faculti credentials.
        /// </summary>
        ///
        /// <param name="recepientEmail">
        ///     Recepient email address to send the code to.
        /// </param>
        ///
        /// <param name="code">
        ///     Four digit randomly generated code.
        /// </param>
        public static void SendVerificationCode(string recepientEmail, int code)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("info.faculti@gmail.com");
                mail.To.Add(recepientEmail);
                mail.Subject = "Faculti Confirmation Code";
                mail.Body = "Your Faculti account confirmation code is: " + code + ".";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("", "");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        /// <summary>
        ///     Checks if email is present in the specified AirtableRecord array.
        /// </summary>
        ///
        /// <param name="email">
        ///     Email to check.
        /// </param>
        ///
        /// <param name="records">
        ///     Array of type AirtableRecord to scan.
        /// </param>
        ///
        /// <returns>
        ///     Boolean value if email is present or not.
        /// </returns>
        public static bool IsPresentInDatabase(string email, string userType)
        {
            DatabaseClient client = new DatabaseClient();
            var records = client.ListColumn(userType, "email");

            foreach (DataRow row in records.Rows)
            {
                if (row["email"].ToString() == email)
                    return true;
            }

            return false;
        }
    }
}
