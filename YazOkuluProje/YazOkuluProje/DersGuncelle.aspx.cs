using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace YazOkuluProje
{
    public partial class DersGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["DersId"].ToString());
                List<EntityDers> derslist = BLLDers.DersDetayleBLL(id);
                txtAd.Text = derslist[0].Dersad.ToString();
                DropDownList1.Text = derslist[0].DersDurum.ToString();
                txtId.Text = derslist[0].DersId.ToString();
                txtMax.Text = derslist[0].Max.ToString();
                txtMin.Text = derslist[0].Min.ToString();
                txtUcret.Text = derslist[0].DersBakiye.ToString();
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.Dersad = txtAd.Text;
            ent.DersDurum = DropDownList1.Text;
            ent.DersId = Convert.ToInt32(txtId.Text);
            ent.DersBakiye = Convert.ToDouble(txtUcret.Text);
            ent.Max = Convert.ToInt32(txtMax.Text);
            ent.Min = Convert.ToInt32(txtMin.Text);
            BLLDers.DersGuncelleBLL(ent);
            Response.Redirect("DersListesi.aspx");
        }
    }
}