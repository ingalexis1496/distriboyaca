using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Datos
/// </summary>
public class Datos
{
    public Datos()
    {
       
    }

    public void registrarse(Registrarse usuario)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_insertar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombres", NpgsqlDbType.Varchar).Value = usuario.Nombres;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Varchar).Value = usuario.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Varchar).Value = usuario.Correo;
            dataAdapter.SelectCommand.Parameters.Add("_contrasena", NpgsqlDbType.Varchar).Value = usuario.Contrasena;
            dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = usuario.IdRol;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Boolean).Value = usuario.Estado;
     
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public DataTable verificarUsuarioCorreo(Registrarse usuario)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Varchar).Value = usuario.Correo;
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable login(Login usuario)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_login", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.Usuario;
            dataAdapter.SelectCommand.Parameters.Add("_contrasena", NpgsqlDbType.Varchar).Value = usuario.Contrasena;
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable modificar_usuarios(Registrarse usuario)
    {

        DataTable datos_usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_modificar_usuarios", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombres", NpgsqlDbType.Varchar).Value = usuario.Nombres;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Varchar).Value = usuario.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = usuario.Correo;
            dataAdapter.SelectCommand.Parameters.Add("_contrasena", NpgsqlDbType.Text).Value = usuario.Contrasena;


            conection.Open();
            dataAdapter.Fill(datos_usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return datos_usuario;

    }
    public DataTable listar_por_userName(Registrarse encapusua)
    {

        DataTable buscar_dato = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_listar_por_username", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = encapusua.UserName;

            conection.Open();
            dataAdapter.Fill(buscar_dato);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return buscar_dato;

    }
    public void register_admin(Registrarse usuario)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_insertar_user", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombres", NpgsqlDbType.Varchar).Value = usuario.Nombres;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Varchar).Value = usuario.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Varchar).Value = usuario.Correo;
            dataAdapter.SelectCommand.Parameters.Add("_contrasena", NpgsqlDbType.Varchar).Value = usuario.Contrasena;
            dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = usuario.IdRol;
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
    public DataTable listar_Administradores()
    {

        DataTable datos_listar = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_listar_administradores", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;




            conection.Open();
            dataAdapter.Fill(datos_listar);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return datos_listar;

    }
    public DataTable listar_empleados()
    {

        DataTable datos_listar = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_listar_empleado", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;




            conection.Open();
            dataAdapter.Fill(datos_listar);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return datos_listar;

    }
    public DataTable validar_bloqueo()
    {

        DataTable datos_listar = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_bloqueo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;




            conection.Open();
            dataAdapter.Fill(datos_listar);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return datos_listar;

    }
    public DataTable modificar_estado(Registrarse usuario)
    {

        DataTable datos_listar = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_modificar_estado", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_bloqueo", NpgsqlDbType.Boolean).Value = usuario.Estado;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;




            conection.Open();
            dataAdapter.Fill(datos_listar);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return datos_listar;

    }
    public void registrar_producto(Eproducto datos)
    {
        DataTable producto = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_insertar_producto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = datos.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_serial", NpgsqlDbType.Varchar).Value = datos.Serial;
            dataAdapter.SelectCommand.Parameters.Add("_tipo_prod", NpgsqlDbType.Varchar).Value =datos.Tipo_prod;
            dataAdapter.SelectCommand.Parameters.Add("_material", NpgsqlDbType.Varchar).Value = datos.Material;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = datos.Cantidad;

            conection.Open();
            dataAdapter.Fill(producto);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
    public DataTable listar_productos()
    {
        DataTable producto = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_listar_productos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            

            conection.Open();
            dataAdapter.Fill(producto);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return producto;
    }
    public DataTable modificar_producto(Eproducto producto)
    {

        DataTable datos_producto = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_modificar_producto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = producto.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_serial", NpgsqlDbType.Varchar).Value = producto.Serial;
            dataAdapter.SelectCommand.Parameters.Add("_tipo",   NpgsqlDbType.Varchar).Value = producto.Tipo_prod;
            dataAdapter.SelectCommand.Parameters.Add("_material",NpgsqlDbType.Varchar).Value = producto.Material;
      


            conection.Open();
            dataAdapter.Fill(datos_producto);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return datos_producto;

    }
    public DataTable listar_por_serial(Eproducto encapsu)
    {

        DataTable serial = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_listar_por_serial", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_serial", NpgsqlDbType.Varchar).Value = encapsu.Serial;

            conection.Open();
            dataAdapter.Fill(serial);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return serial;

    }
    public DataTable modificar_productos_cantidad(Eproducto producto)
    {

        DataTable datos_producto = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_modificar_producto_cantidad", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Varchar).Value = producto.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = producto.Cantidad;


            conection.Open();
            dataAdapter.Fill(datos_producto);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return datos_producto;

    }
    public DataTable obtenerInforme()
    {

        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_obtener_empleados", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;



            conection.Open();
            dataAdapter.Fill(usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return usuario;

    }
}