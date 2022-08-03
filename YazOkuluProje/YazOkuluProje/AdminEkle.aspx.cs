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
    public partial class AdminEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtAd.Text == null || txtSifre.Text == "" || txtSifre.Text == null)
            {
                Label1.Visible = true;
                Label1.Text = "Lütfen Gerekli Alanları Doldurunuz";
            }
            else
            {
                EntityAdmin ent = new EntityAdmin();
                ent.KullaniciAdi = txtAd.Text;
                ent.Sifre = txtSifre.Text;
                BLLAdmin.AdminEkleBLL(ent);
                Response.Redirect("AdminListesi.aspx");
            }
        }
    }
}