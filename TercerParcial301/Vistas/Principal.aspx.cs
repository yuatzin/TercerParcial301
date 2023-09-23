using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TercerParcial301.Vistas
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sessionTipo = Convert.ToString(Session["Tipo"]);
            if (Session["Tipo"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string sessionTipo = Convert.ToString(Session["Tipo"]);
            if (sessionTipo.Equals("4") || sessionTipo.Equals("7"))
            {
                Response.Redirect("AltaPersonal.aspx");
            }
            else
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string sessionTipo = Convert.ToString(Session["Tipo"]);
            if (sessionTipo.Equals("8") || sessionTipo.Equals("6") || sessionTipo.Equals("7"))
            {
                Response.Redirect("RegistroVenta.aspx");

            }
            else
            {
                // Label2.Text = "Solo el profesor tiene acceso";
                Response.Redirect("Error.aspx");
            }

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            string sessionTipo = Convert.ToString(Session["Tipo"]);
            if (sessionTipo.Equals("6")  || sessionTipo.Equals("7"))
            {
                Response.Redirect("Cancelaciones.aspx");
            }
            else
            {
               // Label2.Text = "Solo el adminitrador tiene acceso";

                Response.Redirect("Error.aspx");
            }

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            string sessionTipo = Convert.ToString(Session["Tipo"]);
            if (sessionTipo.Equals("4") || sessionTipo.Equals("8") || sessionTipo.Equals("7"))
            {
                Response.Redirect("AltaProducto.aspx");
            }
            else
            {
                // Label2.Text = "Solo el adminitrador tiene acceso";

                Response.Redirect("Error.aspx");
            }

        }
    }
}