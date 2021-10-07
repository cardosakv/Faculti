using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Faculti.Helpers
{
    /// <summary>
    ///     Helper class for checking string syntaxes.
    /// </summary>
    internal class Syntax
    {
        /// <summary>
        ///     Checks syntax for input mobile number.
        /// </summary>
        /// 
        /// <param name="inputMobileNumber">
        ///     Mobile number to check syntax.
        /// </param>
        /// 
        /// <returns>
        ///     Boolean value if mobile number is in valid syntax or not.
        /// </returns>
        public static bool IsValidMobileNumber(string mobileNumber)
        {
            string strRegex = @"^((\\+91-?)|0)?[0-9]{11}$";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(mobileNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        ///     Checks syntax for input email.
        /// </summary>
        /// 
        /// <param name="email">
        ///     Email address to check syntax.
        /// </param>
        /// 
        /// <returns>
        ///     Boolean value if email is in valid syntax or not.
        /// </returns>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            try
            {
                // Normalize the domain.
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        ///     Check syntax for input password.
        /// </summary>
        /// 
        /// <param name="password">
        ///     Password in plain text to check.
        /// </param>
        /// 
        /// <returns>
        ///     Boolean value if password is in valid syntax or not.
        /// </returns>
        public static bool IsValidPassword(string password)
        {
            string strRegex = @"^[a-zA-Z0-9\s]{8,32}$";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}