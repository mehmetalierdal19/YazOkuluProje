﻿using System;
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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrId"]);
            Response.Write(x);
            EntityOgrenci ent = new EntityOgrenci();
            ent.OgrId = x;
            BLLOgrenci.OgrenciSilBLL(ent.OgrId);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}