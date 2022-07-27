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
            SqlCommand komut = new SqlCommand("Insert into TBLBASVURUFORM (OGRAD, OGRNUMARA, DERSAD, DERSID) values (@ad, @no, @dersad, @dersid)", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@ad", p.BasOgrAd);
            komut.Parameters.AddWithValue("@no", p.BasOgrNo);
            komut.Parameters.AddWithValue("@dersad", p.BasDersAd);
            komut.Parameters.AddWithValue("@dersid", p.BasDersId);

            return komut.ExecuteNonQuery();
        }
    }
}
