using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosVehiculo : DatosConexionBD
    {
        public int abmVehiculo(string accion, Vehiculo objVehiculo)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = $"insert into Vehiculo values ({objVehiculo.p_patente},'{objVehiculo.p_servicio}','{objVehiculo.p_fechaingreso}'";
            if (accion == "Modificar")
                orden = $"update Vehiculo set Patente = {objVehiculo.p_patente} where id = {objVehiculo.p_idVe}; update Vehiculo set Servicio = '{objVehiculo.p_servicio}' where id = {objVehiculo.p_idVe}";
            if (accion == "Baja")
                orden = $"delete from Vehiculo where id = {objVehiculo.p_idVe}; ";
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

        public DataSet listadoVehiculo(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = $"select * from Vehiculo where Id = {int.Parse(cual)};";
            else
                orden = "select * from Vehiculo;";
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
                throw new Exception("Error al listar Vehiculo", e);
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
}
