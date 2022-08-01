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
    public class BLLBasvuru
    {
        public static int BasvuruEkleBLL(EntityBasvuruForm p)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLBASVURUFORM", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                if (GirisBilgileri.No == satir["OGRNUMARA"].ToString() && p.BasDersId == int.Parse( satir["DERSID"].ToString()))
                {
                    GirisBilgileri.BuDegerVarMi = true;
                }
            }

            if(GirisBilgileri.BuDegerVarMi == false)
            {
                return DALBasvuru.BasvuruEkle(p);
            }

            return -1;
            
        }
        public static List<EntityBasvuruForm> AlinanDersListeleBLL(string no)
        {
            return DALBasvuru.AlinanDersListe(no);
        }
        public static int BasvuruSilBLL(int id)
        {
            return DALBasvuru.BasvuruSil(id);
        }
        public static List<EntityBasvuruForm> BasvuruListeleBLL(int id)
        {
            return DALBasvuru.BasvuruListele(id);
        }
    }
}
