using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Poliza
    {
        #region atributos
        private int nroPoliza;
        private string tipoSeguro;
        private DateTime vigenciaPoliza;
        private string periodoPoliza;
        private string empresaAsegurada;
        #endregion

        #region constructor
        public Poliza()
        { }

        public Poliza (int nroP, string tSeguro, DateTime vigenciaP, string periodoP, string empAsegurada)
        {
            nroPoliza = nroP;
            tipoSeguro = tSeguro;
            vigenciaPoliza = vigenciaP;
            periodoPoliza = periodoP;
            empresaAsegurada = empAsegurada;
        }



        #endregion
    }
}
