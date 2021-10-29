using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculti.DataClasses
{
    public class Student
    {
        private int _id;
        private string _code;
        private string _lastName;
        private string _firstName;
        private int _age;
        private string _sex;
        private int _gradeLevel;
        private string _sectionName;
        private int _teacherId;
        private int _parentId;

        public Student() { }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public int GradeLevel
        {
            get { return _gradeLevel; }
            set { _gradeLevel = value; }
        }

        public string SectionName
        {
            get { return _sectionName; }
            set { _sectionName = value; }
        }

        public int TeacherId
        {
            get { return _teacherId; }
            set {  _teacherId = value; }
        }

        public int ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
        }

        public void GetInfo(string studentCode)
        {
            Code = studentCode;
            DatabaseClient client = new DatabaseClient();
            var cmdText = $"select student_id, first_name, last_name, age, sex, grade_level, teacher_id, parent_id from students where student_code = '{studentCode}'";
            OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            if (rdr.HasRows)
            {
                Id = rdr.GetInt32(0);
                FirstName = rdr.GetString(1);
                LastName = rdr.GetString(2);
                Age = rdr.GetInt32(3);
                Sex = rdr.GetString(4);
                GradeLevel = rdr.GetInt32(5);
                TeacherId = rdr.GetInt32(6);
                ParentId = rdr.IsDBNull(7) ? Convert.ToInt32(null) : rdr.GetInt32(7);
                rdr.Close();

                cmdText = $"select section_name from teachers where teacher_id = '{_teacherId}'";
                cmd = new OracleCommand(cmdText, client.Conn);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                SectionName = rdr.GetString(0);
            }

            rdr.Close();
            client.Conn.Close();
        }

        public void GetInfo(int parentid)
        {
            DatabaseClient client = new DatabaseClient();
            var cmdText = $"select student_id, first_name, last_name, age, sex, grade_level, teacher_id from students where parent_id = '{parentid}'";
            OracleCommand cmd = new OracleCommand(cmdText, client.Conn);
            OracleDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            if (rdr.HasRows)
            {
                Id = rdr.GetInt32(0);
                FirstName = rdr.GetString(1);
                LastName = rdr.GetString(2);
                Age = rdr.GetInt32(3);
                Sex = rdr.GetString(4);
                GradeLevel = rdr.GetInt32(5);
                TeacherId = rdr.GetInt32(6);
                rdr.Close();

                cmdText = $"select section_name from teachers where teacher_id = '{_teacherId}'";
                cmd = new OracleCommand(cmdText, client.Conn);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                SectionName = rdr.GetString(0);
            }

            rdr.Close();
            client.Conn.Close();
        }
    }
}
