using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class View_Backend_reporte_certificado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           

            Infor_empleado reporte = ObtenerInforme();
            CRS_Certificado.ReportDocument.SetDataSource(reporte);
            CRV_Certificado.ReportSource = CRS_Certificado;
        }
        catch (Exception)
        {
            throw;
        }
        

    }
    
    protected Infor_empleado ObtenerInforme()
    {
        DataRow fila;
        DataTable informacion = new DataTable();
        Infor_empleado datos = new Infor_empleado();
        informacion = datos.Tables["Empleados"];

        Datos empleado = new Datos();
            DataTable intermedio = empleado.obtenerInforme();


            fila = informacion.NewRow();
            fila["Nombres"] = Session["nombres"];
            fila["Cedula"]  = Session["cedula"];
            fila["fecha entrada"] = Session["fechaEntrada"];



        //fila["Nombres"] = intermedio.Rows[i]["nombres"].ToString();

        // fila["Nombre Usuario"] = intermedio.Rows[i]["user_name"].ToString();
        //fila["Correo"] = intermedio.Rows[i]["correo"].ToString();
        //fila["Telefono"] = intermedio.Rows[i]["telefono"].ToString();
        //fila["Estado"] = intermedio.Rows[i]["bloqueo"].ToString();



        informacion.Rows.Add(fila);
        

        return datos;
    }
    
}