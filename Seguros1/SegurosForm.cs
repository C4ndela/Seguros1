using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; 

namespace Seguros1
{
    public partial class SegurosForm : Form
    {
        public SegurosForm()
        {
            InitializeComponent();
        }

        private void btnCargarC_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            cliente =  new Cliente(txtDNI, txtNombre, txtApellido, 
               cmboxLocalidad, txtDomicilio, txtNroTelefono);
        }
    }
}
