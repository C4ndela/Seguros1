namespace Seguros1
{
    partial class SegurosForm
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.LblDomicilio = new System.Windows.Forms.Label();
            this.lblNTel = new System.Windows.Forms.Label();
            this.cmboxLocalidad = new System.Windows.Forms.ComboBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNroTelefono = new System.Windows.Forms.TextBox();
            this.btnCargarC = new System.Windows.Forms.Button();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblSumaAse = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtSumaAsegurada = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblnroPoliza = new System.Windows.Forms.Label();
            this.lblTipoSeguro = new System.Windows.Forms.Label();
            this.lblVigencia = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtNumeroPoliza = new System.Windows.Forms.TextBox();
            this.txtVigencia = new System.Windows.Forms.TextBox();
            this.txtPeriodoPoliza = new System.Windows.Forms.TextBox();
            this.cmboxSeguro = new System.Windows.Forms.ComboBox();
            this.cmboxEmpresa = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 203);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCargarC);
            this.tabPage4.Controls.Add(this.txtNroTelefono);
            this.tabPage4.Controls.Add(this.txtDomicilio);
            this.tabPage4.Controls.Add(this.txtApellido);
            this.tabPage4.Controls.Add(this.txtNombre);
            this.tabPage4.Controls.Add(this.txtDNI);
            this.tabPage4.Controls.Add(this.cmboxLocalidad);
            this.tabPage4.Controls.Add(this.lblNTel);
            this.tabPage4.Controls.Add(this.LblDomicilio);
            this.tabPage4.Controls.Add(this.lblLocalidad);
            this.tabPage4.Controls.Add(this.lblApellido);
            this.tabPage4.Controls.Add(this.lblNombre);
            this.tabPage4.Controls.Add(this.lblDNI);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(525, 177);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Nuevo cliente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnAceptar);
            this.tabPage5.Controls.Add(this.txtModelo);
            this.tabPage5.Controls.Add(this.txtAño);
            this.tabPage5.Controls.Add(this.txtSumaAsegurada);
            this.tabPage5.Controls.Add(this.txtPatente);
            this.tabPage5.Controls.Add(this.lblSumaAse);
            this.tabPage5.Controls.Add(this.lblAño);
            this.tabPage5.Controls.Add(this.lblModelo);
            this.tabPage5.Controls.Add(this.lblPatente);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(525, 177);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Vehiculos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dateTimePicker1);
            this.tabPage6.Controls.Add(this.cmboxEmpresa);
            this.tabPage6.Controls.Add(this.cmboxSeguro);
            this.tabPage6.Controls.Add(this.txtPeriodoPoliza);
            this.tabPage6.Controls.Add(this.txtVigencia);
            this.tabPage6.Controls.Add(this.txtNumeroPoliza);
            this.tabPage6.Controls.Add(this.lblEmpresa);
            this.tabPage6.Controls.Add(this.lblPeriodo);
            this.tabPage6.Controls.Add(this.lblVigencia);
            this.tabPage6.Controls.Add(this.lblTipoSeguro);
            this.tabPage6.Controls.Add(this.lblnroPoliza);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(525, 177);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Poliza";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(3, 25);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(243, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(3, 53);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(243, 53);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 3;
            this.lblLocalidad.Text = "Localidad";
            // 
            // LblDomicilio
            // 
            this.LblDomicilio.AutoSize = true;
            this.LblDomicilio.Location = new System.Drawing.Point(6, 89);
            this.LblDomicilio.Name = "LblDomicilio";
            this.LblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.LblDomicilio.TabIndex = 4;
            this.LblDomicilio.Text = "Domicilio";
            // 
            // lblNTel
            // 
            this.lblNTel.AutoSize = true;
            this.lblNTel.Location = new System.Drawing.Point(243, 89);
            this.lblNTel.Name = "lblNTel";
            this.lblNTel.Size = new System.Drawing.Size(72, 13);
            this.lblNTel.TabIndex = 5;
            this.lblNTel.Text = "Nro. Telefono";
            // 
            // cmboxLocalidad
            // 
            this.cmboxLocalidad.FormattingEnabled = true;
            this.cmboxLocalidad.Location = new System.Drawing.Point(316, 50);
            this.cmboxLocalidad.Name = "cmboxLocalidad";
            this.cmboxLocalidad.Size = new System.Drawing.Size(175, 21);
            this.cmboxLocalidad.TabIndex = 6;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(61, 19);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(176, 20);
            this.txtDNI.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(315, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(60, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(61, 86);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(176, 20);
            this.txtDomicilio.TabIndex = 10;
            // 
            // txtNroTelefono
            // 
            this.txtNroTelefono.Location = new System.Drawing.Point(316, 86);
            this.txtNroTelefono.Name = "txtNroTelefono";
            this.txtNroTelefono.Size = new System.Drawing.Size(176, 20);
            this.txtNroTelefono.TabIndex = 11;
            // 
            // btnCargarC
            // 
            this.btnCargarC.Location = new System.Drawing.Point(192, 122);
            this.btnCargarC.Name = "btnCargarC";
            this.btnCargarC.Size = new System.Drawing.Size(104, 35);
            this.btnCargarC.TabIndex = 12;
            this.btnCargarC.Text = "Cargar";
            this.btnCargarC.UseVisualStyleBackColor = true;
            this.btnCargarC.Click += new System.EventHandler(this.btnCargarC_Click);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(6, 11);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "Patente";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(239, 13);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(6, 41);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año";
            // 
            // lblSumaAse
            // 
            this.lblSumaAse.AutoSize = true;
            this.lblSumaAse.Location = new System.Drawing.Point(239, 36);
            this.lblSumaAse.Name = "lblSumaAse";
            this.lblSumaAse.Size = new System.Drawing.Size(87, 13);
            this.lblSumaAse.TabIndex = 3;
            this.lblSumaAse.Text = "Suma asegurada";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(56, 8);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(175, 20);
            this.txtPatente.TabIndex = 4;
            // 
            // txtSumaAsegurada
            // 
            this.txtSumaAsegurada.Location = new System.Drawing.Point(332, 32);
            this.txtSumaAsegurada.Name = "txtSumaAsegurada";
            this.txtSumaAsegurada.Size = new System.Drawing.Size(175, 20);
            this.txtSumaAsegurada.TabIndex = 5;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(56, 34);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(175, 20);
            this.txtAño.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(289, 8);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(175, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // lblnroPoliza
            // 
            this.lblnroPoliza.AutoSize = true;
            this.lblnroPoliza.Location = new System.Drawing.Point(15, 10);
            this.lblnroPoliza.Name = "lblnroPoliza";
            this.lblnroPoliza.Size = new System.Drawing.Size(75, 13);
            this.lblnroPoliza.TabIndex = 0;
            this.lblnroPoliza.Text = "Numero Poliza";
            // 
            // lblTipoSeguro
            // 
            this.lblTipoSeguro.AutoSize = true;
            this.lblTipoSeguro.Location = new System.Drawing.Point(15, 44);
            this.lblTipoSeguro.Name = "lblTipoSeguro";
            this.lblTipoSeguro.Size = new System.Drawing.Size(41, 13);
            this.lblTipoSeguro.TabIndex = 1;
            this.lblTipoSeguro.Text = "Seguro";
            // 
            // lblVigencia
            // 
            this.lblVigencia.AutoSize = true;
            this.lblVigencia.Location = new System.Drawing.Point(15, 70);
            this.lblVigencia.Name = "lblVigencia";
            this.lblVigencia.Size = new System.Drawing.Size(79, 13);
            this.lblVigencia.TabIndex = 2;
            this.lblVigencia.Text = "Vigencia Poliza";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(15, 100);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(74, 13);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Periodo Poliza";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(15, 126);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Empresa";
            // 
            // txtNumeroPoliza
            // 
            this.txtNumeroPoliza.Location = new System.Drawing.Point(96, 7);
            this.txtNumeroPoliza.Name = "txtNumeroPoliza";
            this.txtNumeroPoliza.Size = new System.Drawing.Size(176, 20);
            this.txtNumeroPoliza.TabIndex = 9;
            // 
            // txtVigencia
            // 
            this.txtVigencia.Location = new System.Drawing.Point(96, 63);
            this.txtVigencia.Name = "txtVigencia";
            this.txtVigencia.Size = new System.Drawing.Size(176, 20);
            this.txtVigencia.TabIndex = 10;
            // 
            // txtPeriodoPoliza
            // 
            this.txtPeriodoPoliza.Location = new System.Drawing.Point(95, 93);
            this.txtPeriodoPoliza.Name = "txtPeriodoPoliza";
            this.txtPeriodoPoliza.Size = new System.Drawing.Size(176, 20);
            this.txtPeriodoPoliza.TabIndex = 12;
            // 
            // cmboxSeguro
            // 
            this.cmboxSeguro.FormattingEnabled = true;
            this.cmboxSeguro.Location = new System.Drawing.Point(96, 36);
            this.cmboxSeguro.Name = "cmboxSeguro";
            this.cmboxSeguro.Size = new System.Drawing.Size(175, 21);
            this.cmboxSeguro.TabIndex = 13;
            // 
            // cmboxEmpresa
            // 
            this.cmboxEmpresa.FormattingEnabled = true;
            this.cmboxEmpresa.Location = new System.Drawing.Point(95, 123);
            this.cmboxEmpresa.Name = "cmboxEmpresa";
            this.cmboxEmpresa.Size = new System.Drawing.Size(175, 21);
            this.cmboxEmpresa.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(179, 76);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 37);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 147);
            this.dataGridView1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // SegurosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SegurosForm";
            this.Text = "Seguros Conesa";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCargarC;
        private System.Windows.Forms.TextBox txtNroTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ComboBox cmboxLocalidad;
        private System.Windows.Forms.Label lblNTel;
        private System.Windows.Forms.Label LblDomicilio;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtSumaAsegurada;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblSumaAse;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ComboBox cmboxEmpresa;
        private System.Windows.Forms.ComboBox cmboxSeguro;
        private System.Windows.Forms.TextBox txtPeriodoPoliza;
        private System.Windows.Forms.TextBox txtVigencia;
        private System.Windows.Forms.TextBox txtNumeroPoliza;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblVigencia;
        private System.Windows.Forms.Label lblTipoSeguro;
        private System.Windows.Forms.Label lblnroPoliza;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}