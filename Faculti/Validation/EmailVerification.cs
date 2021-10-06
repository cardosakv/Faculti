using AirtableApiClient;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

namespace Faculti.Validation
{
    internal class EmailVerification
    {
        public static void SendEmailVerificationCode(string recepientEmail, int code)
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
                SmtpServer.Credentials = new System.Net.NetworkCredential("info.faculti", "faculti1234");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool IsEmailRegistered(string email, AirtableRecord[] records)
        {
            for (int recordNum = 0; recordNum < records.Length; recordNum++)
            {
                if (records[recordNum].Fields["Email"].ToString() == email)
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}