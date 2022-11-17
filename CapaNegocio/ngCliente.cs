using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using Entidades;


namespace CapaNegocio
{
    public class ngCliente
    {
        DatosCliente objDatosCliente = new DatosCliente();

        public int abmCliente(string accion, Cliente objCliente)
        {
            return objDatosCliente.abmCliente(accion, objCliente);
        }
        public DataSet listadoClientes(string cual)
        {
            return objDatosCliente.listadoClientes(cual);
        }
    }
}
