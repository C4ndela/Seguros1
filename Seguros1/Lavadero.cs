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
using CapaNegocio;
using System.Globalization;

namespace Seguros1
{
    public partial class Lavadero : Form
    {
        public Lavadero()
        {
            InitializeComponent();

            dgvCliente.ColumnCount = 4;
            dgvCliente.Columns[0].HeaderText = "DNI";
            dgvCliente.Columns[1].HeaderText = "Nombre";
            dgvCliente.Columns[2].HeaderText = "Apellido";
            dgvCliente.Columns[3].HeaderText = "Nro Telefono";

            dgvVehiculo.ColumnCount = 4;
            dgvVehiculo.Columns[0].HeaderText = "Patente";
            dgvVehiculo.Columns[1].HeaderText = "Servicio";
            dgvVehiculo.Columns[2].HeaderText = "Fecha Ingreso";
            dgvVehiculo.Columns[3].HeaderText = "Buscado";

            LlenardgvCliente();
            LlenardgvVehiculo();

        }

        public Cliente objCliente = new Cliente();
        public Vehiculo objVehiculo = new Vehiculo();

        public NgCliente objNegCliente = new NegCliente();
        public ngVehiculos objNegVehiculo = new ngVehiculos();

        #region llenarDGV
        private void LlenardgvCliente()
        {
            dgvCliente.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegCliente.listadoClientes("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvCliente.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3] );
                }
            }
        }
        private void LlenardgvVehiculo()
        {
            dgvVehiculo.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegVehiculo.listadoVehiculo("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvVehiculo.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4].ToString(), dr[5], dr[6].ToString());
                }
            }
        }
        #endregion

       #region txtBoxOBJ
        private void TxtBox_a_ObjCliente()
        {
            objCliente.p_Dni = int.Parse(txtDni.Text);
            objCliente.p_Nombre = txtNombre.Text;
            objCliente.p_Apellido = txtApellido.Text;
            objCliente.p_NroTelefonico = long.Parse(txtNumero.Text);

        }
        private void TxtBox_a_ObjVehiculo()
        {
            objVehiculo.p_patente = txtPatente.Text;
            objVehiculo.p_servicio = cmbServicio.SelectedItem.ToString();
            objVehiculo.p_fechaingreso = dateTimeServicio.Value;
            bool buscado = cbBuscado.Checked;
            objVehiculo.BuscadoS(buscado);
            bool completo = cbCompleto.Checked;
            objVehiculo.CompletO(completo);
        }
        #endregion

        #region Validacion de datos

        public bool ValidacionCamposCliente()
        {
            if (txtDni.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un dni", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombre.Text.Length > 30 || txtNombre.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres entre 2 y 30 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            

            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtApellido.Text.Length > 40 || txtApellido.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten apellidos entre 2 y 40 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
            if (txtNumero.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un numero de telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNumero.Text.Length > 10 || txtNumero.Text.Length < 10)
            {
                MessageBox.Show("Solo se permiten numeros de 10 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
           
        }
        public bool ValidacionCamposVehiculo()
        {
            if (txtPatente.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la patente del vehiculo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtPatente.Text.Length > 8 || txtPatente.Text.Length < 6)
            {
                MessageBox.Show("Verifique la patente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
           
        }
        #endregion

        #region Validaciones
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo acepta numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo acepta letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo acepta letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo acepta numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        #endregion

        #region btnCargar

        private void Lavadero_Load(object sender, EventArgs e)
        {

        }

        private void lblNombreDuenio_Click(object sender, EventArgs e)
        {

        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposCliente();
            int nGrabados = -1;
            if (validado == true)
            {
                TxtBox_a_ObjVehiculo();

                nGrabados = objVehiculo.abmVehiculo("Alta", objVehiculo);
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró agregar vehiculo al sistema");
                }
                else
                {
                    MessageBox.Show("Se logró agregar al vehiculo con éxito");
                    LlenardgvCliente();
                    LimpiarVehiculo();
                    //Llenar();
                    tabControl1.SelectTab(tabVehiculo);
                }
            }
        }

        private void tabMascota_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarDuenio_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposVehiculo();
            int nGrabados = -1;
            if (validado == true)
            {
                TxtBox_a_ObjCliente();

                nGrabados = objCliente.abmCliente("Alta", objCliente);
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró agregar el cliente al sistema");
                }
                else
                {
                    MessageBox.Show("Se logró agregar al cliente con éxito");
                    LlenardgvCliente();
                    LimpiarCliente();
                    //Llenar();
                    tabControl1.SelectTab(tabVehiculo);
                }
            }
        }

        #endregion

        #region Limpiar
        private void LimpiarCliente()
        {
            txtDni.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNumero.Text = string.Empty;
           
        }

        private void LimpiarVehiculo()
        {
            txtPatente.Text = string.Empty;
            cmbServicio.Text = string.Empty;
            dateTimeServicio.Value = DateTime.Today;
            cbBuscado.Checked = false;
            cbCompleto.Checked = false;
        }

        #endregion

        #region cellClick
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(tabCliente);
            DataSet ds = new DataSet();
            objCliente.p_id = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            ds = objCliente.listadoClientes(objCliente.p_id.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                btnCargarCliente.Visible = false;
              
            }
        }

        private void dgvVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(tabVehiculo);
            DataSet ds = new DataSet();
            objVehiculo.p_idVe = Convert.ToInt32(dgvVehiculo.CurrentRow.Cells[0].Value);
            ds = objVehiculo.listadoVehiculo(objVehiculo.p_idVe.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                btnCargarVehciulo.Visible = false;

            }
        }

        #endregion

        #region dsA_txt
        private void Ds_a_TxtBoxVehiculo(DataSet ds)
        {
            bool completado;
            if (ds.Tables[0].Rows[0]["retirado"].ToString() == "si")
            {
                completado = true;
            }
            else
            {
                completado = false;
            }

            bool buscado;
            if (ds.Tables[0].Rows[0]["retirado"].ToString() == "si")
            {
                buscado = true;
            }
            else
            {
                buscado = false;
            }
            txtPatente.Text = ds.Tables[0].Rows[0]["Patente"].ToString();
            cmbServicio.Text = ds.Tables[0].Rows[0]["Servicio"].ToString();
            dateTimeServicio.Value = System.Convert.ToDateTime(ds.Tables[0].Rows[0]["Fecha Ingreso"]);
            
        }

        private void Ds_a_TxtBoxCliente(DataSet ds)
        {
            txtDni.Text = ds.Tables[0].Rows[0]["dni"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtApellido.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            txtNumero.Text = ds.Tables[0].Rows[0]["Numero Telefono"].ToString();
        }

        #endregion

        #region btnModificar
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposCliente();
            int nResultado = -1;
            if (validado == true)
            {
                TxtBox_a_ObjCliente();
                nResultado = objNegCliente.abmCliente("Modificar", objCliente);
                if (nResultado != -1)
                {
                    MessageBox.Show("El cliente fue modificado con éxito");
                    LimpiarCliente();
                    LlenardgvCliente();
                    btnModificarCliente.Visible = false;
                    btnCargarCliente.Visible = true;
                    btnEliminarCliente.Visible = false;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar el cliente");
                }
            }

        }

        private void btModificarVehiculo_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposVehiculo();
            int nResultado = -1;
            if (validado == true)
            {
                TxtBox_a_ObjVehiculo();
                nResultado = objNegVehiculo.abmVehiculo("Modificar", objVehiculo);
                if (nResultado != -1)
                {
                    MessageBox.Show("El vehiculo fue modificado con éxito");
                    LimpiarVehiculo();
                    LlenardgvVehiculo();
                    btModificarVehiculo.Visible = false;
                    btnCargarVehciulo.Visible = true;
                    btnEliminarVehiculo.Visible = false;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar el cliente");
                }
            }
        }
        #endregion

        #region btnEliminar

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere eliminar este cliente?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int nGrabados = -1;
                nGrabados = objNegCliente.abmCliente("Baja", objCliente);
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró eliminar el cliente del sistema");
                }
                else
                {
                    MessageBox.Show("Se logró eliminar al cliente con éxito");
                    LlenardgvCliente();
                    LimpiarCliente();
                    btnModificarCliente.Visible = false;
                    btnCargarCliente.Visible = true;
                    btnEliminarCliente.Visible = false;
                }
            }

        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere eliminar este vehiculo?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int nGrabados = -1;
                nGrabados = objNegVehiculo.abmVehiculo("Baja", objVehiculo);
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró eliminar el vehiculo del sistema");
                }
                else
                {
                    MessageBox.Show("Se logró eliminar al vehiculo con éxito");
                    LlenardgvVehiculo();
                    LimpiarVehiculo();
                    btModificarVehiculo.Visible = false;
                    btnCargarVehciulo.Visible = true;
                    btnEliminarVehiculo.Visible = false;
                }
            }

        }




        #endregion

       
    }
}
