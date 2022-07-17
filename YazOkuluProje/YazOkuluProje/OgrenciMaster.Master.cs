using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;


namespace YazOkuluProje
{
    public partial class OgrenciMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GirisBilgileri.No = "";
            GirisBilgileri.Pass = "";
            Response.Redirect("LoginPage.aspx");
        }
    }
}