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
        private readonly string _cred = "User ID = ADMIN; Password = @SCHIFFER100.cairo; Data Source = facultidb_high; Connection Timeout = 60;";
        #endregion

        public readonly OracleConnection Conn;

        public DatabaseClient()
        {
            try
            {
                Conn = new OracleConnection { ConnectionString = _cred };
                Conn.Open();
            }
            catch (Exception)
            {

            }

        }

        public void PerformNonQueryCommand(string commandText)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(commandText, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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

        /*
        public DataTable JoinTables(string table1Name, string table2Name, string colName)
        {
            DataTable table1 = new DataTable(table1Name);
            DataTable table2 = new DataTable(table2Name); 

            var cmdText = $"select * from "
            try
            {
                var cmdText = $"select count(*) from all_tab_columns where table_name = '{table1Name.ToUpper()}'";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = cmdText;
                OracleDataReader rdr = cmd.ExecuteReader();
                int numOfCol = rdr.GetInt32(0);

                cmdText = $"select column_name, data_type from all_tab_columns where table_name = '{table1Name.ToUpper()}'";
                cmd.CommandText = cmdText;
                rdr = cmd.ExecuteReader();
                while (numOfCol-- != 0)
                {
                    table1.Columns.Add(rdr.GetString(0));
                }
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in JoinTable()!");
            }
        }*/
    }
}
