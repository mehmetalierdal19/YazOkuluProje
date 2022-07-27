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
    public class DALBasvuru
    {
        public static int BasvuruEkle(EntityBasvuruForm p)
        {
            SqlCommand komut = new SqlCommand("Insert into TBLBASVURUFORM (OGRAD, OGRNUMARA, DERSAD, DERSID, DERSDURUM) values (@ad, @no, @dersad, @dersid, @durum)", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@ad", p.BasOgrAd);
            komut.Parameters.AddWithValue("@no", p.BasOgrNo);
            komut.Parameters.AddWithValue("@dersad", p.BasDersAd);
            komut.Parameters.AddWithValue("@dersid", p.BasDersId);
            komut.Parameters.AddWithValue("@durum", p.BasDersDurum);

            return komut.ExecuteNonQuery();
        }
        public static List<EntityBasvuruForm> AlinanDersListe(string no)
        {
            List<EntityBasvuruForm> degerler = new List<EntityBasvuruForm>();
            SqlCommand komut = new SqlCommand("Select * from TBLBASVURUFORM where OGRNUMARA=@no", Baglanti.bgl);
            komut.Parameters.AddWithValue("@no", no);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityBasvuruForm ent = new EntityBasvuruForm();
                ent.BasvuruId = Convert.ToInt32(dr["BASVURUID"].ToString());
                ent.BasDersAd = dr["DERSAD"].ToString();
                ent.BasDersDurum = dr["DERSDURUM"].ToString();
                ent.BasDersId = Convert.ToInt32(dr["DERSID"].ToString());
                ent.BasOgrAd = dr["OGRAD"].ToString();
                ent.BasOgrNo = dr["OGRNUMARA"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
