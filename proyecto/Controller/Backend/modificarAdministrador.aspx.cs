using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class View_Backend_Master_modificarAdministrador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lb_alerta.Text= "";
        LB_Nombres.Visible = false;
        LB_user.Visible = false;
        LB_tel.Visible = false;
        LB_correo.Visible = false;
        LB_contrase.Visible = false;
        TB_nombres.Visible = false;
        TB_nomb_us.Visible = false;
        TB_telefono.Visible = false;
        TB_correo.Visible = false;
        TB_contrasse.Visible = false;
        BTN_modificar.Visible = false;
        switch (Session["id_rol"])
        {




        }





    }

    protected void BTN_listar_Click(object sender, EventArgs e)
    {
        Registrarse encapsular = new Registrarse();
        Datos metodo = new Datos();



        encapsular.UserName = (TB_nombre_user.Text);

        DataTable datos = new DataTable();


        datos = metodo.listar_por_userName(encapsular);
         
        if (datos.Rows.Count > 0)
        {

            LB_Nombres.Visible = true;
            LB_user.Visible = true;
            LB_tel.Visible = true;
            LB_correo.Visible = true;
            LB_contrase.Visible = true;
            TB_nombres.Visible = true;
            TB_nomb_us.Visible = true;
            TB_telefono.Visible = true;
            TB_correo.Visible = true;
            TB_contrasse.Visible = true;
            BTN_modificar.Visible = true;

            TB_nombres.Text = datos.Rows[0]["nombres"].ToString();
            TB_nomb_us.Text = datos.Rows[0]["user_name"].ToString();
            TB_telefono.Text = datos.Rows[0]["telefono"].ToString();
            TB_correo.Text = datos.Rows[0]["correo"].ToString();
            TB_contrasse.Text = datos.Rows[0]["contrasena"].ToString();
            lb_alerta.Text = "OKEY";
            

        }
        else
        {

            lb_alerta.Text = "NO EXISTE ";
        }


    }

    protected void BTN_modificar_Click(object sender, EventArgs e)
    {
        Registrarse encapsular = new Registrarse();
        Datos metodo = new Datos();

        encapsular.Nombres = (TB_nombres.Text);
        encapsular.Telefono = (TB_telefono.Text);
        encapsular.UserName = (TB_nomb_us.Text);
        encapsular.Correo = (TB_correo.Text);
        encapsular.Contrasena = (TB_contrasse.Text);
        metodo.modificar_usuarios (encapsular);
        this.Page.Response.Write("<script language='JavaScript'>window.alert('Datos Modificados');</script>");
       


    }
}