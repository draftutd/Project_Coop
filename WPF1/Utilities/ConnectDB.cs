using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1.Utilities
{
    public static class ConnectDB
    {
        private static SqlConnection wconn;

        public static SqlConnection getConnection()
        {
            wconn = new SqlConnection(Configuration.getConfiguration("00000000"));
            wconn.Open();
            return wconn;
        }

        public static void closeConnection()
        {
            SqlConnection.ClearAllPools();
            wconn.Close();
            wconn = null;
        }
    }
}
