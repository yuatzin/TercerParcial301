﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TercerParcial301.Vistas
{
    public partial class AltaProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sessionTipo = Convert.ToString(Session["Tipo"]);
            if (!sessionTipo.Equals("4") && !sessionTipo.Equals("8") && !sessionTipo.Equals("7"))
            {
                Response.Redirect("Error.aspx");
            }


        }
    }
}