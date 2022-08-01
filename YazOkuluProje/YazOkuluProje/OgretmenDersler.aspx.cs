using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluProje
{
    public partial class OgretmenDersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDers> derslist = BLLDers.DersDetayleBLL(OgrtGirisBilgileri.ogrtdersid);
            Repeater1.DataSource = derslist;
            Repeater1.DataBind();
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    aktif = true;
        //    BLLDers.DurumGuncelle(aktif);
        //    Response.Redirect("OgretmenDersler.aspx");
        //}

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    aktif = false;
        //    BLLDers.DurumGuncelle(aktif);
        //    Response.Redirect("OgretmenDersler.aspx");
        //}
    }
}