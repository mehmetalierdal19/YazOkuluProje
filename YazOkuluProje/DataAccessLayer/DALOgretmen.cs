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
    public class DALOgretmen
    {
        public static List<EntityOgretmen> OgretmenGirisBilgi(int no)
        {
            List<EntityOgretmen> degerler = new List<EntityOgretmen>();
            SqlCommand komut = new SqlCommand("Select * from TBLOGRETMEN where OGRTNUMARA=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", no);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.OgrtAd = dr["OGRTADSOYAD"].ToString();
                OgrtGirisBilgileri.ogrtad = ent.OgrtAd;
                ent.OgrtDersAd = dr["OGRTDERS"].ToString();
                OgrtGirisBilgileri.ogrtders = ent.OgrtDersAd;
                ent.OgrtDersId =int.Parse( dr["OGRTDERSID"].ToString());
                OgrtGirisBilgileri.ogrtdersid = ent.OgrtDersId;
                ent.OgrtId =int.Parse(dr["OGRTID"].ToString());
                OgrtGirisBilgileri.ogrtid = ent.OgrtId;
                ent.OgrtNumara = no.ToString();
                OgrtGirisBilgileri.ogrtno = no.ToString();
                ent.OgrtSifre =dr["OGRTSIFRE"].ToString();
                OgrtGirisBilgileri.ogrtsifre = ent.OgrtSifre;
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool SifreDegis(string pass)
        {
            if(GirisBilgileri.Pass != null && GirisBilgileri.Pass != "")
            {
                SqlCommand komut = new SqlCommand("Update TBLOGRENCI set OGRSIFRE=@sifre where OGRNUMARA=@no", Baglanti.bgl);
                komut.Parameters.AddWithValue("@sifre", pass);
                GirisBilgileri.Pass = pass;
                komut.Parameters.AddWithValue("@no", GirisBilgileri.No);

                return komut.ExecuteNonQuery() > 0;
            }
            else if(OgrtGirisBilgileri.ogrtsifre != null && OgrtGirisBilgileri.ogrtsifre != "")
            {
                SqlCommand komut2 = new SqlCommand("Update TBLOGRETMEN set OGRTSIFRE =@sifre where OGRTNUMARA=@no", Baglanti.bgl);
                komut2.Parameters.AddWithValue("@sifre", pass);
                OgrtGirisBilgileri.ogrtsifre = pass;
                komut2.Parameters.AddWithValue("@no", OgrtGirisBilgileri.ogrtno);

                return komut2.ExecuteNonQuery() > 0;
            }
            else
            {
                return false;
            }
        }
        public static bool OgretmenGuncelle(EntityOgretmen deger, int id)
        {
            SqlCommand komut = new SqlCommand("update TBLOGRETMEN set OGRTADSOYAD=@ad, OGRTDERSID=@dersid, OGRTDERS=@ders, OGRTNUMARA=@no, OGRTSIFRE=@sifre where OGRTID=@id", Baglanti.bgl);

            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@ad", deger.OgrtAd);
            komut.Parameters.AddWithValue("@dersid", id);
            komut.Parameters.AddWithValue("@ders", deger.OgrtDersAd);
            komut.Parameters.AddWithValue("@no", deger.OgrtNumara);
            komut.Parameters.AddWithValue("@sifre", deger.OgrtSifre);
            komut.Parameters.AddWithValue("@id", deger.OgrtId);

            return komut.ExecuteNonQuery() > 0;
        }
        public static bool OgretmenSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete from TBLOGRETMEN where OGRTID=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static int OgretmenEkle(EntityOgretmen parametre)
        {
            int dersid = 0;
            SqlCommand komut = new SqlCommand("Select * from TBLDERSLER where DERSAD=@ad", Baglanti.bgl);
            komut.Parameters.AddWithValue("@ad", parametre.OgrtDersAd);

            if (komut.Connection.State != ConnectionState.Open)
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

            SqlCommand komut1 = new SqlCommand("insert into TBLOGRETMEN (OGRTADSOYAD, OGRTDERSID, OGRTDERS, OGRTNUMARA, OGRTSIFRE) values (@ad, @dersid, @ders, @no, @sifre)", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            komut1.Parameters.AddWithValue("@ad", parametre.OgrtAd);
            komut1.Parameters.AddWithValue("@dersid", dersid);
            komut1.Parameters.AddWithValue("@ders", parametre.OgrtDersAd);
            komut1.Parameters.AddWithValue("@no", parametre.OgrtNumara);
            komut1.Parameters.AddWithValue("@sifre", parametre.OgrtSifre);

            return komut1.ExecuteNonQuery();
        }
        public static List<EntityOgretmen> OgretmenListesi(bool x, int id)
        {
            if(x == true)
            {
                List<EntityOgretmen> degerler = new List<EntityOgretmen>();
                SqlCommand komut2 = new SqlCommand("Select * from TBLOGRETMEN", Baglanti.bgl);
                if (komut2.Connection.State != ConnectionState.Open)
                {
                    komut2.Connection.Open();
                }
                SqlDataReader dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    EntityOgretmen ent = new EntityOgretmen();
                    ent.OgrtId = Convert.ToInt32(dr["OGRTID"].ToString());
                    ent.OgrtAd = dr["OGRTADSOYAD"].ToString();
                    ent.OgrtDersId = Convert.ToInt32(dr["OGRTDERSID"].ToString());
                    ent.OgrtDersAd = dr["OGRTDERS"].ToString();
                    ent.OgrtNumara = dr["OGRTNUMARA"].ToString();
                    ent.OgrtSifre = dr["OGRTSIFRE"].ToString();
                    degerler.Add(ent);
                }
                dr.Close();
                return degerler;
            }
            else
            {
                List<EntityOgretmen> degerler = new List<EntityOgretmen>();
                SqlCommand komut2 = new SqlCommand("Select * from TBLOGRETMEN where OGRTID=@id", Baglanti.bgl);
                komut2.Parameters.AddWithValue("@id", id);
                if (komut2.Connection.State != ConnectionState.Open)
                {
                    komut2.Connection.Open();
                }
                SqlDataReader dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    EntityOgretmen ent = new EntityOgretmen();
                    ent.OgrtId = Convert.ToInt32(dr["OGRTID"].ToString());
                    ent.OgrtAd = dr["OGRTADSOYAD"].ToString();
                    ent.OgrtDersId = Convert.ToInt32(dr["OGRTDERSID"].ToString());
                    ent.OgrtDersAd = dr["OGRTDERS"].ToString();
                    ent.OgrtNumara = dr["OGRTNUMARA"].ToString();
                    ent.OgrtSifre = dr["OGRTSIFRE"].ToString();
                    degerler.Add(ent);
                }
                dr.Close();
                return degerler;
            }
            
        }
    }
}
