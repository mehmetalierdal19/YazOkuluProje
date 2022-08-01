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
    public partial class DersDurumGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool aktif;
            if(Request.QueryString["DersDurum"].ToString() == "Aktif")
            {
                Response.Write("Aktif");
                aktif = true;
                BLLDers.DurumGuncelle(aktif);
                Response.Redirect("OgretmenDersler.aspx");
            }
            else
            {
                Response.Write("Pasif");
                aktif = false;
                BLLDers.DurumGuncelle(aktif);
                Response.Redirect("OgretmenDersler.aspx");
            }
        }
    }
}