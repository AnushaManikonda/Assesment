using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace WebApplication6
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public string DataTableToJSONWithStringBuilder(DataTable table)
        {
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }

        
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get()
        {
            //   string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

            SqlConnection con;
            con = new SqlConnection(WebApplication6.Properties.Settings.Default.Setting);
            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customer"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Customer";
                            sda.Fill(dt);

                            return DataTableToJSONWithStringBuilder(dt); ;
                        }
                    }
                }
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public String Getpage(int pagesize, int pageno)
        {
            //   string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

            SqlConnection con;
            con = new SqlConnection(WebApplication6.Properties.Settings.Default.Setting);
            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customer order by id offset " + (pagesize * (pageno - 1)) + " rows fetch next " + pageno + " rows only"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Customer";
                            sda.Fill(dt);

                            return DataTableToJSONWithStringBuilder(dt); ;
                        }
                    }
                }
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Getid(int id)
        {
            //   string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

            SqlConnection con;
            con = new SqlConnection(WebApplication6.Properties.Settings.Default.Setting);
            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customer where Id="+id))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Customer";
                            sda.Fill(dt);

                            return DataTableToJSONWithStringBuilder(dt); ;
                        }
                    }
                }
            }
        }

    }
}
