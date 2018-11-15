using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Frontend_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ingresarB_Click(object sender, EventArgs e)
    {
        if (usuarioTB.Text != "" && contrasenaTB.Text != "")
        {
            Login encapsular = new Login();
            Datos funcion = new Datos();
            DataTable usuarioValido = new DataTable();
            DataTable validar = new DataTable();
            encapsular.Usuario = usuarioTB.Text;
            encapsular.Contrasena = contrasenaTB.Text;
            
            
            usuarioValido = funcion.login(encapsular);
            
            if (usuarioValido.Rows.Count>0)
            {
                validar = funcion.validar_bloqueo();

                if (Boolean.Parse(usuarioValido.Rows[0]["bloqueo"].ToString()) == false)
                {

                    noValidoL.Text = "estas bloqueado";
                    noValidoL.Visible = true;

                    //Response.Redirect("login.aspx");
                }
                else
                {
                    Session["usuario"] = usuarioValido.Rows[0]["user_name"].ToString();
                    Session["cedula"] = usuarioValido.Rows[0]["cedula"].ToString();
                    Session["nombres"] = usuarioValido.Rows[0]["nombres"].ToString();
                    Session["correo"] = usuarioValido.Rows[0]["correo"].ToString();
                    Session["rol"] = usuarioValido.Rows[0]["id_rol"].ToString();
                    Session["estado"] = usuarioValido.Rows[0]["bloqueo"].ToString();
                    Session["fechaEntrada"] = usuarioValido.Rows[0]["fecha_ingreso"].ToString();

                    Response.Redirect("~/View/Frontend/index.aspx");
                }
                
            }


            else
            {
                noValidoL.Text = "Usuario o contraseña no validos";
                noValidoL.Visible = true;
            }
        }
        else
        {
            noValidoL.Text = "Llene primero todos los campos";
            noValidoL.Visible = true;
        }
       
    }
}