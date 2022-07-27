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
    public partial class OgrenciDersBasvuru : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["DersId"].ToString());
            txtId.Text = id.ToString();

            if(Page.IsPostBack == false)
            {
                List<EntityDers> dersList = BLLDers.DersDetayleBLL(id);
                txtId.Text = dersList[0].DersId.ToString();
                txtAd.Text = dersList[0].Dersad.ToString();
                txtUcret.Text = dersList[0].DersBakiye.ToString();
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            if(txtNumara.Text != GirisBilgileri.No)
            {
                Label1.Visible = true;
                Label1.Text = "Geçersiz Öğrenci Numarası";
            }
            else if(int.Parse(txtUcret.Text) > GirisBilgileri.bakiye)
            {
                Label1.Visible = true;
                Label1.Text = "Yetersiz Bakiye";
            }
            else
            {

            }
        }
    }
}