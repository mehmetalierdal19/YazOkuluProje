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
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select * from TBLDERSLER", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DersId = Convert.ToInt32(dr["DERSID"].ToString());
                ent.Dersad = dr["DERSAD"].ToString();
                ent.Max = Convert.ToInt32(dr["DERSMAKSKONT"].ToString());
                ent.Min = Convert.ToInt32(dr["DERSMINKONT"].ToString());
                ent.DersBakiye = Convert.ToDouble(dr["DERSBAKIYE"].ToString());
                ent.KontDurum = Convert.ToInt32(dr["KONTDURUM"].ToString());
                ent.DersDurum = dr["DURUM"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool DersSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete from TBLDERSLER where DERSID=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool DersGuncelle(EntityDers deger)
        {
            SqlCommand komut5 = new SqlCommand("update TBLDERSLER set DERSAD=@ad, DERSMINKONT=@min, DERSMAKSKONT=@max, DURUM=@durum, DERSBAKIYE=@bakiye where DERSID=@id", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@ad", deger.Dersad);
            komut5.Parameters.AddWithValue("@min", deger.Min);
            komut5.Parameters.AddWithValue("@max", deger.Max);
            komut5.Parameters.AddWithValue("@durum", deger.DersDurum);
            komut5.Parameters.AddWithValue("@bakiye", deger.DersBakiye);
            komut5.Parameters.AddWithValue("@id", deger.DersId);

            return komut5.ExecuteNonQuery() > 0;
        }
        public static int DersEkle(EntityDers p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLDERSLER (DERSAD, DERSMINKONT, DERSMAKSKONT, DERSBAKIYE) values (@ad, @min, @max, @bakiye)", Baglanti.bgl);

            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@ad", p.Dersad);
            komut.Parameters.AddWithValue("@min", p.Min);
            komut.Parameters.AddWithValue("@max", p.Max);
            komut.Parameters.AddWithValue("@bakiye", p.DersBakiye);

            return komut.ExecuteNonQuery();
        }
        public static int TalepEkle(EntityBasvuruForm p)
        {
            SqlCommand komut = new SqlCommand("Insert into TBLBASVURUFORM (OGRENCIID, DERSID) values (@oid, @did)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@oid", p.BasOgrNo);
            komut.Parameters.AddWithValue("@did", p.BasDersId);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
        public static List<EntityDers> DersDetay(int p)
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select * from TBLDERSLER where DERSID=@id", Baglanti.bgl);
            komut.Parameters.AddWithValue("@id", p);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DersId = Convert.ToInt32(dr["DERSID"].ToString());
                ent.Dersad = dr["DERSAD"].ToString();
                ent.Max = Convert.ToInt32(dr["DERSMAKSKONT"].ToString());
                ent.Min = Convert.ToInt32(dr["DERSMINKONT"].ToString());
                ent.DersBakiye = Convert.ToDouble(dr["DERSBAKIYE"].ToString());
                ent.KontDurum = Convert.ToInt32(dr["KONTDURUM"].ToString());
                ent.DersDurum = dr["DURUM"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool DersDurumGuncelle(bool x, int id)
        {
            EntityDers ent = new EntityDers();
            if (x == true)
            {
                SqlCommand komut = new SqlCommand("update TBLDERSLER set KONTDURUM=KONTDURUM + 1 where DERSID=@id", Baglanti.bgl);
                ent.KontDurum += 1;
                komut.Parameters.AddWithValue("@id", id);
                return komut.ExecuteNonQuery() > 0;
            }
            else if (x == false)
            {
                SqlCommand komut2 = new SqlCommand("update TBLDERSLER set KONTDURUM=KONTDURUM - 1 where DERSID=@id", Baglanti.bgl);
                ent.KontDurum -= 1;
                komut2.Parameters.AddWithValue("@id", id);
                return komut2.ExecuteNonQuery() > 0;
            }
            else
            {
                return false;
            }
        }
        public static bool DurumGuncelle(bool x)
        {
            if(x == true)
            {
                SqlCommand komut = new SqlCommand("Update TBLDERSLER set DURUM=@durum where DERSID=@id", Baglanti.bgl);
                komut.Parameters.AddWithValue("@durum", SqlDbType.NVarChar).Value = "Aktif";
                komut.Parameters.AddWithValue("@id", OgrtGirisBilgileri.ogrtdersid);

                return komut.ExecuteNonQuery() > 0;
            }
            else if(x == false)
            {
                SqlCommand komut2 = new SqlCommand("update TBLDERSLER set DURUM=@durum where DERSID=@id", Baglanti.bgl);
                komut2.Parameters.AddWithValue("@durum", SqlDbType.NVarChar).Value = "Pasif";
                komut2.Parameters.AddWithValue("@id", OgrtGirisBilgileri.ogrtdersid);

                return komut2.ExecuteNonQuery() > 0;
            }
            else
            {
                return false;
            }
        }
    }
}
