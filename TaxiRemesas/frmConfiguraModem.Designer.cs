namespace TaxiRemesas
{
    partial class frmConfiguraModem
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguraModem));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.cmbVelocidad = new System.Windows.Forms.ComboBox();
            this.cmbParidad = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbRecibe = new System.Windows.Forms.RichTextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoHex = new System.Windows.Forms.RadioButton();
            this.cmbBitsParada = new System.Windows.Forms.ComboBox();
            this.cmbBitsDatos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCallerID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbAcciones = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvConfiguraciones = new System.Windows.Forms.DataGridView();
            this.lblAT = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnColgarLlamada = new System.Windows.Forms.Button();
            this.btnContestar = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.iDCONFIGURACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUERTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vELOCIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bITSDATOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bITSPARADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONFIGURACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxisDataSet = new TaxiRemesas.taxisDataSet();
            this.cONFIGURACIONESTableAdapter = new TaxiRemesas.taxisDataSetTableAdapters.CONFIGURACIONESTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbAcciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURACIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Location = new System.Drawing.Point(16, 44);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(76, 23);
            this.cmbPuerto.TabIndex = 3;
            // 
            // cmbVelocidad
            // 
            this.cmbVelocidad.FormattingEnabled = true;
            this.cmbVelocidad.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
            this.cmbVelocidad.Location = new System.Drawing.Point(114, 44);
            this.cmbVelocidad.Name = "cmbVelocidad";
            this.cmbVelocidad.Size = new System.Drawing.Size(76, 23);
            this.cmbVelocidad.TabIndex = 4;
            // 
            // cmbParidad
            // 
            this.cmbParidad.FormattingEnabled = true;
            this.cmbParidad.Location = new System.Drawing.Point(212, 44);
            this.cmbParidad.Name = "cmbParidad";
            this.cmbParidad.Size = new System.Drawing.Size(76, 23);
            this.cmbParidad.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(233, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 24);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Conexiónes Puerto Serie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAT);
            this.groupBox1.Controls.Add(this.rtbRecibe);
            this.groupBox1.Controls.Add(this.txtSend);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.cmbBitsParada);
            this.groupBox1.Controls.Add(this.cmbBitsDatos);
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbParidad);
            this.groupBox1.Controls.Add(this.cmbVelocidad);
            this.groupBox1.Controls.Add(this.cmbPuerto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 297);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rtbRecibe
            // 
            this.rtbRecibe.Location = new System.Drawing.Point(16, 87);
            this.rtbRecibe.Name = "rtbRecibe";
            this.rtbRecibe.Size = new System.Drawing.Size(436, 147);
            this.rtbRecibe.TabIndex = 24;
            this.rtbRecibe.Text = "";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(119, 250);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(333, 21);
            this.txtSend.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoText);
            this.groupBox3.Controls.Add(this.rdoHex);
            this.groupBox3.Location = new System.Drawing.Point(499, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(77, 60);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode";
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Checked = true;
            this.rdoText.Location = new System.Drawing.Point(6, 38);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(48, 19);
            this.rdoText.TabIndex = 1;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Text";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoHex
            // 
            this.rdoHex.AutoSize = true;
            this.rdoHex.Location = new System.Drawing.Point(6, 16);
            this.rdoHex.Name = "rdoHex";
            this.rdoHex.Size = new System.Drawing.Size(47, 19);
            this.rdoHex.TabIndex = 0;
            this.rdoHex.TabStop = true;
            this.rdoHex.Text = "Hex";
            this.rdoHex.UseVisualStyleBackColor = true;
            this.rdoHex.CheckedChanged += new System.EventHandler(this.rdoHex_CheckedChanged);
            // 
            // cmbBitsParada
            // 
            this.cmbBitsParada.FormattingEnabled = true;
            this.cmbBitsParada.Location = new System.Drawing.Point(310, 44);
            this.cmbBitsParada.Name = "cmbBitsParada";
            this.cmbBitsParada.Size = new System.Drawing.Size(76, 23);
            this.cmbBitsParada.TabIndex = 15;
            // 
            // cmbBitsDatos
            // 
            this.cmbBitsDatos.FormattingEnabled = true;
            this.cmbBitsDatos.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbBitsDatos.Location = new System.Drawing.Point(408, 44);
            this.cmbBitsDatos.Name = "cmbBitsDatos";
            this.cmbBitsDatos.Size = new System.Drawing.Size(76, 23);
            this.cmbBitsDatos.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Numero a Llamar:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(27, 111);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(128, 21);
            this.txtNumero.TabIndex = 14;
            // 
            // lblCallerID
            // 
            this.lblCallerID.AutoSize = true;
            this.lblCallerID.Location = new System.Drawing.Point(6, 32);
            this.lblCallerID.Name = "lblCallerID";
            this.lblCallerID.Size = new System.Drawing.Size(51, 15);
            this.lblCallerID.TabIndex = 16;
            this.lblCallerID.Text = "CallerID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Número Identificado:";
            // 
            // grbAcciones
            // 
            this.grbAcciones.Controls.Add(this.label7);
            this.grbAcciones.Controls.Add(this.btnColgarLlamada);
            this.grbAcciones.Controls.Add(this.txtNumero);
            this.grbAcciones.Controls.Add(this.lblCallerID);
            this.grbAcciones.Controls.Add(this.label4);
            this.grbAcciones.Controls.Add(this.btnContestar);
            this.grbAcciones.Controls.Add(this.btnLlamar);
            this.grbAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAcciones.Location = new System.Drawing.Point(626, 36);
            this.grbAcciones.Name = "grbAcciones";
            this.grbAcciones.Size = new System.Drawing.Size(184, 297);
            this.grbAcciones.TabIndex = 18;
            this.grbAcciones.TabStop = false;
            this.grbAcciones.Text = "Acciones";
            this.grbAcciones.Enter += new System.EventHandler(this.grbAcciones_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Puerto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(111, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Velocidad (bits/s) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(212, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Paridad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(411, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Bits de Datos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(310, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Bits de Parada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(25, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 69);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Base de Datos";
            // 
            // dgvConfiguraciones
            // 
            this.dgvConfiguraciones.AllowUserToAddRows = false;
            this.dgvConfiguraciones.AllowUserToDeleteRows = false;
            this.dgvConfiguraciones.AllowUserToOrderColumns = true;
            this.dgvConfiguraciones.AutoGenerateColumns = false;
            this.dgvConfiguraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfiguraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCONFIGURACIONDataGridViewTextBoxColumn,
            this.pUERTODataGridViewTextBoxColumn,
            this.vELOCIDADDataGridViewTextBoxColumn,
            this.pARIDADDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.bITSDATOSDataGridViewTextBoxColumn,
            this.bITSPARADADataGridViewTextBoxColumn});
            this.dgvConfiguraciones.DataSource = this.cONFIGURACIONESBindingSource;
            this.dgvConfiguraciones.Location = new System.Drawing.Point(25, 418);
            this.dgvConfiguraciones.MultiSelect = false;
            this.dgvConfiguraciones.Name = "dgvConfiguraciones";
            this.dgvConfiguraciones.ReadOnly = true;
            this.dgvConfiguraciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConfiguraciones.Size = new System.Drawing.Size(785, 118);
            this.dgvConfiguraciones.TabIndex = 20;
            this.dgvConfiguraciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfiguraciones_CellClick);
            // 
            // lblAT
            // 
            this.lblAT.AutoSize = true;
            this.lblAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAT.Location = new System.Drawing.Point(18, 254);
            this.lblAT.Name = "lblAT";
            this.lblAT.Size = new System.Drawing.Size(99, 15);
            this.lblAT.TabIndex = 25;
            this.lblAT.Text = "Comandos AT:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::TaxiRemesas.Properties.Resources.borrar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(389, 18);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 39);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TaxiRemesas.Properties.Resources.salir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(659, 18);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 39);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::TaxiRemesas.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(524, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 39);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::TaxiRemesas.Properties.Resources.modificar1;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(254, 18);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 39);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::TaxiRemesas.Properties.Resources.guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(119, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 39);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnColgarLlamada
            // 
            this.btnColgarLlamada.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnColgarLlamada.Image = ((System.Drawing.Image)(resources.GetObject("btnColgarLlamada.Image")));
            this.btnColgarLlamada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColgarLlamada.Location = new System.Drawing.Point(27, 240);
            this.btnColgarLlamada.Name = "btnColgarLlamada";
            this.btnColgarLlamada.Size = new System.Drawing.Size(128, 41);
            this.btnColgarLlamada.TabIndex = 15;
            this.btnColgarLlamada.Text = "Colgar";
            this.btnColgarLlamada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColgarLlamada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnColgarLlamada.UseVisualStyleBackColor = true;
            this.btnColgarLlamada.Click += new System.EventHandler(this.btnColgarLlamada_Click);
            // 
            // btnContestar
            // 
            this.btnContestar.Image = ((System.Drawing.Image)(resources.GetObject("btnContestar.Image")));
            this.btnContestar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContestar.Location = new System.Drawing.Point(27, 193);
            this.btnContestar.Name = "btnContestar";
            this.btnContestar.Size = new System.Drawing.Size(128, 41);
            this.btnContestar.TabIndex = 12;
            this.btnContestar.Text = "Contestar";
            this.btnContestar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContestar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContestar.UseVisualStyleBackColor = true;
            this.btnContestar.Click += new System.EventHandler(this.btnContestar_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Image = ((System.Drawing.Image)(resources.GetObject("btnLlamar.Image")));
            this.btnLlamar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLlamar.Location = new System.Drawing.Point(27, 149);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(128, 38);
            this.btnLlamar.TabIndex = 11;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLlamar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click_1);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.Location = new System.Drawing.Point(478, 233);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(98, 38);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesconectar.Image")));
            this.btnDesconectar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesconectar.Location = new System.Drawing.Point(478, 169);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(101, 52);
            this.btnDesconectar.TabIndex = 10;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesconectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Image = ((System.Drawing.Image)(resources.GetObject("btnConectar.Image")));
            this.btnConectar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConectar.Location = new System.Drawing.Point(476, 99);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(101, 52);
            this.btnConectar.TabIndex = 12;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(16, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(53, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID_CONF";
            // 
            // iDCONFIGURACIONDataGridViewTextBoxColumn
            // 
            this.iDCONFIGURACIONDataGridViewTextBoxColumn.DataPropertyName = "ID_CONFIGURACION";
            this.iDCONFIGURACIONDataGridViewTextBoxColumn.HeaderText = "ID_CONFIGURACION";
            this.iDCONFIGURACIONDataGridViewTextBoxColumn.Name = "iDCONFIGURACIONDataGridViewTextBoxColumn";
            this.iDCONFIGURACIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUERTODataGridViewTextBoxColumn
            // 
            this.pUERTODataGridViewTextBoxColumn.DataPropertyName = "PUERTO";
            this.pUERTODataGridViewTextBoxColumn.HeaderText = "PUERTO";
            this.pUERTODataGridViewTextBoxColumn.Name = "pUERTODataGridViewTextBoxColumn";
            this.pUERTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vELOCIDADDataGridViewTextBoxColumn
            // 
            this.vELOCIDADDataGridViewTextBoxColumn.DataPropertyName = "VELOCIDAD";
            this.vELOCIDADDataGridViewTextBoxColumn.HeaderText = "VELOCIDAD";
            this.vELOCIDADDataGridViewTextBoxColumn.Name = "vELOCIDADDataGridViewTextBoxColumn";
            this.vELOCIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pARIDADDataGridViewTextBoxColumn
            // 
            this.pARIDADDataGridViewTextBoxColumn.DataPropertyName = "PARIDAD";
            this.pARIDADDataGridViewTextBoxColumn.HeaderText = "PARIDAD";
            this.pARIDADDataGridViewTextBoxColumn.Name = "pARIDADDataGridViewTextBoxColumn";
            this.pARIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bITSDATOSDataGridViewTextBoxColumn
            // 
            this.bITSDATOSDataGridViewTextBoxColumn.DataPropertyName = "BITS_DATOS";
            this.bITSDATOSDataGridViewTextBoxColumn.HeaderText = "BITS_DATOS";
            this.bITSDATOSDataGridViewTextBoxColumn.Name = "bITSDATOSDataGridViewTextBoxColumn";
            this.bITSDATOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bITSPARADADataGridViewTextBoxColumn
            // 
            this.bITSPARADADataGridViewTextBoxColumn.DataPropertyName = "BITS_PARADA";
            this.bITSPARADADataGridViewTextBoxColumn.HeaderText = "BITS_PARADA";
            this.bITSPARADADataGridViewTextBoxColumn.Name = "bITSPARADADataGridViewTextBoxColumn";
            this.bITSPARADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONFIGURACIONESBindingSource
            // 
            this.cONFIGURACIONESBindingSource.DataMember = "CONFIGURACIONES";
            this.cONFIGURACIONESBindingSource.DataSource = this.taxisDataSet;
            // 
            // taxisDataSet
            // 
            this.taxisDataSet.DataSetName = "taxisDataSet";
            this.taxisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONFIGURACIONESTableAdapter
            // 
            this.cONFIGURACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // frmConfiguraModem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 556);
            this.Controls.Add(this.dgvConfiguraciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbAcciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmConfiguraModem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones de Modem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbAcciones.ResumeLayout(false);
            this.grbAcciones.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONFIGURACIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.ComboBox cmbVelocidad;
        private System.Windows.Forms.ComboBox cmbParidad;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnContestar;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cmbBitsParada;
        private System.Windows.Forms.ComboBox cmbBitsDatos;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnColgarLlamada;
        private System.Windows.Forms.Label lblCallerID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoHex;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.RichTextBox rtbRecibe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbAcciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvConfiguraciones;
        private taxisDataSet taxisDataSet;
        private System.Windows.Forms.BindingSource cONFIGURACIONESBindingSource;
        private taxisDataSetTableAdapters.CONFIGURACIONESTableAdapter cONFIGURACIONESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCONFIGURACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUERTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vELOCIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bITSDATOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bITSPARADADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAT;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblID;
    }
}

