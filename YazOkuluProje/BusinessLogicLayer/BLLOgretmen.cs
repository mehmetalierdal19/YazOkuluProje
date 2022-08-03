using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLLOgretmen
    {
        public static List<EntityOgretmen> OgretmenBilgiBLL(int no, string pass)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLOGRETMEN", Baglanti.bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                if (no.ToString() == satir["OGRTNUMARA"].ToString() && pass.ToString() == satir["OGRTSIFRE"].ToString())
                {
                    return DALOgretmen.OgretmenGirisBilgi(no);

                }
            }
            return DALOgretmen.OgretmenGirisBilgi(-1);
        }
        public static bool SifreDegisBLL(string sifre)
        {
            return DALOgretmen.SifreDegis(sifre);
        }
        public static int OgretmenEkleBLL(EntityOgretmen p)
        {
            bool dif = true;
            SqlCommand komut = new SqlCommand("Select * from TBLOGRETMEN", Baglanti.bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                if (p.OgrtNumara == satir["OGRTNUMARA"].ToString())
                {
                    dif = false;
                    break;
                }
            }
            if (dif != false)
            {
                if (p.OgrtAd != null && p.OgrtAd != "" && p.OgrtDersAd != null && p.OgrtDersAd != "" && p.OgrtNumara != null && p.OgrtNumara != "" && p.OgrtSifre != null && p.OgrtSifre != "")
                {
                    return DALOgretmen.OgretmenEkle(p);
                }
            }
            return -1;
        }
        public static List<EntityOgretmen> OgretmenListeleBLL()
        {
            return DALOgretmen.OgretmenListesi(true, 0);
        }
        public static bool OgretmenSilBLL(int p)
        {
            if (p > 0)
            {
                return DALOgretmen.OgretmenSil(p);
            }
            return false;
        }
        public static bool OgretmenGuncelleBLL(EntityOgretmen p)
        {
            int dersid = 0;
            SqlCommand komut = new SqlCommand("Select * from TBLDERSLER where DERSAD=@ad", Baglanti.bgl);
            komut.Parameters.AddWithValue("@ad", p.OgrtDersAd);

            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                dersid = Convert.ToInt32(satir["DERSID"].ToString());
            }

            if (p.OgrtAd != null && p.OgrtAd != "" && p.OgrtDersAd != null && p.OgrtDersAd != "" && p.OgrtNumara != null && p.OgrtNumara != "" && p.OgrtSifre != null && p.OgrtSifre != "" && p.OgrtId > 0 )
            {
                return DALOgretmen.OgretmenGuncelle(p, dersid);
            }
            return false;
        }
        public static List<EntityOgretmen> OgretmenDetayBLL(int p)
        {
            return DALOgretmen.OgretmenListesi(false, p);
        }
    }
}
