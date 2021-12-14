using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DWWP
{
    internal class SQLCon
    {
        public SqlConnection Connection { get; set; }
        public SQLCon(String connectionString)
        {
            Connection = new SqlConnection(connectionString);

        }

        public bool ConTest()
        {
            try
            {

                Connection.Open();
                Connection.Close();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        /// <summary>
        /// enters a query command into the SQL database and returns a string from a reader
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public String exeCommandReader(String queryString)
        {
            String result = "";
            SqlCommand cmd = new SqlCommand(queryString, Connection);

            Connection.Open();


            using (SqlDataReader reader = cmd.ExecuteReader())
            {


                int lenght = 0;
                while (reader.Read())
                {
                    lenght = reader.FieldCount;
                    result += readSingleRow((IDataRecord)reader);
                }

                String header = "";

                for (int i = 0; i < lenght; i++)
                {
                    header += reader.GetName(i) + ",";
                }

                result = header + "\n" + result;

            }

            Connection.Close();

            return result;

        }

        private String readSingleRow(IDataRecord data)
        {
            String result = "";
            for (int i = 0; i < data.FieldCount; i++)
            {
                result += data[i].ToString() + "|,|";
            }
            return result + "\n";
        } 

        /// <summary>
        /// enters a query command into the SQL database and returns a DataTable from a Adapter
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public DataTable exeCommandTable(String queryString)
        {
            var result = new DataTable();


            SqlCommand cmd = new SqlCommand(queryString, Connection);
            Connection.Open();

            using(SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(result);
            }
            Connection.Close();

            return result;
        }
    }
}
