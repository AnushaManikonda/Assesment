using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            WebService1 serv1 = new WebService1();
           // GridView1.DataSource = serv1.Get();
           // GridView1.BindGrid();
        }

        private void BindGrid()
        {
            this.DataBind();
        }
    }
}