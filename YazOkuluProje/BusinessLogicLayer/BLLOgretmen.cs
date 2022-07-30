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
    }
}
