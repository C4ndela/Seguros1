using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Cliente
     {
        #region atributos
        private int DNI;
        private string nombre;
        private string apellido;
        private string localidad;
        private string domicilio;
        private long nroTelefonico;
        #endregion

        #region constructor
        public Cliente()
        { }
        public Cliente (int dni, string nom, string apelli, string local, string domi, long nroTel)
        {
            DNI = dni;
            nombre = nom;
            apellido = apelli; 
            localidad = local; 
            domicilio = domi;   
            nroTelefonico = nroTel;
        }
        #endregion



     }
}
