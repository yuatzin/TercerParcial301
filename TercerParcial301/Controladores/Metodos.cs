using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security;
using System.Security.Cryptography;
using System.Text;



namespace TercerParcial301.Controladores
{
    public class Metodos
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ycort\source\repos\TercerParcial301\TercerParcial301\App_Data\Database1.mdf;Integrated Security = True";
        SqlConnection conn = new SqlConnection(connectionString);

        public string insertarusuario(string data1, int data2, string data4)
        {
            
            int result = 0;
            string mensaje = "";
            string insert1 = "insert into usuario values (@Usuario,@Tipo,@Claveu)";
            SqlCommand myCommand1 = new SqlCommand(insert1, conn);
            myCommand1.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = data1;
           
            myCommand1.Parameters.Add("@Tipo", SqlDbType.Int).Value = data2;
            string dat3 = EncriptarClave(data4);
            myCommand1.Parameters.Add("@Claveu", SqlDbType.VarChar).Value = data4;
            

            conn.Open();
            try
            {
                result = myCommand1.ExecuteNonQuery();
            }
            catch (Exception)
            {
                mensaje = "Ha ocurrido un error, verifique los datos";
            }
            if (result != 0)
            {
                mensaje = "Se Insertaron los datos del usuario correctamente";
            }
            else
            {
                mensaje = "No se inserto el usuario, verifique los datos";
            }
            conn.Close();
            return mensaje;

        }
        public static string EncriptarClave(string originalPassword)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] inputByte = Encoding.UTF8.GetBytes(originalPassword); 
            byte[] hash = sha1.ComputeHash(inputByte);

             return Convert.ToBase64String(hash);
        }


        public string[] buscarusuario(string data1, string data2)
        {
            string[] tipo = new string[2];
            tipo[0] = "vacio";
            tipo[1] = "vacio";

            string mensaje = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd2 = new SqlCommand("Select u.Usuario, u.Tipo, t.Nombre from usuario u, TipoUsuario t where u.Usuario = @d1 and u.Claveu=@d2  and u.tipo=t.IdTipo", conn);


                    cmd2.Parameters.Add("@d1", SqlDbType.VarChar).Value = data1;
                    string data3 = EncriptarClave(data2);
                    cmd2.Parameters.Add("@d2", SqlDbType.VarChar).Value = data3;

                    SqlDataReader myreader3 = cmd2.ExecuteReader();
                    if (myreader3.Read())
                    {
                        tipo[0] = myreader3[0].ToString();
                        tipo[1] = myreader3[1].ToString();
                        tipo[2] = myreader3[2].ToString();
                    }
                    myreader3.Close();
                }
            }
            catch (Exception)
            {
                mensaje = "No se encontraron datos de usuario";
            }

            return tipo;
        }









    }
}