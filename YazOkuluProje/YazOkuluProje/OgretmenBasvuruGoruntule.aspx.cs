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
    public partial class OgretmenBasvuruGoruntule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["DersId"].ToString());
            List<EntityBasvuruForm> DrsList = BLLBasvuru.BasvuruListeleBLL(id);
            Repeater1.DataSource = DrsList;
            Repeater1.DataBind();
        }
    }
}