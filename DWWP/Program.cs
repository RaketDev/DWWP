using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWWP
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Config.createConfigFile();
            if(Config.readConfig("Connection") == "True" || Config.readConfig("Connection") == "true")
            {
                SQLCon connection = new SQLCon(Config.SQLConnStringmk());
                if(connection.ConTest()) Connection = connection;
                if (!connection.ConTest()) MessageBox.Show("SQL Connection failed!");
            }
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
            
        }
        public static SQLCon Connection = null;

    }
}
