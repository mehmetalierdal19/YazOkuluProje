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
    }
}
