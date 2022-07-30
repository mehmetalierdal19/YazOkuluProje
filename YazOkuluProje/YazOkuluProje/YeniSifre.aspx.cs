using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;
using DataAccessLayer;

namespace YazOkuluProje
{
    public partial class YeniSifre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnDegistir_Click(object sender, EventArgs e)
        {
            if(OgrtGirisBilgileri.ogrtsifre != txtEski.Text && GirisBilgileri.Pass != txtEski.Text)
            {
                Label1.Visible = true;
                Label1.Text = "Eski Şifre Yanlış.";
            }
            else if(txtYeni.Text != txtYeniTekrar.Text)
            {
                Label1.Visible = true;
                Label1.Text = "Yeni Şifreler Uyuşmuyor";
            }
            else if(txtEski.Text == ""  || txtYeni.Text == "" || txtYeniTekrar.Text == "")
            {
                Label1.Visible = true;
                Label1.Text = "Lütfen Gerekli Alanları Doldurunuz";
            }
            else
            {
                BLLOgretmen.SifreDegisBLL(txtYeniTekrar.Text);
                Label1.Visible = false;
                Label1.Text = "";
                if(GirisBilgileri.No != null && GirisBilgileri.No != "")
                {
                    Response.Redirect("OgrenciBilgileri.aspx");
                }
                else if(OgrtGirisBilgileri.ogrtno != null && OgrtGirisBilgileri.ogrtno != "")
                {
                    Response.Redirect("OgretmenBilgileri.aspx");
                }
            }
        }

        protected void btnGeri_Click(object sender, EventArgs e)
        {
            if (GirisBilgileri.No != null && GirisBilgileri.No != "")
            {
                Response.Redirect("OgrenciBilgileri.aspx");
            }
            else if (OgrtGirisBilgileri.ogrtno != null && OgrtGirisBilgileri.ogrtno != "")
            {
                Response.Redirect("OgretmenBilgileri.aspx");
            }
        }
    }
}