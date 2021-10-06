﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Faculti.Misc
{
    internal class SyntaxValidation
    {
        public static bool IsValidMobileNumber(string inputMobileNumber)
        {
            string strRegex = @"^((\\+91-?)|0)?[0-9]{11}$";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

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
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
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

        public static bool IsValidPassword(string inputPassword)
        {
            string strRegex = @"^[a-zA-Z0-9\s]{8,32}$";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(inputPassword))
                return (true);
            else
                return (false);
        }
    }
}