using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;


namespace BusinessLogicLayer
{
    public class BLLAdmin
    {
        public static int AdminEkleBLL(EntityAdmin p)
        {
            bool dif = true;
            SqlCommand komut = new SqlCommand("Select * from TBLADMIN", Baglanti.bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                if (p.KullaniciAdi == satir["KULLANICIADI"].ToString())
                {
                    dif = false;
                    break;
                }
            }
            if (dif != false)
            {
                if (p.KullaniciAdi != null && p.KullaniciAdi != "" && p.Sifre != null && p.Sifre != "")
                {
                    return DALAdmin.AdminEkle(p);
                }
            }
            return -1;
        }
        public static List<EntityAdmin> AdminGirisBLL(string kullaniciad, string sifre)
        {
            AdminGirisBilgileri.dif = true;

            SqlCommand komut = new SqlCommand("Select * from TBLADMIN", Baglanti.bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                if (kullaniciad == satir["KULLANICIADI"].ToString() && sifre == satir["SIFRE"].ToString())
                {
                    AdminGirisBilgileri.dif = false;
                    return DALAdmin.AdminGiris(kullaniciad);

                }
            }
            return DALAdmin.AdminGiris("");
        }
        public static List<EntityAdmin> AdminListeleBLL()
        {
            return DALAdmin.AdminListele();
        }
        public static bool AdminGuncelle(EntityAdmin p)
        {
            return DALAdmin.AdminGuncelle(p);
        }
        public static bool AdminSil(int id)
        {
            return DALAdmin.AdminSil(id);
        }
        public static List<EntityAdmin> AdminDetayBLL(string kadi)
        {
            return DALAdmin.AdminDetay(kadi);
        }
    }
}
