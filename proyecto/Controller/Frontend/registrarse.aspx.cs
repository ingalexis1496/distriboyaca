using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Frontend_registrarse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void registrarseB_Click(object sender, EventArgs e)
    {
        if (nombresTB.Text != "" && userNameTB.Text != "" && telefonoTB.Text != "" && correoTB.Text != ""  && contrasenaTB.Text != "")
        {
            Registrarse encapsular = new Registrarse();
            Datos funcion = new Datos();
            DataTable usuarioValido = new DataTable();
            encapsular.Nombres = nombresTB.Text;
            encapsular.UserName = userNameTB.Text;
            encapsular.Telefono = telefonoTB.Text;
            encapsular.Correo = correoTB.Text;
            encapsular.Contrasena = contrasenaTB.Text;
            encapsular.IdRol = 3;
            encapsular.Estado = true;

            //usuarioValido = funcion.verificarUsuarioCorreo(encapsular);
            
           // if (usuarioValido.Rows.Count>0)
            //{
                funcion.registrarse(encapsular);
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Usuario registrado exitosamente');</script>");
                nombresTB.Text = "";
                userNameTB.Text = "";
                telefonoTB.Text = "";
                correoTB.Text = "";
                contrasenaTB.Text = "";
            //}
           
        }
        else
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Llene todos los campos primero');</script>");
        }
    }
}