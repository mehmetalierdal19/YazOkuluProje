using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;

namespace YazOkuluProje
{
    public partial class AdminAnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Hoşgeldiniz " + AdminGirisBilgileri.kullaniciadi;
        }
    }
}