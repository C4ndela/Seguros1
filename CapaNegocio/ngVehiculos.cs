using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ngVehiculos
    {
        DatosVehiculo objDatosVehiculo = new DatosVehiculo();
        public int abmVehiculo(string accion, Vehiculo objVehiculo)
        {
            return objDatosVehiculo.abmVehiculo(accion, objVehiculo);
        }
        public DataSet listadoVehiculo(string cual)
        {
            return objDatosVehiculo.listadoVehiculo(cual);
        }
    }
}
