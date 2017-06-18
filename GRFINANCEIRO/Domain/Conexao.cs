using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Conexao
    {
        private static string _MSSQLServer = "X";
        private static string _MSSQLPort = "X";
        private static string _MSSQLUser = "X";
        private static string _MSSQLPass = "X";

        public static string MSSQLServer { get => _MSSQLServer; set => _MSSQLServer = value; }
        public static string MSSQLPort { get => _MSSQLPort; set => _MSSQLPort = value; }
        public static string MSSQLUser { get => _MSSQLUser; set => _MSSQLUser = value; }
        public static string MSSQLPass { get => _MSSQLPass; set => _MSSQLPass = value; }

        public string GetSQLStringCon()
        {
            return @"Data Source =" + _MSSQLServer + "," + _MSSQLPort + ";" +
                "Initial Catalog = GRFINANCEIRO;" +
                "User Id =" + _MSSQLUser + ";" +
                "Password =" + _MSSQLPass + ";";
        }

        public void SetSQLStringCon(string value)
        {
        }
    }            
}
