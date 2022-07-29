using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;


namespace YazOkuluProje
{
    public partial class OgretmenMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            OgrtGirisBilgileri.ogrtad = "";
            OgrtGirisBilgileri.ogrtders = "";
            OgrtGirisBilgileri.ogrtdersid = 0;
            OgrtGirisBilgileri.ogrtid = 0;
            OgrtGirisBilgileri.ogrtno = "";
            OgrtGirisBilgileri.ogrtsifre = "";
            Response.Redirect("LoginPage.aspx");
        }
    }
}