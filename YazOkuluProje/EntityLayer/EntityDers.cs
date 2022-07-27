using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDers
    {
        private string dersad;
        private int min;
        private int max;
        private int dersid;
        private int kontdurum;
        private double dersbakiye;
        private string dersdurum;

        public string Dersad { get => dersad; set => dersad = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
        public int DersId { get => dersid; set => dersid = value; }
        public int KontDurum { get => kontdurum; set => kontdurum = value; }
        public double DersBakiye { get => dersbakiye; set => dersbakiye = value; }
        public string DersDurum { get => dersdurum; set => dersdurum = value; }
    }
}
