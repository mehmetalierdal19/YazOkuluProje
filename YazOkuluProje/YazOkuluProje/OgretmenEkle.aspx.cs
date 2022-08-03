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
    public partial class OgretmenEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDers> derslist = BLLDers.DersListeleBLL();
            for (int i = 0; i < derslist.Count; i++)
            {
                DropDownList1.Items.Add(derslist[i].Dersad.ToString());
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtAd.Text == null || txtNumara.Text == "" || txtNumara.Text == null || txtSifre.Text == "" || txtSifre.Text == null || txtSifre.Text == "")
            {
                Label1.Visible = true;
                Label1.Text = "Lütfen Gerekli Alanları Doldurunuz";
            }
            else
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.OgrtAd = txtAd.Text;
                ent.OgrtDersAd = DropDownList1.Text;
                ent.OgrtNumara = txtNumara.Text;
                ent.OgrtSifre = txtSifre.Text;
                BLLOgretmen.OgretmenEkleBLL(ent);
                Response.Redirect("AdminOgretmenListesi.aspx");
            }
        }
    }
}