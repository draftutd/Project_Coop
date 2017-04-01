using System;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF1.Utilities;

namespace WPF1.Securities.Controller
{
    public static class PrivilegeController
    {
        private static Hashtable arrPrivilege = new Hashtable();
        private static Privilege vpriv_no = new Privilege(0, 0, 0, 0, 0);
        public static String param_sessionid;
        public static Decimal param_empid;

        public static Boolean authenticate(String username, String password)
        {
            Boolean vret = false;
            SqlParameter vparam1 = new SqlParameter("@empid", System.Data.SqlDbType.Decimal);
            vparam1.Direction = System.Data.ParameterDirection.Output;
            SqlParameter vparam2 = new SqlParameter("@sessionid", System.Data.SqlDbType.VarChar, 100);
            vparam2.Direction = System.Data.ParameterDirection.Output;

            SqlConnection vconn = ConnectDB.getConnection();
            SqlCommand vcmd = new SqlCommand();
            vcmd.CommandText = Configuration.getConfiguration("10001101");
            vcmd.CommandType = System.Data.CommandType.StoredProcedure;
            vcmd.Connection = vconn;

            vcmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar).Value = username;
            vcmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password;
            vcmd.Parameters.Add(vparam1);
            vcmd.Parameters.Add(vparam2);
            vcmd.ExecuteNonQuery();

            param_empid = (Decimal)vparam1.Value;
            param_sessionid = ((String)vparam2.Value).Trim();
            vcmd = null;
            vconn.Close();

            // ******************************
            if (param_empid > 0 & param_sessionid.Trim().Length > 0) vret = true;

            return vret;
        }
    }
}
