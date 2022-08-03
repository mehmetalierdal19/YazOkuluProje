using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;

namespace YazOkuluProje
{
    public partial class AdminGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string kullaniciadi = Request.QueryString["KullaniciAdi"].ToString();
                List<EntityAdmin> adminlist = BLLAdmin.AdminDetayBLL(kullaniciadi);
                txtAd.Text = adminlist[0].KullaniciAdi.ToString();
                txtId.Text = adminlist[0].AdminId.ToString();
                txtSifre.Text = adminlist[0].Sifre.ToString();
            }
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
                ent.AdminId = Convert.ToInt32(txtId.Text);
                ent.KullaniciAdi = txtAd.Text;
                ent.Sifre = txtSifre.Text;
                BLLAdmin.AdminGuncelle(ent);
                Response.Redirect("AdminListesi.aspx");
            }
        }
    }
}