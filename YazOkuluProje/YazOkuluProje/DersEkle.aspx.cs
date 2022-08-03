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
    public partial class DersEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtAd.Text == null || txtBakiye.Text == "" || txtBakiye.Text == null || txtMax.Text == "" || txtMax.Text == null || txtMin.Text == "" || txtMin.Text == null)
            {
                Label1.Visible = true;
                Label1.Text = "Lütfen Gerekli Alanları Doldurunuz";
            }
            else
            {
                EntityDers ent = new EntityDers();
                ent.Dersad = txtAd.Text;
                ent.Min = Convert.ToInt32(txtMin.Text);
                ent.Max = Convert.ToInt32(txtMax.Text);
                ent.DersBakiye = Convert.ToDouble(txtBakiye.Text);
                BLLDers.DersEkleBLL(ent);
                Response.Redirect("DersListesi.aspx");
            }
        }
    }
}