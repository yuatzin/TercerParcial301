using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TercerParcial301.Controladores;

namespace TercerParcial301.Vistas
{
    public partial class login : System.Web.UI.Page
    {
        Metodos pro5 = new Metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           string[] tipo;

            if ((TextBox1.Text == "") & (TextBox2.Text == ""))
            {
                Label3.Text = "Proporcione correctamente los datos ";
                 
            }
            else
            {
                try
                {
                    tipo = pro5.buscarusuario(TextBox1.Text, TextBox2.Text);

                    if (tipo[0] != "vacio")
                    {
                        
                        Session["Usuario"] = tipo[0];
                        Session["Tipo"] = tipo[1];
                        Response.Redirect("Principal.aspx");

                    }
                    else
                    {
                        Label3.Text = "El usuario no esta registrado";
                    }

                }
                catch (Exception)
                {
                    Label3.Text = " Ha ocurrido un error, verifique los datos";
                }
            }

        }
    }
}