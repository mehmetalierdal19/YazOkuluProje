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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DropDownList1.DataSource = BLLDers.DersListeleBLL();
                DropDownList1.DataTextField = "Dersad";
                DropDownList1.DataValueField = "DersId";
                DropDownList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BasOgrId = Convert.ToInt32(TextBox1.Text);
            ent.BasDersId = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            BLLDers.TalepEkleBLL(ent);
        }
    }
}