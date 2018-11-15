using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class View_Backend_bloquear_usuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
        DDL_estado.Visible = false;
        BTN_cambiar.Visible = false;
    }

    protected void BTN_Buscar_Click(object sender, EventArgs e)
    {

        Registrarse encapsular = new Registrarse();
        Datos metodo = new Datos();



        encapsular.UserName = (TB_nombre_us.Text);

        DataTable datos = new DataTable();


        datos = metodo.listar_por_userName(encapsular);

        if (datos.Rows.Count > 0)
        {

            DDL_estado.Visible = true;
            BTN_cambiar.Visible = true;

           


            if (datos.Rows[0]["bloqueo"].ToString() == "True")
            {

                DDL_estado.SelectedValue = "Activo";
            }
            else
            {
                DDL_estado.SelectedValue = "Inactivo";
            }

        }
        
        }


    protected void BTN_cambiar_Click(object sender, EventArgs e)
    {
        Registrarse encapsular = new Registrarse();
        Datos metodo = new Datos();
        DataTable datos = new DataTable();
        Boolean estado = true;


        if (DDL_estado.SelectedValue == "Activo")
        {

            estado = true;
        }
        else
        {
            estado = false;
        }



        encapsular.Estado = estado;
        encapsular.UserName = TB_nombre_us.Text;
        metodo.modificar_estado(encapsular);
        this.Page.Response.Write("<script language='JavaScript'>window.alert('Estado Cambiado (Y)');</script>");




    }
}