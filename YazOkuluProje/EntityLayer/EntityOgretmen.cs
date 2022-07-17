using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtad;
        private int ogrtbrans;
        private string ogrtnumara;
        private string ogrtsifre;

        public int OgrtId { get => ogrtid; set => ogrtid = value; }
        public string OgrtAd { get => ogrtad; set => ogrtad = value; }
        public int OgrtBrans { get => ogrtbrans; set => ogrtbrans = value; }
        public string Ogrtnumara { get => ogrtnumara; set => ogrtnumara = value; }
        public string Ogrtsifre { get => ogrtsifre; set => ogrtsifre = value; }
    }
}
