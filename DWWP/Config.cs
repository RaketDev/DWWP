using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWWP
{
    internal static class Config
    {
        public static String configPath = null;

        public static void createConfigFile()
        {
            string pathString = Application.StartupPath + "\\config.txt";
            configPath = pathString;

            if (!System.IO.File.Exists(pathString))
            {
                System.IO.FileStream fs = System.IO.File.Create(pathString);
                fs.Close();

                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(pathString))
                {
                    sw.WriteLine("SQL:SQL");
                    sw.WriteLine("Servername:");
                    sw.WriteLine("Database:");
                    sw.WriteLine("Port:");
                    sw.WriteLine("winAuth:");
                    sw.WriteLine("Username:");
                    sw.WriteLine("Password:");
                    sw.WriteLine("Connected:");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");
                    sw.WriteLine("");

                }

            }

        }

        public static string readConfig(String option)
        {
            String rowdata = "";
            String result = "";

            using (System.IO.StreamReader reader = new System.IO.StreamReader(configPath))
            {

                while (!reader.EndOfStream)
                {
                    rowdata += "\n" + reader.ReadLine();
                }

            }

            String[] data = rowdata.Split("\n");

            switch (option)
            {
                case "SQLconnectionString":
                    int i = 0;
                    for (i = i; i < data.Length; i++)
                    {
                        if (data[i] == "SQL:SQL") break;
                    }

                    for (int i1 = i; i1 < i + 7; i1++)
                    {
                        var str = data[i1].Split(":");
                        result += str[1] + ",";
                    }

                    break;

                case "Connection":

                    int ic = 0;
                    for (i = ic; i < data.Length; i++)
                    {
                        if (data[i] == "SQL:SQL") break;
                    }

                    var str1 = data[ic + 8].Split(":");

                    result = str1[1];


                    break;

            }
            return result;
        }

        public static void writeConfig(String data)
        {
            using (System.IO.StreamWriter ws = new System.IO.StreamWriter(configPath))
            {
                ws.Write(data);
            }
        }

        public static String SQLConnStringmk()
        {
            String[] conndata = readConfig("SQLconnectionString").Split(",");

            String connstr = "Data Source=" + conndata[1] + ";" +
                            "Initial Catalog=" + conndata[2] + ";" +
                            "User id=" + conndata[5] + ";" +
                            "Password=" + conndata[6] + ";";

            return connstr;
        }
    }
}
