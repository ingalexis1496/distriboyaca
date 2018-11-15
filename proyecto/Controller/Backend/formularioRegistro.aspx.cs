using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Backend_formularioRegistro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        switch (Session["tipo_registro"])
        {
            case 1:
                tituloL.Text = "Registrar Administrador";
                break;
            case 2:
                tituloL.Text = "Registrar Empleado";
                break;
            case 3:
                tituloL.Text = "Registrar Proveedor";
                break;
        }
    }

    protected void registrarB_Click(object sender, EventArgs e)
    {
        if (nombresTB.Text != "" && userNameTB.Text != "" && telefonoTB.Text != "" && correoTB.Text != "" && contrasenaTB.Text != "")
        {
            Registrarse encapsular = new Registrarse();
            Datos funcion = new Datos();
            DataTable usuarioValido = new DataTable();
            encapsular.Nombres = nombresTB.Text;
            encapsular.UserName = userNameTB.Text;
            encapsular.Telefono = telefonoTB.Text;
            encapsular.Correo = correoTB.Text;
            encapsular.Contrasena = contrasenaTB.Text;
            encapsular.IdRol = int.Parse(Session["tipo_registro"].ToString());
            encapsular.Estado = true;
           
           // usuarioValido = funcion.verificarUsuarioCorreo(encapsular);
          //  if (usuarioValido.Rows.Count > 0)
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