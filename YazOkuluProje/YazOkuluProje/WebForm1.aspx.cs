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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void temizle()
        {
            txtAd.Text = "";
            txtSifre.Text = "";
            txtSoyad.Text = "";
            txtMail.Text = "";
            txtNumara.Text = "";
            Label1.Visible = false;
            Label1.Text = "";
        }
        protected void submit_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtAd.Text == null || txtMail.Text == "" || txtMail.Text == null || txtNumara.Text == "" || txtNumara.Text == null || txtSifre.Text == "" || txtSifre.Text == null || txtSoyad.Text == "" || txtSoyad.Text == null)
            {
                Label1.Visible = true;
                Label1.Text = "Lütfen Gerekli Alanları Doldurunuz";
            }
            else
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = txtAd.Text;
                ent.Soyad = txtSoyad.Text;
                ent.Numara = txtNumara.Text;
                ent.Sifre = txtSifre.Text;
                ent.Mail = txtMail.Text;
                BLLOgrenci.OgrenciEkleBLL(ent);
                temizle();
                Response.Redirect("OgrenciListesi.aspx");
            }
        }
    }
}