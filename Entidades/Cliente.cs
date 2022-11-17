using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        #region atributos
        private int id;
        private int DNI;
        private string nombre;
        private string apellido;
        private long nroTelefonico;
        #endregion

        #region propiedades

        public int p_id
        {
            get { return id; }
            set { id = value; }
        }

        public int p_Dni
        {
            get { return DNI; }
            set { DNI = value; }
        }

        public string p_Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string p_Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

       
        public long p_NroTelefonico
        {
            get { return nroTelefonico; }
            set { nroTelefonico = value; }
        }
        #endregion

        #region constructor
        public Cliente()
        { }

        public Cliente(int dni, string nom, string apelli,long nroTel)
        {
            DNI = dni;
            nombre = nom;
            apellido = apelli;
            nroTelefonico = nroTel;
        }
        #endregion

    }
}
