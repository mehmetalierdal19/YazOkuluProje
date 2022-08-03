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
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(Request.QueryString["OgrId"].ToString());
            txtId.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BLLOgrenci.OgrenciDetayBLL(id);
                txtAd.Text = OgrList[0].Ad.ToString();
                txtSoyad.Text = OgrList[0].Soyad.ToString();
                txtNumara.Text = OgrList[0].Numara.ToString();
                txtMail.Text = OgrList[0].Mail.ToString();
                txtSifre.Text = OgrList[0].Sifre.ToString();
            }


        }

        protected void update_Click(object sender, EventArgs e)
        {
            
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = txtAd.Text;
                ent.Mail = txtMail.Text;
                ent.Numara = txtNumara.Text;
                ent.OgrId = Convert.ToInt32(txtId.Text);
                ent.Sifre = txtSifre.Text;
                ent.Soyad = txtSoyad.Text;
                BLLOgrenci.OgrenciGuncelleBLL(ent);
                Response.Redirect("OgrenciListesi.aspx");

        }
    }
}