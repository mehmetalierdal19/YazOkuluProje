using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;

namespace YazOkuluProje
{
    public partial class AdminListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityAdmin> adminlist = BLLAdmin.AdminListeleBLL();
            Repeater1.DataSource = adminlist;
            Repeater1.DataBind();
        }
    }
}