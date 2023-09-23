using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using TercerParcial301.Controladores;

namespace TercerParcial301.Vistas
{
    public partial class Registro : System.Web.UI.Page
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ycort\source\repos\TercerParcial301\TercerParcial301\App_Data\Database1.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        Metodos metodos = new Metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDropDownList1();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();
            string resultado = metodos.insertarusuario(TextBox4.Text, int.Parse(DropDownList1.SelectedValue.ToString()), TextBox5.Text);
            Label6.Text = resultado;

        }
        protected void CargarDropDownList1()
        {
            string com = "Select * from TipoUsuario";
            SqlDataAdapter adtp = new SqlDataAdapter(com, conn);
            DataTable dt = new DataTable();
            adtp.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "Nombre";
            DropDownList1.DataValueField = "IdTipo";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("Tipo de usuario", "-1"));



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string claveEncriptada = Metodos.EncriptarClave(TextBox2.Text);

            TextBox5.Text = claveEncriptada;
           

        }
    }
}