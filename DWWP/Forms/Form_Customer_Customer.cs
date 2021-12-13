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
            MessageBox.Show(Program.Connection.exeCommand("select * from D_kunde"));
        }
    }
}
