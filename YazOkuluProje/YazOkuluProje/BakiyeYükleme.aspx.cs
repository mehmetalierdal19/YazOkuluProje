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
    public partial class BakiyeYükleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtMiktar.Text) > 100)
            {
                Label1.Visible = true;
                Label1.Text = "100 TL den büyük değer girilemez";
            }
            else if(int.Parse(txtMiktar.Text) <= 0)
            {
                Label1.Visible = true;
                Label1.Text = "0 veya 0'ın altında değer girilemez";
            }
            else
            {
                double bakiye = double.Parse(txtMiktar.Text);
                BusinessLogicLayer.BLLOgrenci.BakiyeYuklemeBLL(bakiye);
                Response.Redirect("OgrenciBilgileri.aspx");
            }
        }
    }
}