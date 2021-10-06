using AirtableApiClient;
using static Faculti.Security.PasswordChecker;

namespace Faculti
{
    public class User
    {
        private string _type;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phoneNumber;
        private string _passwordInHash;
        private string _recordId;
        private bool _verified;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string PasswordInHash
        {
            get { return _passwordInHash; }
            set { _passwordInHash = value; }
        }

        public string RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        public bool Verified
        {
            get { return _verified; }
            set { _verified = value; }
        }

        public bool DoesExistInDatabase(AirtableRecord[] records)
        {
            return IsPasswordCorrect(_email, _passwordInHash, records);
        }
    }
}