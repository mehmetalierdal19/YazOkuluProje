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
                txtDurum.Text = dersList[0].DersDurum.ToString();
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            double ucret = double.Parse(txtUcret.Text);
            bool ucretazalt;
            bool arttir;
            if(txtNumara.Text != GirisBilgileri.No || txtNumara.Text == "" || txtNumara.Text == null)
            {
                Label1.Visible = true;
                Label1.Text = "Geçersiz Öğrenci Numarası.";
            }
            else if(int.Parse(txtUcret.Text) > GirisBilgileri.bakiye)
            {
                Label1.Visible = true;
                Label1.Text = "Yetersiz Bakiye.";
            }
            else
            {
                EntityBasvuruForm ent = new EntityBasvuruForm();
                ent.BasDersAd = txtAd.Text;
                ent.BasDersId = int.Parse(txtId.Text);
                ent.BasOgrAd = GirisBilgileri.Ad + " " + GirisBilgileri.Soyad;
                ent.BasDersDurum = txtDurum.Text;
                ent.BasOgrNo = txtNumara.Text;
                ent.BasDersUcret = double.Parse(txtUcret.Text);
                GirisBilgileri.BuDegerVarMi = false;
                BLLBasvuru.BasvuruEkleBLL(ent);
                if(GirisBilgileri.BuDegerVarMi == true)
                {
                    Label1.Visible = true;
                    Label1.Text = "Bu Derse Zaten Kayıtlısınız.";
                }
                else
                {
                    ucretazalt = true;
                    BLLOgrenci.OgrenciUcretAzaltBLL(ucret, ucretazalt);
                    arttir = true;
                    BLLDers.DersDurumGuncelleBLL(arttir, int.Parse(txtId.Text));
                    Label1.Visible = false;
                    Label1.Text = "";
                    Label2.Visible = true;
                    Label2.Text = "Ders Başvurusu Başarılı Bir Şekilde Yapılmıştır.";
                }
                
            }
        }
    }
}