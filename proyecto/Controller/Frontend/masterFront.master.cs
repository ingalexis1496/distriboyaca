using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Frontend_Master_masterFront : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"]!=null)
        {
            sesionLB.Text = "<i class='material-icons left'>person</i>" + Session["usuario"].ToString()+"<i class='material-icons right'>arrow_drop_down</i>";
            sesionLB.Visible = true;
            registrarseLB.Visible = false;
            iniciarSesionLB.Visible = false;
            switch(int.Parse(Session["rol"].ToString()))
            {
                case 1:
                    sesionLB.CssClass += " purple darken-3";
                    break;
                case 2:
                    sesionLB.CssClass += " blue darken-3";
                    break;
                case 3:
                    sesionLB.CssClass += " light-green accent-3";
                    break;
            }
        }
    }

    protected void iniciarSesionLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }

    protected void registrarseLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("registrarse.aspx");
    }

    protected void iniciarSesionLBO_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }

    protected void registrarseLBO_Click(object sender, EventArgs e)
    {
        Response.Redirect("registrarse.aspx");
    }

    protected void perfilLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Backend/usuario.aspx");
    }

    protected void cerrarSesionLB_Click(object sender, EventArgs e)
    {
        Session["usuario"] = null;
        Session["rol"] = null;
        Response.Redirect("index.aspx");
    }
}
