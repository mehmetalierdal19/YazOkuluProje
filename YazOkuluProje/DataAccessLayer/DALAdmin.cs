using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALAdmin
    {
        public static int AdminEkle(EntityAdmin p)
        {
            SqlCommand komut = new SqlCommand("Insert into TBLADMIN (KULLANICIADI, SIFRE) values (@p1, @p2)", Baglanti.bgl);

            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1", p.KullaniciAdi);
            komut.Parameters.AddWithValue("@p2", p.Sifre);

            return komut.ExecuteNonQuery();
        }
        public static List<EntityAdmin> AdminGiris(string kullaniciadi)
        {
            List<EntityAdmin> degerler = new List<EntityAdmin>();

            SqlCommand komut = new SqlCommand("Select * from TBLADMIN where KULLANICIADI = @ad", Baglanti.bgl);
            komut.Parameters.AddWithValue("@ad", SqlDbType.NVarChar).Value = kullaniciadi.ToString();

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                EntityAdmin ent = new EntityAdmin();

                ent.AdminId = int.Parse(dr["ADMINID"].ToString());
                AdminGirisBilgileri.adminid = ent.AdminId;
                ent.KullaniciAdi = dr["KULLANICIADI"].ToString();
                AdminGirisBilgileri.kullaniciadi = ent.KullaniciAdi;
                ent.Sifre = dr["SIFRE"].ToString();
                AdminGirisBilgileri.sifre = ent.Sifre;

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool AdminGuncelle(EntityAdmin deger)
        {
            SqlCommand komut = new SqlCommand("update TBLADMIN set KULLANICIADI=@ad, SIFRE=@sifre where ADMINID=@id", Baglanti.bgl);

            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@ad", deger.KullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", deger.Sifre);
            komut.Parameters.AddWithValue("@id", deger.AdminId);

            return komut.ExecuteNonQuery() > 0;
        }

        public static bool AdminSil(int id)
        {
            SqlCommand komut = new SqlCommand("delete from TBLADMIN where ADMINID=@id", Baglanti.bgl);

            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@id", id);

            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityAdmin> AdminListele()
        {
            List<EntityAdmin> degerler = new List<EntityAdmin>();

            SqlCommand komut = new SqlCommand("Select * from TBLADMIN", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                EntityAdmin ent = new EntityAdmin();
                ent.AdminId = Convert.ToInt32(dr["ADMINID"].ToString());
                ent.KullaniciAdi = dr["KULLANICIADI"].ToString();
                ent.Sifre = dr["SIFRE"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static List<EntityAdmin> AdminDetay(string kullaniciadi)
        {
            List<EntityAdmin> degerler = new List<EntityAdmin>();

            SqlCommand komut = new SqlCommand("Select * from TBLADMIN where KULLANICIADI = @ad", Baglanti.bgl);
            komut.Parameters.AddWithValue("@ad", SqlDbType.NVarChar).Value = kullaniciadi.ToString();

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                EntityAdmin ent = new EntityAdmin();

                ent.AdminId = int.Parse(dr["ADMINID"].ToString());
                ent.KullaniciAdi = dr["KULLANICIADI"].ToString();
                ent.Sifre = dr["SIFRE"].ToString();

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
