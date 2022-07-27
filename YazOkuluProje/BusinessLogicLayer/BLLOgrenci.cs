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
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            //if (p.Ad != null && p.Ad != "" && p.Soyad != null && p.Soyad != "" && p.Numara != null && p.Numara != "" && p.Mail != null && p.Mail != "" && p.Sifre != null && p.Sifre != "")
            //{
            //    return DALOgrenci.OgrenciEkle(p);
            //}
            //return -1;
            bool dif = true;
            SqlCommand komut = new SqlCommand("Select * from TBLOGRENCI", Baglanti.bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                if (p.Numara == satir["OGRNUMARA"].ToString())
                {
                    dif = false;
                    break;
                }
            }
            if(dif != false)
            {
                if (p.Ad != null && p.Ad != "" && p.Soyad != null && p.Soyad != "" && p.Numara != null && p.Numara != "" && p.Mail != null && p.Mail != "" && p.Sifre != null && p.Sifre != "")
                {
                    return DALOgrenci.OgrenciEkle(p);
                }
            }
            return -1;
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBLL(int p)
        {
            if (p > 0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> OgrenciDetayBLL(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Ad != "" && p.Soyad != "" && p.Soyad != null && p.Numara != "" && p.Numara != null && p.Mail != "" && p.Mail != null && p.Sifre != "" && p.Sifre != null && p.OgrId > 0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }

        public static List<EntityOgrenci> OgrenciBilgiBLL(int p, string pass)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLOGRENCI", Baglanti.bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                if(p.ToString() == satir["OGRNUMARA"].ToString() && pass.ToString() == satir["OGRSIFRE"].ToString())
                {
                    return DALOgrenci.OgrenciGirisBilgi(p);
                    
                }
            }
            return DALOgrenci.OgrenciGirisBilgi(-1);
        }
        public static bool BakiyeYuklemeBLL(double bakiye)
        {
            return DALOgrenci.BakiyeYukle(bakiye);
        }
    }
}
