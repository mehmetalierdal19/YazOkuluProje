using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

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
    }
}
