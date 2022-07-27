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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiriş_Click(object sender, EventArgs e)
        {
            if (floatingDrop.SelectedValue == "1")
            {
                BLLOgrenci.OgrenciBilgiBLL(Convert.ToInt32(floatingInput.Text), floatingPassword.Text);
                if (GirisBilgileri.No != null && GirisBilgileri.Pass != null)
                {
                    Response.Redirect("OgrenciAnaSayfa.aspx");
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Giriş Başarısız";
                }

            }
        }
    }
}