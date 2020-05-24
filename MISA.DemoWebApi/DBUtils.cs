using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace MISA.DemoWebApi
{
    public class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "misa.demotest";
            string username = "root";
            string password = "nguyetmoon";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}