using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        #region atributos
        private int id; 
        private string Patente;
        private string Servicio;
        private DateTime fechaingreso;
        private int dniCliente;
        private string Buscado;
        private string Completo;
        #endregion

        #region propiedades


        public int p_idVe
        {
            get { return id; }
            set { id = value; }
        }

        public string p_patente
        {
            get { return Patente; }
            set { Patente = value; }    
        }

        public string p_servicio
        {
            get { return Servicio; }
            set { Servicio = value; }
        }

        public DateTime p_fechaingreso
        {
            get { return fechaingreso; }
            set { fechaingreso = value; }
        }

        public int p_dni
        {
            get { return dniCliente; }
            set { dniCliente = value; }
        }

        public string p_buscado
        {
            get { return Buscado; }
            set { Buscado = value; }
        }

        public string p_completo
        {
            get { return Completo; }
            set { Completo = value; }
        }


        #endregion

        #region constructor

        public Vehiculo(string patente, string servi)
        {
            Patente = patente;
            Servicio = servi;

        }

        #endregion

        #region Metodos
        public void BuscadoS(bool buscadoS)
        {
            if (buscadoS == true)
            {
                Buscado = "si";
            }
            else
            {
                Buscado = "no";
            }
        }


        public void CompletO(bool completO)
        {
            if (completO == true)
            {
                Completo = "si";
            }
            else
            {
                Completo = "no";
            }
        }
        #endregion
    }
}
