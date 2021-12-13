using System;
using System.Data.SqlClient;
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
    public partial class Form_Options : Form
    {

        private bool connection;
        public Form_Options()
        {
            InitializeComponent();

            String[] conndata = Config.readConfig("SQLconnectionString").Split(",");
            SQLServername.Text = conndata[1];
            SQLDatabase.Text = conndata[2];
            SQLPort.Text = conndata[3];
            //SQLWinAuth.Text = conndata[4];
            SQLUsername.Text = conndata[5];
            SQLPassword.Text = conndata[6];
        }

        private void SQLWinAuth_Click(object sender, EventArgs e)
        {
            if (SQLUsername.Enabled == true) WindowsAuth(false);
            else if (SQLUsername.Enabled == false) WindowsAuth(true);
        }
        private void WindowsAuth(bool enabeld)
        {
            SQLUsername.Enabled = enabeld;
            SQLPassword.Enabled = enabeld;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String data = "SQL:SQL\n" +
                    "Servername:" + SQLServername.Text + "\n" +
                    "Database:" + SQLDatabase.Text + "\n" +
                    "Port:" + SQLPort.Text + "\n" +
                    "winAuth:" + SQLWinAuth.Enabled.ToString() + "\n" +
                    "Username:" + SQLUsername.Text + "\n" +
                    "Password:" + SQLPassword.Text + "\n" +
                    "Connected:" + connection.ToString() + "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    ""; 

            Config.writeConfig(data);



        }

        private void buttonConTest_Click(object sender, EventArgs e)
        {
            String connstr = Config.SQLConnStringmk();

            SQLCon con = new SQLCon(connstr);
            if (con.ConTest())
            {
                buttonCon.BackColor = Color.Green;
                connection = true;
            }
            if (!con.ConTest())
            {
                buttonCon.BackColor = Color.Red;
                connection = false;
            }
        }
    }
}
