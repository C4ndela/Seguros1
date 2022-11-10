using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        #region atributos
        private string Patente;
        private string Modelo;
        private int año;
        private int sumaAsegurada;
        private bool asegurado;
        #endregion 

        #region constructor
        public Vehiculo()
        { }
        public Vehiculo(string patente, string modelo, int anio, int sumAsegurada)
        {
            Patente = patente;
            Modelo = modelo;
            año = anio;
            sumaAsegurada = sumAsegurada;
            asegurado = false;
        }
        #endregion


    }
}
