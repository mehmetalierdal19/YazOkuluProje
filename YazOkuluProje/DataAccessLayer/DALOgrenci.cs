using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (OGRAD, OGRSOYAD, OGRNUMARA, OGRMAIL, OGRSIFRE) values (@ad, @soyad, @no, @mail, @sifre)", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            komut1.Parameters.AddWithValue("@ad", parametre.Ad);
            komut1.Parameters.AddWithValue("@soyad", parametre.Soyad);
            komut1.Parameters.AddWithValue("@no", parametre.Numara);
            komut1.Parameters.AddWithValue("@mail", parametre.Mail);
            komut1.Parameters.AddWithValue("@sifre", parametre.Sifre);

            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * from TBLOGRENCI", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OgrId = Convert.ToInt32(dr["OGRID"].ToString());
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Mail = dr["OGRMAIL"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete from TBLOGRENCI where OGRID=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select * from TBLOGRENCI where OGRID=@p1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Mail = dr["OGRMAIL"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("update TBLOGRENCI set OGRAD=@ad, OGRSOYAD=@soyad, OGRNUMARA=@numara, OGRMAIL=@mail, OGRSIFRE=@sifre where OGRID=@id", Baglanti.bgl);
            if(komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@ad", deger.Ad);
            komut5.Parameters.AddWithValue("@soyad", deger.Soyad);
            komut5.Parameters.AddWithValue("@numara", deger.Numara);
            komut5.Parameters.AddWithValue("@mail", deger.Mail);
            komut5.Parameters.AddWithValue("@sifre", deger.Sifre);
            komut5.Parameters.AddWithValue("@id", deger.OgrId);
            return komut5.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciGirisBilgi(int no)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("Select * from TBLOGRENCI where OGRNUMARA=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", no);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Mail = dr["OGRMAIL"].ToString();
                //ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Numara = no.ToString();
                GirisBilgileri.No = no.ToString();
                //ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                GirisBilgileri.Pass = ent.sifre;
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
