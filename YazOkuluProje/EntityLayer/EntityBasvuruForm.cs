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

        public int BasvuruId { get => basvuruid; set => basvuruid = value; }
        public int BasDersId { get => basdersid; set => basdersid = value; }
        public string BasDersAd { get => basdersad; set => basdersad = value; }
        public string BasOgrAd { get => basograd; set => basograd = value; }
        public string BasOgrNo { get => basogrno; set => basogrno = value; }
    }
}
