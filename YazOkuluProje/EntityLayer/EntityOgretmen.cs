using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        public int ogrtid;
        public string ogrtad;
        public int ogrtdersid;
        public string ogrtnumara;
        public string ogrtsifre;
        public string ogrtdersad;

        public int OgrtId { get => ogrtid; set => ogrtid = value; }
        public string OgrtAd { get => ogrtad; set => ogrtad = value; }
        public string OgrtNumara { get => ogrtnumara; set => ogrtnumara = value; }
        public string OgrtSifre { get => ogrtsifre; set => ogrtsifre = value; }
        public int OgrtDersId { get => ogrtdersid; set => ogrtdersid = value; }
        public string OgrtDersAd { get => ogrtdersad; set => ogrtdersad = value; }
    }
}
