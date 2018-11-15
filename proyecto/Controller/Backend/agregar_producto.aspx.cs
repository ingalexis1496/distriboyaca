using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class View_Backend_agregar_producto : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {



    }

    protected void BTN_registrar_Click(object sender, EventArgs e)
    {
        Eproducto encapsular = new Eproducto();
        Datos metodo = new Datos();
        DataTable datos = new DataTable();
        String tipo;
        String material;
        int cont;

        encapsular.Nombre = TB_nombre.Text;
        encapsular.Serial = TB_serial.Text;
        encapsular.Cantidad = Convert.ToInt32(TB_cantidad.Text);

        datos = metodo.listar_por_serial(encapsular);


        if (datos.Rows[0]["nombre"].ToString() == TB_cantidad.Text)
        {
            metodo.modificar_productos_cantidad(encapsular);
            this.Page.Response.Write("<script language='JavaScript'>window.alert('producto listo');</script>");

            // datos.Rows[0]["cantidad"] += TB_cantidad.Text;
        }
        else
        {



            if (DDL_tipo_producto.SelectedValue == "1")
            {
                tipo = "Galón";
                encapsular.Tipo_prod = tipo;
            }
            if (DDL_tipo_producto.SelectedValue == "2")
            {
                tipo = "Medio Galón";
                encapsular.Tipo_prod = tipo;
            }
            if (DDL_tipo_producto.SelectedValue == "3")
            {
                tipo = "Pequeño";
                encapsular.Tipo_prod = tipo;
            }
            if (DDL_material.SelectedValue == "1")
            {
                material = "plastico";
                encapsular.Material = material;
            }
            if (DDL_material.SelectedValue == "2")
            {
                material = "metal";
                encapsular.Material = material;
            }


            metodo.registrar_producto(encapsular);

            this.Page.Response.Write("<script language='JavaScript'>window.alert('producto Registrado');</script>");

        }
    }
}