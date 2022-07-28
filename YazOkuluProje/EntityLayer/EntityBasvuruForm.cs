using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruid;
        private int basdersid;
        private string basdersad;
        private string basograd;
        private string basogrno;
        private string basdersdurum;
        private double basdersucret;

        public int BasvuruId { get => basvuruid; set => basvuruid = value; }
        public int BasDersId { get => basdersid; set => basdersid = value; }
        public string BasDersAd { get => basdersad; set => basdersad = value; }
        public string BasOgrAd { get => basograd; set => basograd = value; }
        public string BasOgrNo { get => basogrno; set => basogrno = value; }
        public string BasDersDurum { get => basdersdurum; set => basdersdurum = value; }
        public double BasDersUcret { get => basdersucret; set => basdersucret = value; }
    }
}
