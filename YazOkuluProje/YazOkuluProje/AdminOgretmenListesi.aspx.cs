using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace YazOkuluProje
{
    public partial class AdminOgretmenListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgretmen> OgrList = BLLOgretmen.OgretmenListeleBLL();
            Repeater1.DataSource = OgrList;
            Repeater1.DataBind();
        }
    }
}