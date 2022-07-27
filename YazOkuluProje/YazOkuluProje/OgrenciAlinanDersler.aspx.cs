using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluProje
{
    public partial class OgrenciAlinanDersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityBasvuruForm> DrsList = BLLBasvuru.AlinanDersListeleBLL(GirisBilgileri.No);
            Repeater1.DataSource = DrsList;
            Repeater1.DataBind();
        }
    }
}