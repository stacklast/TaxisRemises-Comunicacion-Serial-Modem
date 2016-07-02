namespace TaxiRemesas
{
    partial class frmRegistrosLlamadas
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
            this.components = new System.ComponentModel.Container();
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAsignarUnidad = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.checkBoxDireccion = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtDireccionOrigen = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblIDCli = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.grbDatosCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.Controls.Add(this.btnSalir);
            this.grbDatosCliente.Controls.Add(this.groupBox1);
            this.grbDatosCliente.Controls.Add(this.checkBoxDireccion);
            this.grbDatosCliente.Controls.Add(this.label11);
            this.grbDatosCliente.Controls.Add(this.lblNumero);
            this.grbDatosCliente.Controls.Add(this.lblHora);
            this.grbDatosCliente.Controls.Add(this.label10);
            this.grbDatosCliente.Controls.Add(this.txtCelular);
            this.grbDatosCliente.Controls.Add(this.btnRegistro);
            this.grbDatosCliente.Controls.Add(this.lblFecha);
            this.grbDatosCliente.Controls.Add(this.txtReferencia);
            this.grbDatosCliente.Controls.Add(this.txtDireccionOrigen);
            this.grbDatosCliente.Controls.Add(this.txtDireccion);
            this.grbDatosCliente.Controls.Add(this.txtTelefono);
            this.grbDatosCliente.Controls.Add(this.lblIDCli);
            this.grbDatosCliente.Controls.Add(this.txtNombre);
            this.grbDatosCliente.Controls.Add(this.label5);
            this.grbDatosCliente.Controls.Add(this.label4);
            this.grbDatosCliente.Controls.Add(this.label6);
            this.grbDatosCliente.Controls.Add(this.label3);
            this.grbDatosCliente.Controls.Add(this.label2);
            this.grbDatosCliente.Controls.Add(this.label1);
            this.grbDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosCliente.Location = new System.Drawing.Point(21, 100);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(768, 382);
            this.grbDatosCliente.TabIndex = 30;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Registro de Llamadas";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TaxiRemesas.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(654, 198);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 39);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsignarUnidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbUnidad);
            this.groupBox1.Location = new System.Drawing.Point(379, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 105);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar Unidad";
            // 
            // btnAsignarUnidad
            // 
            this.btnAsignarUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarUnidad.Location = new System.Drawing.Point(275, 29);
            this.btnAsignarUnidad.Name = "btnAsignarUnidad";
            this.btnAsignarUnidad.Size = new System.Drawing.Size(76, 58);
            this.btnAsignarUnidad.TabIndex = 42;
            this.btnAsignarUnidad.Text = "Asignar Unidad";
            this.btnAsignarUnidad.UseVisualStyleBackColor = true;
            this.btnAsignarUnidad.Click += new System.EventHandler(this.btnAsignarUnidad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Unidad #:";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Location = new System.Drawing.Point(124, 32);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(70, 24);
            this.cmbUnidad.TabIndex = 33;
            // 
            // checkBoxDireccion
            // 
            this.checkBoxDireccion.AutoSize = true;
            this.checkBoxDireccion.Location = new System.Drawing.Point(376, 201);
            this.checkBoxDireccion.Name = "checkBoxDireccion";
            this.checkBoxDireccion.Size = new System.Drawing.Size(197, 20);
            this.checkBoxDireccion.TabIndex = 41;
            this.checkBoxDireccion.Text = "Misma Dirección Registrada";
            this.checkBoxDireccion.UseVisualStyleBackColor = true;
            this.checkBoxDireccion.CheckedChanged += new System.EventHandler(this.checkBoxDireccion_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Hora:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(101, 31);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 15);
            this.lblNumero.TabIndex = 40;
            this.lblNumero.Text = "Numero";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(454, 30);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 16);
            this.lblHora.TabIndex = 37;
            this.lblHora.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Fecha:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(94, 149);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(135, 21);
            this.txtCelular.TabIndex = 10;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Image = global::TaxiRemesas.Properties.Resources.tablet;
            this.btnRegistro.Location = new System.Drawing.Point(654, 93);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(108, 64);
            this.btnRegistro.TabIndex = 37;
            this.btnRegistro.Text = "Registrar Llamada";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(315, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 16);
            this.lblFecha.TabIndex = 36;
            this.lblFecha.Text = "label8";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(87, 287);
            this.txtReferencia.Multiline = true;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(264, 77);
            this.txtReferencia.TabIndex = 9;
            this.txtReferencia.TextChanged += new System.EventHandler(this.txtReferencia_TextChanged);
            // 
            // txtDireccionOrigen
            // 
            this.txtDireccionOrigen.Location = new System.Drawing.Point(376, 93);
            this.txtDireccionOrigen.Multiline = true;
            this.txtDireccionOrigen.Name = "txtDireccionOrigen";
            this.txtDireccionOrigen.Size = new System.Drawing.Size(264, 77);
            this.txtDireccionOrigen.TabIndex = 8;
            this.txtDireccionOrigen.TextChanged += new System.EventHandler(this.txtDireccionOrigen_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(87, 198);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(264, 77);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(94, 115);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 21);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblIDCli
            // 
            this.lblIDCli.AutoSize = true;
            this.lblIDCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCli.Location = new System.Drawing.Point(24, 29);
            this.lblIDCli.Name = "lblIDCli";
            this.lblIDCli.Size = new System.Drawing.Size(71, 16);
            this.lblIDCli.TabIndex = 34;
            this.lblIDCli.Text = "ClienteID";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 22);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Referencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Dirección Envío Unidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(189, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "Registro de Llamadas Asignaciones a Unidades";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMensaje.Location = new System.Drawing.Point(21, 65);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(227, 15);
            this.lblMensaje.TabIndex = 38;
            this.lblMensaje.Text = "Cliente Encontraro o Por Registrar";
            // 
            // frmRegistrosLlamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 502);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grbDatosCliente);
            this.Name = "frmRegistrosLlamadas";
            this.Text = "Registro De Llamadas";
            this.Load += new System.EventHandler(this.frmRegistrosLlamadas_Load);
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Label lblIDCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtDireccionOrigen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxDireccion;
        private System.Windows.Forms.Button btnAsignarUnidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}