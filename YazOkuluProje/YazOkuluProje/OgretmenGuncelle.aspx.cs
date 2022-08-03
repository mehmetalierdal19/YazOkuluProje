using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;

namespace YazOkuluProje
{
    public partial class OgretmenGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(Request.QueryString["OgrtId"].ToString());
            txtId.Text = id.ToString();

            List<EntityDers> derslist = BLLDers.DersListeleBLL();
            for(int i = 0; i< derslist.Count; i++)
            {
                DropDownList1.Items.Add(derslist[i].Dersad.ToString());
            }

            if (Page.IsPostBack == false)
            {
                List<EntityOgretmen> OgrList = BLLOgretmen.OgretmenDetayBLL(id);
                txtAd.Text = OgrList[0].OgrtAd.ToString();
                //txtDersid.Text = OgrList[0].OgrtDersId.ToString();
                txtId.Text = OgrList[0].OgrtId.ToString();
                txtSifre.Text = OgrList[0].OgrtSifre.ToString();
                txtNumara.Text = OgrList[0].OgrtNumara.ToString();
                DropDownList1.Text = OgrList[0].OgrtDersAd.ToString();
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            EntityOgretmen ent = new EntityOgretmen();
            ent.OgrtAd = txtAd.Text;
            ent.OgrtDersAd = DropDownList1.Text;
            ent.OgrtId = Convert.ToInt32(txtId.Text);
            ent.OgrtNumara = txtNumara.Text;
            ent.OgrtSifre = txtSifre.Text;
            BLLOgretmen.OgretmenGuncelleBLL(ent);
            Response.Redirect("AdminOgretmenListesi.aspx");
        }
    }
}