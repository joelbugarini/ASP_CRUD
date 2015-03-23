using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempWebApp.DAC
{
    public class DBInfo
    {
        public DBInfo()
        {
            Server = "(LocalDB)\\V11.0";
            DataBase = "temp";
            User = "Joel";
            Password = "rareware";
        }
        private string server;

        public string Server
        {
            get { return server; }
            set { server = value; }
        }

        private string dataBase;

        public string DataBase
        {
            get { return dataBase; }
            set { dataBase = value; }
        }
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }



        public string sqlSet()
        {
            string res;
            res = "Server=" + Server + "; Database=" + DataBase + ";User ID=" + User + ";Password=" + Password + "";
            return res;
        }
    }
}
