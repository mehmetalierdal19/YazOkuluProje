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
    public partial class AdminGirisi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiriş_Click(object sender, EventArgs e)
        {
            if (floatingInput.Text == "" || floatingPassword.Text == "")
            {
                Label1.Visible = true;
                Label1.Text = "Lütfen Gerekli Alanları Doldurunuz";

            }
            else
            {
                BLLAdmin.AdminGirisBLL(floatingInput.Text, floatingPassword.Text);
                if (AdminGirisBilgileri.dif == false)
                {
                    Response.Redirect("AdminAnaSayfa.aspx");
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