using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Mail != null && p.Sifre != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBLL(int p)
        {
            if (p > 0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> OgrenciDetayBLL(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Ad !="" && p.Soyad !="" && p.Soyad != null && p.Numara !="" && p.Numara != null && p.Mail !="" && p.Mail != null && p.Sifre !="" && p.Sifre != null && p.OgrId > 0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
