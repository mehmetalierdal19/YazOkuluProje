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
                if(floatingInput.Text == "" || floatingPassword.Text == "")
                {
                    Label1.Visible = true;
                    Label1.Text = "Lütfen Gerekli Alanları Doldurunuz.";
                }
                else
                {
                    BLLOgrenci.OgrenciBilgiBLL(Convert.ToInt32(floatingInput.Text), floatingPassword.Text);
                    if (GirisBilgileri.No != null && GirisBilgileri.Pass != null && GirisBilgileri.No != "" && GirisBilgileri.Pass != "")
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
            else if(floatingDrop.SelectedValue == "2")
            {
                if(floatingInput.Text == "" || floatingPassword.Text == "")
                {
                    Label1.Visible = true;
                    Label1.Text = "Lütfen Gerekli Alanları Doldurunuz";

                }
                else
                {
                    BLLOgretmen.OgretmenBilgiBLL(Convert.ToInt32(floatingInput.Text), floatingPassword.Text);
                    if(OgrtGirisBilgileri.ogrtno != null && OgrtGirisBilgileri.ogrtsifre != null && OgrtGirisBilgileri.ogrtno != "" && OgrtGirisBilgileri.ogrtsifre != "")
                    {
                        Response.Redirect("OgretmenAnaSayfa.aspx");
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
}