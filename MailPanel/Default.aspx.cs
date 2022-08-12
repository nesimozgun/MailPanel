using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace MailGondermeSistemi
{

    public partial class Mail : System.Web.UI.Page
    {
        Sqlclass con = new Sqlclass();
        string mailID = "";

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection("YOUR CONNECTION STRING");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO tbl_Mail(name, mail_subject, mail_content) VALUES(@name,@mail_subject,@mail_content";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            Response.Redirect("Default.aspx");
        }
    }
}