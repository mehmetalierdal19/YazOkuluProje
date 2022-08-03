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
    }
}
