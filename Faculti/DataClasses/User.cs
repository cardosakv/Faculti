using AirtableApiClient;
using Faculti.Helpers;

namespace Faculti
{
    /// <summary>
    ///     General and parent class for all user types.
    /// </summary>
    public class User
    {
        // Private fields
        private string _type;
        private string _email;
        private string _passwordInHash;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _recordId;
        private bool   _verified;

        // Default constructor - without parameters
        public User() { }

        // Constructor with parameters
        public User(string type, string email, string passwordInHash)
        {
            _type = type;
            _email = email;
            _passwordInHash = passwordInHash;
        }


        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PasswordInHash
        {
            get { return _passwordInHash; }
            set { _passwordInHash = value; }
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
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string RecordId
        {
            get { return _recordId; }
            set { _recordId = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public bool Verified
        {
            get { return _verified; }
            set { _verified = value; }
        }

        public bool DoesExistInDatabase(AirtableRecord[] records)
        {
            return Password.IsCorrect(_email, _passwordInHash, records);
        } //master
    }
}