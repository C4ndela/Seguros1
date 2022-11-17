namespace Seguros1
{
    partial class Lavadero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.tabVehiculo = new System.Windows.Forms.TabPage();
            this.cbBuscado = new System.Windows.Forms.CheckBox();
            this.cbCompleto = new System.Windows.Forms.CheckBox();
            this.btnCargarVehciulo = new System.Windows.Forms.Button();
            this.dateTimeServicio = new System.Windows.Forms.DateTimePicker();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblDuenioMascota = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.btModificarVehiculo = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabVehiculo);
            this.tabControl1.Location = new System.Drawing.Point(13, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 264);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.btnEliminarCliente);
            this.tabCliente.Controls.Add(this.btnModificarCliente);
            this.tabCliente.Controls.Add(this.lblDni);
            this.tabCliente.Controls.Add(this.txtDni);
            this.tabCliente.Controls.Add(this.lblNumeroTelefono);
            this.tabCliente.Controls.Add(this.lblApellido);
            this.tabCliente.Controls.Add(this.lblNombre);
            this.tabCliente.Controls.Add(this.txtNumero);
            this.tabCliente.Controls.Add(this.txtApellido);
            this.tabCliente.Controls.Add(this.txtNombre);
            this.tabCliente.Controls.Add(this.btnCargarCliente);
            this.tabCliente.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Margin = new System.Windows.Forms.Padding(4);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(4);
            this.tabCliente.Size = new System.Drawing.Size(531, 238);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Cliente";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(45, 29);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(120, 32);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(154, 20);
            this.txtDni.TabIndex = 15;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefono.Location = new System.Drawing.Point(45, 129);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(69, 13);
            this.lblNumeroTelefono.TabIndex = 14;
            this.lblNumeroTelefono.Text = "Nro Telefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(45, 93);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(120, 122);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(154, 20);
            this.txtNumero.TabIndex = 11;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(120, 90);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(154, 20);
            this.txtApellido.TabIndex = 10;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(120, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCliente.Location = new System.Drawing.Point(303, 55);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(84, 26);
            this.btnCargarCliente.TabIndex = 8;
            this.btnCargarCliente.Text = "Cargar";
            this.btnCargarCliente.UseVisualStyleBackColor = true;
            this.btnCargarCliente.Click += new System.EventHandler(this.btnCargarDuenio_Click);
            // 
            // tabVehiculo
            // 
            this.tabVehiculo.Controls.Add(this.btnEliminarVehiculo);
            this.tabVehiculo.Controls.Add(this.btModificarVehiculo);
            this.tabVehiculo.Controls.Add(this.cbBuscado);
            this.tabVehiculo.Controls.Add(this.cbCompleto);
            this.tabVehiculo.Controls.Add(this.btnCargarVehciulo);
            this.tabVehiculo.Controls.Add(this.dateTimeServicio);
            this.tabVehiculo.Controls.Add(this.cbClientes);
            this.tabVehiculo.Controls.Add(this.lblDuenioMascota);
            this.tabVehiculo.Controls.Add(this.cmbServicio);
            this.tabVehiculo.Controls.Add(this.txtPatente);
            this.tabVehiculo.Controls.Add(this.lblFechaIngreso);
            this.tabVehiculo.Controls.Add(this.lblServicio);
            this.tabVehiculo.Controls.Add(this.lblPatente);
            this.tabVehiculo.Location = new System.Drawing.Point(4, 22);
            this.tabVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.tabVehiculo.Name = "tabVehiculo";
            this.tabVehiculo.Padding = new System.Windows.Forms.Padding(4);
            this.tabVehiculo.Size = new System.Drawing.Size(531, 238);
            this.tabVehiculo.TabIndex = 1;
            this.tabVehiculo.Text = "Vehiculo";
            this.tabVehiculo.UseVisualStyleBackColor = true;
            this.tabVehiculo.Click += new System.EventHandler(this.tabMascota_Click);
            // 
            // cbBuscado
            // 
            this.cbBuscado.AutoSize = true;
            this.cbBuscado.Location = new System.Drawing.Point(276, 85);
            this.cbBuscado.Name = "cbBuscado";
            this.cbBuscado.Size = new System.Drawing.Size(68, 17);
            this.cbBuscado.TabIndex = 35;
            this.cbBuscado.Text = "Buscado";
            this.cbBuscado.UseVisualStyleBackColor = true;
            // 
            // cbCompleto
            // 
            this.cbCompleto.AutoSize = true;
            this.cbCompleto.Location = new System.Drawing.Point(276, 56);
            this.cbCompleto.Name = "cbCompleto";
            this.cbCompleto.Size = new System.Drawing.Size(70, 17);
            this.cbCompleto.TabIndex = 34;
            this.cbCompleto.Text = "Completo";
            this.cbCompleto.UseVisualStyleBackColor = true;
            // 
            // btnCargarVehciulo
            // 
            this.btnCargarVehciulo.Location = new System.Drawing.Point(377, 30);
            this.btnCargarVehciulo.Name = "btnCargarVehciulo";
            this.btnCargarVehciulo.Size = new System.Drawing.Size(108, 37);
            this.btnCargarVehciulo.TabIndex = 33;
            this.btnCargarVehciulo.Text = "Cargar";
            this.btnCargarVehciulo.UseVisualStyleBackColor = true;
            this.btnCargarVehciulo.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dateTimeServicio
            // 
            this.dateTimeServicio.Location = new System.Drawing.Point(107, 80);
            this.dateTimeServicio.Name = "dateTimeServicio";
            this.dateTimeServicio.Size = new System.Drawing.Size(143, 20);
            this.dateTimeServicio.TabIndex = 30;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(107, 113);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(132, 21);
            this.cbClientes.TabIndex = 23;
            this.cbClientes.Text = "Dueños";
            // 
            // lblDuenioMascota
            // 
            this.lblDuenioMascota.AutoSize = true;
            this.lblDuenioMascota.Location = new System.Drawing.Point(8, 116);
            this.lblDuenioMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuenioMascota.Name = "lblDuenioMascota";
            this.lblDuenioMascota.Size = new System.Drawing.Size(39, 13);
            this.lblDuenioMascota.TabIndex = 22;
            this.lblDuenioMascota.Text = "Dueño";
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Roedor",
            "Ave",
            "Reptil",
            "Insecto"});
            this.cmbServicio.Location = new System.Drawing.Point(107, 48);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(132, 21);
            this.cmbServicio.TabIndex = 19;
            this.cmbServicio.Text = "Servicio";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(107, 21);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(132, 20);
            this.txtPatente.TabIndex = 13;
            this.txtPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatente_KeyPress);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(8, 80);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(75, 13);
            this.lblFechaIngreso.TabIndex = 12;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(8, 51);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(28, 13);
            this.lblServicio.TabIndex = 10;
            this.lblServicio.Text = "Tipo";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(8, 24);
            this.lblPatente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 9;
            this.lblPatente.Text = "Patente";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(555, 22);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(540, 134);
            this.dgvCliente.TabIndex = 2;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Location = new System.Drawing.Point(555, 167);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.Size = new System.Drawing.Size(540, 134);
            this.dgvVehiculo.TabIndex = 3;
            this.dgvVehiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculo_CellClick);
            // 
            // btModificarVehiculo
            // 
            this.btModificarVehiculo.Location = new System.Drawing.Point(377, 73);
            this.btModificarVehiculo.Name = "btModificarVehiculo";
            this.btModificarVehiculo.Size = new System.Drawing.Size(108, 37);
            this.btModificarVehiculo.TabIndex = 36;
            this.btModificarVehiculo.Text = "Modificar";
            this.btModificarVehiculo.UseVisualStyleBackColor = true;
            this.btModificarVehiculo.Click += new System.EventHandler(this.btModificarVehiculo_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.Location = new System.Drawing.Point(303, 87);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(84, 26);
            this.btnModificarCliente.TabIndex = 17;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(303, 119);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(84, 26);
            this.btnEliminarCliente.TabIndex = 18;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(377, 116);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(108, 37);
            this.btnEliminarVehiculo.TabIndex = 37;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // Lavadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 498);
            this.Controls.Add(this.dgvVehiculo);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.tabControl1);
            this.Name = "Lavadero";
            this.Text = "Lavadero";
            this.Load += new System.EventHandler(this.Lavadero_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.tabVehiculo.ResumeLayout(false);
            this.tabVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVehiculo;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblDuenioMascota;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.Button btnCargarVehciulo;
        private System.Windows.Forms.DateTimePicker dateTimeServicio;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.CheckBox cbBuscado;
        private System.Windows.Forms.CheckBox cbCompleto;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btModificarVehiculo;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnEliminarVehiculo;
    }
}