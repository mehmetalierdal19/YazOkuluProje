using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;

namespace YazOkuluProje
{
    public partial class AdminSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["AdminId"].ToString());
            BLLAdmin.AdminSil(id);
            Response.Redirect("AdminListesi.aspx");
        }
    }
}