using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Eproducto
/// </summary>
public class Eproducto
{
    public Eproducto()
    {
       
    }

    private String nombre;
    private String serial;
    private String tipo_prod;
    private String  material;
    private int cantidad;


    public string Nombre { get => nombre; set => nombre = value; }
    public string Serial { get => serial; set => serial = value; }
    public string Tipo_prod { get => tipo_prod; set => tipo_prod = value; }
    public string Material { get => material; set => material = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }
}