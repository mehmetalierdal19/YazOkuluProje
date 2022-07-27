using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;

namespace YazOkuluProje
{
    public partial class OgrenciDersListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDers> DrsList = BLLDers.DersListeleBLL();
            Repeater1.DataSource = DrsList;
            Repeater1.DataBind();
        }
    }
}