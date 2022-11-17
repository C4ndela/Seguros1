using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosConexionBD
    {
        protected SqlConnection conexion;
        protected string cadenaConexion = @"Data Source=CANDE\SQLEXPRESS;AttachDbFilename=C:\Users\cande\OneDrive\Documentos\SQL Server Management Studio\Lavadero;Integrated Security=True;Connect Timeout=30";
        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }

        //    public OleBdConnection conexion; 
        //    public string cadenaConexion = @"Data Source=CANDE\SQLEXPRESS;AttachDbFilename=C:\Users\cande\OneDrive\Documentos\SQL Server Management Studio\Lavadero;Integrated Security=True;Connect Timeout=30";

        //    public DatosConexionBD(cadenaConexion)
        //    {
        //        conexion = new OleDbConnection(cadenaConexion);
        //    }

        //     public void Abrirconexion()
        //    {
        //        try
        //        {
        //            if (conexion.State == ConnectionState.Broken || conexion.State ==
        //            ConnectionState.Closed)
        //                conexion.Open();
        //        }
        //        catch (Exception e)
        //        {
        //            throw new Exception("Error al tratar de abrir la conexión", e);
        //        }
        //    }
        //    public void Cerrarconexion()
        //    {
        //        try
        //        {
        //            if (conexion.State == ConnectionState.Open)
        //                conexion.Close();
        //        }
        //        catch (Exception e)
        //        {
        //            throw new Exception("Error al tratar de cerrar la conexión", e);
        //        }
        //    }
        //}
    }
}
