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
    public partial class OgretmenSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrtId"]);
            Response.Write(x);
            EntityOgretmen ent = new EntityOgretmen();
            ent.OgrtId = x;
            BLLOgretmen.OgretmenSilBLL(ent.OgrtId);
            Response.Redirect("AdminOgretmenListesi.aspx");
        }
    }
}