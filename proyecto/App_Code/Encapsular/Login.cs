using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Login
/// </summary>
public class Login
{

    private string usuario;
    private string contrasena;
    private Boolean estado;

    public Login()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string Usuario { get => usuario; set => usuario = value; }
    public string Contrasena { get => contrasena; set => contrasena = value; }
    public bool Estado { get => estado; set => estado = value; }
}