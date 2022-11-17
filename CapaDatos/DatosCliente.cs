using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;

namespace CapaDatos
{
    public class DatosCliente : DatosConexionBD
    {
        public int abmCliente(string accion, Cliente objCliente)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = $"insert into Cliente values ({objCliente.p_Dni},'{objCliente.p_Nombre}','{objCliente.p_Apellido}',{objCliente.p_NroTelefonico})";
            if (accion == "Modificar")
                orden = $"update Cliente set Dni = {objCliente.p_Dni} where id = {objCliente.p_id}; update Cliente set Nombre = '{objCliente.p_Nombre}' where id = {objCliente.p_id}; update Cliente set Apellido = '{objCliente.p_Apellido}' where id = {objCliente.p_id}; update Cliente set NroTelefonico = {objCliente.p_NroTelefonico} where id = {objCliente.p_id}; ";
            if (accion == "Baja")
                orden = $"delete from Duenio where id = {objCliente.p_id}; ";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar,borrar o modificar ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoClientes(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = $"select * from Cliente where Id = {int.Parse(cual)};";
            else
                orden = "select * from Cliente;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Clientes", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
