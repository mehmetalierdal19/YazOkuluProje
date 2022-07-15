using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityBasvuruForm
    {
        private int basvuruid;
        private int basdersid;
        private int basogrid;

        public int BasvuruId { get => basvuruid; set => basvuruid = value; }
        public int BasDersId { get => basdersid; set => basdersid = value; }
        public int BasOgrId { get => basogrid; set => basogrid = value; }
    }
}
