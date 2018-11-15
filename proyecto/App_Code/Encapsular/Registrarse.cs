using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Registrarse
/// </summary>
public class Registrarse
{

    private string nombres;
    private string userName;
    private string telefono;
    private string correo;
    private string contrasena;
    private int idRol;
    private Boolean estado;
    private string fecha_entrada;

    public Registrarse()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string Nombres { get => nombres; set => nombres = value; }
    public string UserName { get => userName; set => userName = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Correo { get => correo; set => correo = value; }
    public string Contrasena { get => contrasena; set => contrasena = value; }
    public int IdRol { get => idRol; set => idRol = value; }
    public bool Estado { get => estado; set => estado = value; }
    public string Fecha_entrada { get => fecha_entrada; set => fecha_entrada = value; }
}