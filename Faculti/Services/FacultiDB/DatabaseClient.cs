using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculti.Services.FacultiDB
{
    internal class DatabaseClient
    {
        #region Secret
        private readonly string _cred = "User ID = ADMIN; Password = @SCHIFFER100.cairo; Data Source = facultidb_high";
        #endregion

        public readonly OracleConnection Conn;

        public DatabaseClient()
        {
            Conn = new OracleConnection { ConnectionString = _cred };
            Conn.Open();
        }

        public DataTable ListColumn(string tableName, string colName)
        {
            DataTable records = new DataTable();
            records.Columns.Add(colName, typeof(string));

            try
            {
                OracleCommand cmd = new OracleCommand("select " + colName + " from " + tableName, Conn);
                OracleDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.HasRows) records.Rows.Add(rdr.GetString(0));
                }
                rdr.Close();
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in ListColumns()!");
            }

            return records;
        }

        public void PerformNonQueryCommand(string commandText)
        {
            OracleCommand cmd = new OracleCommand(commandText, Conn);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
