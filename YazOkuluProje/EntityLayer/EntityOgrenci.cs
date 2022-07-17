using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        public string ad;
        public string soyad;
        public int ogrid;
        public string numara;
        public string mail;
        public double bakiye;
        public string sifre;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int OgrId { get => ogrid; set => ogrid = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Mail { get => mail; set => mail = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}
