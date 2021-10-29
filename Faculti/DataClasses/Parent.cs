using Faculti.Services.FacultiDB;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculti.DataClasses
{
    public class Parent : User
    {
        private Student _assignedStudent;
        private int _studentId;
        private string _studentCode;

        public Student AssignedStudent
        {
            get { return _assignedStudent; }
            set 
            {
                _assignedStudent = value;
                StudentCode = _assignedStudent.Code;
                StudentId = _assignedStudent.Id;
            }
        }

        public string StudentCode
        {
            get { return _studentCode; }
            set { _studentCode = value; }
        }

        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }
    }
}
