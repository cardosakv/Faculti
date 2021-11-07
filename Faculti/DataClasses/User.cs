using Faculti.Helpers;
using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculti.DataClasses
{
    /// <summary>
    ///     General and parent class for all user types.
    /// </summary>
    public class User
    {
        // Private fields
        private int _id;
        private string _type;
        private string _email;
        private string _passwordInHash;
        private string _firstName;
        private string _lastName;
        private string _phoneNumberInHash;
        private string _sectionName;
        private string _isVerified;
        private string _hasRequested;
        private string _isActive;
        private Image _picture;
        private DateTime _lastOnline;


        // Default constructor - without parameters
        public User() { }

        // Constructor with parameters
        public User(string type, string email, string passwordInHash)
        {
            _type = type;
            _email = email;
            _passwordInHash = passwordInHash;

        }

        // Properties
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
        public string PhoneNumberInHash
        {
            get { return _phoneNumberInHash; }
            set { _phoneNumberInHash = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string SectionName
        {
            get { return _sectionName; }
            set { _sectionName = value; }
        }

        public string IsVerified
        {
            get { return _isVerified; }
            set { _isVerified = value; }
        }

        public string IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public string HasRequested
        {
            get { return _hasRequested; }
            set { _hasRequested = value; }
        }

        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        public DateTime LastOnline
        {
            get { return _lastOnline; }
            set { _lastOnline = value; }
        }

        /// <summary>
        ///     Adds a user to the database;
        /// </summary>
        /// 
        /// <param name="signupUser">
        ///     The signup user User class object.
        /// </param>
        public void AddToDatabase()
        {
            // Add user to the database
            DatabaseClient client = new DatabaseClient();
            string cmdText = $@"insert into {_type} (first_name, last_name, email, password_in_hash, phone_number_in_hash) values ('{_firstName}', '{_lastName}', '{_email}', '{_passwordInHash}', '{_phoneNumberInHash}')";
            client.PerformNonQueryCommand(cmdText);
        }

        /// <summary>
        ///     Checks if the user exists in the database.
        /// </summary> 
        public bool HaveCredentialsMatched()
        {
            return Password.IsCorrect(Type, Email, PasswordInHash);
        }

        public void GetGeneralInfo()
        {
            DatabaseClient client = new DatabaseClient();
            var cmdText = $"select {Type.Remove(Type.Length - 1, 1)}_id, first_name, last_name, phone_number_in_hash, section_name, picture, active_status, is_verified, has_requested, last_online from {Type} where email = '{Email}'";
            OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
            using (OracleDataReader rdr = cmd.ExecuteReader())
            {
                rdr.Read();

                if (rdr.HasRows)
                {
                    Id = rdr.GetInt32(0);
                    FirstName = rdr.GetString(1);
                    LastName = rdr.GetString(2);
                    PhoneNumberInHash = rdr.GetString(3);
                    SectionName = rdr.IsDBNull(4) ? null : rdr.GetString(4);
                    byte[] image = rdr.IsDBNull(5) ? null : (byte[])rdr["picture"];
                    IsActive = rdr.IsDBNull(6) ? null : rdr.GetString(6);
                    IsVerified = rdr.IsDBNull(7) ? null : rdr.GetString(7);
                    HasRequested = rdr.IsDBNull(8) ? null : rdr.GetString(8);
                    LastOnline = rdr.IsDBNull(9) ? DateTime.MinValue : rdr.GetOracleDate(9).Value;

                    if (image != null)
                    {
                        MemoryStream ms = new MemoryStream(image);
                        Picture = Image.FromStream(ms);
                    }
                    else
                    {
                        Picture = Properties.Resources.default_profile;
                    }
                }
            }
                

            client.Conn.Close();
        }

        public bool IsFirstTime()
        {
            DatabaseClient client = new DatabaseClient();
            var cmdText = $"select section_name from {Type} where email = '{Email}'";
            OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
            using (OracleDataReader rdr = cmd.ExecuteReader())
            {
                rdr.Read();

                if (rdr.IsDBNull(0)) return true;
            }


            return false;
        }

        public void SetStatus(string status)
        {
            _isActive = status;

            DatabaseClient client = new DatabaseClient();
            var cmdText = $"update {Type} set active_status = '{status}' where email = '{Email}'";
            client.PerformNonQueryCommand(cmdText);
        }



        public T As<T>()
        {
            var type = typeof(T);
            var instance = Activator.CreateInstance(type);

            if (type.BaseType != null)
            {
                var properties = type.BaseType.GetProperties();
                foreach (var property in properties)
                    if (property.CanWrite)
                        property.SetValue(instance, property.GetValue(this, null), null);
            }

            return (T)instance;
        }
    }
}