using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityAdmin
    {
        public int adminid;
        public string kullaniciadi;
        public string sifre;

        public int AdminId { get => adminid; set => adminid = value; }
        public string KullaniciAdi { get => kullaniciadi; set => kullaniciadi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}
