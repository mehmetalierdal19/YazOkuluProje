using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> DersListeleBLL()
        {
            return DALDers.DersListesi();
        }
        public static List<EntityDers> DersDetayleBLL(int p)
        {
            return DALDers.DersDetay(p);
        }
        //public static int TalepEkleBLL(EntityBasvuruForm p)
        //{
        //    if(p.BasDersId > 0  && p.BasOgrId > 0)
        //    {
        //        return DALDers.TalepEkle(p);
        //    }
        //    return -1;
        //}
        public static bool DersDurumGuncelleBLL(bool x, int id)
        {
            return DALDers.DersDurumGuncelle(x, id);
        }
        public static bool DurumGuncelle(bool x)
        {
            return DALDers.DurumGuncelle(x);
        }
        public static bool DersSil(int id)
        {
            if(id > 0)
            {
                return DALDers.DersSil(id);
            }
            return false;
        }
        public static int DersEkleBLL(EntityDers p)
        {
            bool dif = true;
            SqlCommand komut = new SqlCommand("Select * from TBLDERSLER", Baglanti.bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                if (p.Dersad == satir["DERSAD"].ToString())
                {
                    dif = false;
                    break;
                }
            }
            if (dif != false)
            {
                if (p.Dersad != null && p.Dersad != "" && p.Max > 0  && p.Min > 0)
                {
                    return DALDers.DersEkle(p);
                }
            }
            return -1;
        }
        public static bool DersGuncelleBLL(EntityDers p)
        {
            if (p.Dersad != null && p.Dersad != "" && p.Max > 0 && p.Min > 0)
            {
                return DALDers.DersGuncelle(p);
            }
            return false;
        }
    }
}
