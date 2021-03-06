using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWWP
{
    public partial class Form_Customer_Customer : Form
    {
        public Form_Customer_Customer()
        {
            InitializeComponent();
            CustomerCMD();
        }

        private void CustomerCMD()
        {

            String[] customerdata = Config.readConfig("SQLAddress").Split("|,|");

            DataTable dt = Program.Connection.exeCommandTable(customerdata[1]);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if ((string) dt.Rows[i].ItemArray[strToInt(customerdata[2]) - 1] == customerdata[3])
                {
                    continue;
                }
                dt.Rows[i].Delete();
            }

            dataGridView.DataSource = dt;


        } 
        private int strToInt(String str)
        {
            int i = int.Parse(str);
            return i;
        }
    }
}
