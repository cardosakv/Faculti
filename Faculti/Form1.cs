using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faculti.Helpers;
using Oracle.ManagedDataAccess.Client;

namespace Faculti
{
    public partial class Form1 : Form
    {
        private readonly string _cred = "User ID = ADMIN; Password = @SCHIFFER100.cairo; Data Source = facultidb_high";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection { ConnectionString = _cred };
            OracleCommand cmd = new OracleCommand("select email from parent where email = 'rheaynneray.eduyan@cit.edu'", conn);
            conn.Open();

            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr.GetString(0) != null) MessageBox.Show("Found" + rdr.GetString(0));
            }

            rdr.Close();
            conn.Close();
        }
    }
}
