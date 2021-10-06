using AirtableApiClient;
using System.Collections.Generic;

namespace Faculti.Security
{
    internal class PasswordChecker
    {
        public static bool IsPasswordCorrect(string email, string passwordInHash, AirtableRecord[] records)
        {
            for (int recordNum = 0; recordNum < records.Length; recordNum++)
            {
                if (records[recordNum].Fields["Email"].ToString() == email &&
                    records[recordNum].Fields["Password"].ToString() == passwordInHash)
                {
                    return true;
                }  
            }

            return false;
        }
    }
}