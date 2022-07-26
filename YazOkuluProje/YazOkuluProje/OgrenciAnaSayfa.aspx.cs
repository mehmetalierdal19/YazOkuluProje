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
    public partial class OgrenciAnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Hoşgeldiniz " + GirisBilgileri.Ad + " " + GirisBilgileri.Soyad;
        }
    }
}