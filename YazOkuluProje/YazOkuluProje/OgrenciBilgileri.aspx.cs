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
    public partial class OgrenciBilgileri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = GirisBilgileri.Ad;
            Label2.Text = GirisBilgileri.Soyad;
            Label3.Text = GirisBilgileri.No;
            Label6.Text = GirisBilgileri.bakiye.ToString();
            Label5.Text = GirisBilgileri.mail;
        }
    }
}