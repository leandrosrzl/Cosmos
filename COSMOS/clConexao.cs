using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOS
{
    class clConexao
    {
        //private static string strConn = "User=SYSDBA;Password=masterkey;Database=C:\\New_Era_Info\\COSMOS\\COSMDB.fdb;DataSource=52.67.126.48;Port=3050;Dialect=3;";

        private static string strConn = "User=SYSDBA;Password=masterkey;Database=" + Application.StartupPath.ToString() + "\\COSMDB.fdb;DataSource=localhost;Port=3050;Dialect=3;";

        //private static string strConn = "User=SYSDBA;Password=masterkey;Database=C:\\New_era_info\\COSMOS\\COSMDB.fdb;DataSource=rodrigocosmos2.ddns.net;Port=3050;Dialect=3;";

        public static string stringConexao
        {
            get{ return strConn;}
        }
    }
}
