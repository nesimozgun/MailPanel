using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace MailGondermeSistemi
{
    public class Sqlclass
    {
        public class SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-P9FF04F; Initial Catalog= dbo_mailgondermesistemi; Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}