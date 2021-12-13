using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public String exeCommand(String queryString)
        {
            String result = "";
            SqlCommand cmd = new SqlCommand(queryString, Connection);

            Connection.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                

               while(reader.Read())
                {
                    String str = "";
                    int i = 0;
                    while (reader.NextResult())
                    {
                        str += reader.GetString(i);
                        i++;
                    }
                   MessageBox.Show(str);
                }


            }

            Connection.Close();

            return result;

        }
    }
}
