using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;

namespace YazOkuluProje
{
    public partial class OgrenciDersSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int basid = int.Parse(Request.QueryString["BasvuruId"].ToString());
            int dersid = int.Parse(Request.QueryString["BasDersId"].ToString());
            bool arttir = false;
            double dersucret = double.Parse(Request.QueryString["BasDersUcret"].ToString());
            string ogrno = GirisBilgileri.No;
            bool x = false;
            Response.Write(basid);
            Response.Write(dersid);
            Response.Write(dersucret);
            Response.Write(ogrno);

            BLLBasvuru.BasvuruSilBLL(basid);
            BLLDers.DersDurumGuncelleBLL(arttir, dersid);
            BLLOgrenci.OgrenciUcretAzaltBLL(dersucret, x);

            Response.Redirect("OgrenciAlinanDersler.aspx");

        }
    }
}