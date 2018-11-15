using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Backend_Master_masterBack : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["rol"]!=null)
        {
            switch (int.Parse(Session["rol"].ToString()))
            {
                case 1:
                    rolL.Text = "ADMINISTRADOR";
                    RegistrarPrductoLB.Visible = false;
                    ModificarProductoLB.Visible = false;
                    EliminarProductoLB.Visible = false;
                    BuscarProductoLB.Visible = false;
                    menuMaterial.Visible = false;


                break;
                case 2:
                    rolL.Text = "Empleado";
                    menuAdministrador.Visible = false;
                    menuEmpleado.Visible = false;
                    menuProveedor.Visible = false;
                    menuMaterial.Visible = false;
                break;
                case 3:
                    rolL.Text = "Cliente";
                    menuAdministrador.Visible = false;
                    menuEmpleado.Visible = false;
                    menuProveedor.Visible = false;
                    break;
            }
            nombreUsuarioL.Text = Session["nombres"].ToString();
            correoUsuarioL.Text = Session["correo"].ToString();
        }
        else
        {
            Response.Redirect("~/View/Frontend/login.aspx");
        }
    }

    protected void registrarAdministradorLB_Click(object sender, EventArgs e)
    {
        Session["tipo_registro"] =1;
        Response.Redirect("formularioRegistro.aspx");
    }

    protected void RegistrarEmpleadoLB_Click(object sender, EventArgs e)
    {
        Session["tipo_registro"] = 2;
        Response.Redirect("formularioRegistro.aspx");
    }

    protected void InicioLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Frontend/index.aspx");
    }

    protected void cerrarSesionLB_Click(object sender, EventArgs e)
    {
        Session["usuario"] = null;
        Session["rol"] = null;
        Response.Redirect("~/View/Frontend/index.aspx");
    }

    protected void modificarAdministrador_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/modificarAdministrador.aspx");
    }

    protected void Listar_usuarios_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/listar_usuarios.aspx");
    }

    protected void BloquearUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/bloquear_usuario.aspx");

    }

    protected void VisualizarEmpleado_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/listar_empleados.aspx");
    }

    protected void RegistrarPrductoLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/agregar_producto.aspx");
    }

    protected void ModificarProductoLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/modificar_producto.aspx");
    }

    protected void EliminarProductoLB_Click(object sender, EventArgs e)
    {

    }

    protected void BuscarProductoLB_Click(object sender, EventArgs e)
    {

    }

    protected void VisualizarProductoLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/listar_productos.aspx");

    }

    protected void EliminarEmpleadoLB_Click(object sender, EventArgs e)
    {

    }

    protected void ModificarEmpleadoLB_Click(object sender, EventArgs e)
    {

    }

    protected void BloquearEmpleadoLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/bloquear_usuario.aspx");
    }

    protected void ReporteEmpleadosLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/reporte_empleados.aspx");
    }

    protected void ReporteCerticicadoLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/reporte_certificado.aspx");
    }
}
