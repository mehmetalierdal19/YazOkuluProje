﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLLBasvuru
    {
        public static int BasvuruEkleBLL(EntityBasvuruForm p)
        {
            return DALBasvuru.BasvuruEkle(p);
        }
        public static List<EntityBasvuruForm> AlinanDersListeleBLL(string no)
        {
            return DALBasvuru.AlinanDersListe(no);
        }
        public static int BasvuruSilBLL(int id)
        {
            return DALBasvuru.BasvuruSil(id);
        }
    }
}
