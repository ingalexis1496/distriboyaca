using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class View_Backend_modificar_producto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        LB_nombre.Visible = false;
        LB_seri.Visible = false;
        LB_tipo.Visible = false;
        LB_material.Visible = false;
        TB_nombre.Visible = false;
        TB_seri.Visible = false;
        TB_tipo.Visible = false;
        TB_material.Visible = false;
        BTN_modificar.Visible = false;



    }

    protected void BTN_buscar_Click(object sender, EventArgs e)
    {
        Eproducto encapsular = new Eproducto();
        Datos metodo = new Datos();
        DataTable datos_producto = new DataTable();

        
        encapsular.Serial = (TB_serial.Text);


        datos_producto = metodo.listar_por_serial(encapsular);
        if (datos_producto.Rows.Count >0)
        {

            LB_nombre.Visible = true;
            LB_seri.Visible = true;
            LB_tipo.Visible = true;
            LB_material.Visible = true;
            TB_nombre.Visible = true;
            TB_seri.Visible = true;
            TB_tipo.Visible = true;
            TB_material.Visible = true;
            BTN_modificar.Visible = true;

            TB_nombre.Text = datos_producto.Rows[0]["nombre"].ToString();
            TB_seri.Text = datos_producto.Rows[0]["serial_prod"].ToString();
            TB_tipo .Text = datos_producto.Rows[0]["tipo_prod"].ToString();
            TB_material.Text = datos_producto.Rows[0]["material"].ToString();
            this.Page.Response.Write("<script language='JavaScript'>window.alert('Producto encontrado exitosamente');</script>");

        }
        else
        {
            this.Page.Response.Write("<script language='JavaScript'>window.alert('No existe');</script>");
        }
    }



    protected void BTN_modificar_Click(object sender, EventArgs e)
    {
        Eproducto encapsular = new Eproducto();
        Datos metodo = new Datos();

        encapsular.Nombre = (TB_nombre.Text);
        encapsular.Serial = (TB_serial.Text);
        encapsular.Tipo_prod = (TB_tipo.Text);
        encapsular.Material = (TB_material.Text);
        metodo.modificar_producto(encapsular);
       
        this.Page.Response.Write("<script language='JavaScript'>window.alert('Datos Modificados');</script>");

    }
}