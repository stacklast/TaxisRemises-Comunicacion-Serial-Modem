namespace TaxiRemesas
{
    partial class frmUnidad
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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTablaUnidad = new System.Windows.Forms.DataGridView();
            this.iDUNIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPIETARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHOFERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROUNIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLACADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOLORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTORIZACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATRICULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxisDataSet = new TaxiRemesas.taxisDataSet();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.txtNumero_Unidad = new System.Windows.Forms.TextBox();
            this.txtAutorizacion = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtBuscarUnidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grbDatosUnidad = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarUnidad = new System.Windows.Forms.Button();
            this.uNIDADESTableAdapter = new TaxiRemesas.taxisDataSetTableAdapters.UNIDADESTableAdapter();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxisDataSet)).BeginInit();
            this.grbDatosUnidad.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(41, 26);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propietario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chofer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unidad #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autorización:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Placa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Matricula:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Color:";
            // 
            // dgvTablaUnidad
            // 
            this.dgvTablaUnidad.AllowUserToAddRows = false;
            this.dgvTablaUnidad.AllowUserToDeleteRows = false;
            this.dgvTablaUnidad.AllowUserToOrderColumns = true;
            this.dgvTablaUnidad.AutoGenerateColumns = false;
            this.dgvTablaUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaUnidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUNIDADDataGridViewTextBoxColumn,
            this.pROPIETARIODataGridViewTextBoxColumn,
            this.cHOFERDataGridViewTextBoxColumn,
            this.nUMEROUNIDADDataGridViewTextBoxColumn,
            this.pLACADataGridViewTextBoxColumn,
            this.cOLORDataGridViewTextBoxColumn,
            this.aUTORIZACIONDataGridViewTextBoxColumn,
            this.mATRICULADataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn});
            this.dgvTablaUnidad.DataSource = this.uNIDADESBindingSource;
            this.dgvTablaUnidad.Location = new System.Drawing.Point(12, 234);
            this.dgvTablaUnidad.MultiSelect = false;
            this.dgvTablaUnidad.Name = "dgvTablaUnidad";
            this.dgvTablaUnidad.ReadOnly = true;
            this.dgvTablaUnidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaUnidad.Size = new System.Drawing.Size(773, 170);
            this.dgvTablaUnidad.TabIndex = 9;
            this.dgvTablaUnidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaUnidad_CellClick);
            // 
            // iDUNIDADDataGridViewTextBoxColumn
            // 
            this.iDUNIDADDataGridViewTextBoxColumn.DataPropertyName = "ID_UNIDAD";
            this.iDUNIDADDataGridViewTextBoxColumn.HeaderText = "NUM";
            this.iDUNIDADDataGridViewTextBoxColumn.Name = "iDUNIDADDataGridViewTextBoxColumn";
            this.iDUNIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUNIDADDataGridViewTextBoxColumn.Width = 50;
            // 
            // pROPIETARIODataGridViewTextBoxColumn
            // 
            this.pROPIETARIODataGridViewTextBoxColumn.DataPropertyName = "PROPIETARIO";
            this.pROPIETARIODataGridViewTextBoxColumn.HeaderText = "PROPIETARIO";
            this.pROPIETARIODataGridViewTextBoxColumn.Name = "pROPIETARIODataGridViewTextBoxColumn";
            this.pROPIETARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cHOFERDataGridViewTextBoxColumn
            // 
            this.cHOFERDataGridViewTextBoxColumn.DataPropertyName = "CHOFER";
            this.cHOFERDataGridViewTextBoxColumn.HeaderText = "CHOFER";
            this.cHOFERDataGridViewTextBoxColumn.Name = "cHOFERDataGridViewTextBoxColumn";
            this.cHOFERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMEROUNIDADDataGridViewTextBoxColumn
            // 
            this.nUMEROUNIDADDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_UNIDAD";
            this.nUMEROUNIDADDataGridViewTextBoxColumn.HeaderText = "UNIDAD";
            this.nUMEROUNIDADDataGridViewTextBoxColumn.Name = "nUMEROUNIDADDataGridViewTextBoxColumn";
            this.nUMEROUNIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLACADataGridViewTextBoxColumn
            // 
            this.pLACADataGridViewTextBoxColumn.DataPropertyName = "PLACA";
            this.pLACADataGridViewTextBoxColumn.HeaderText = "PLACA";
            this.pLACADataGridViewTextBoxColumn.Name = "pLACADataGridViewTextBoxColumn";
            this.pLACADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOLORDataGridViewTextBoxColumn
            // 
            this.cOLORDataGridViewTextBoxColumn.DataPropertyName = "COLOR";
            this.cOLORDataGridViewTextBoxColumn.HeaderText = "COLOR";
            this.cOLORDataGridViewTextBoxColumn.Name = "cOLORDataGridViewTextBoxColumn";
            this.cOLORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aUTORIZACIONDataGridViewTextBoxColumn
            // 
            this.aUTORIZACIONDataGridViewTextBoxColumn.DataPropertyName = "AUTORIZACION";
            this.aUTORIZACIONDataGridViewTextBoxColumn.HeaderText = "AUTORIZACION";
            this.aUTORIZACIONDataGridViewTextBoxColumn.Name = "aUTORIZACIONDataGridViewTextBoxColumn";
            this.aUTORIZACIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mATRICULADataGridViewTextBoxColumn
            // 
            this.mATRICULADataGridViewTextBoxColumn.DataPropertyName = "MATRICULA";
            this.mATRICULADataGridViewTextBoxColumn.HeaderText = "MATRICULA";
            this.mATRICULADataGridViewTextBoxColumn.Name = "mATRICULADataGridViewTextBoxColumn";
            this.mATRICULADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSTADODataGridViewTextBoxColumn.Visible = false;
            // 
            // uNIDADESBindingSource
            // 
            this.uNIDADESBindingSource.DataMember = "UNIDADES";
            this.uNIDADESBindingSource.DataSource = this.taxisDataSet;
            // 
            // taxisDataSet
            // 
            this.taxisDataSet.DataSetName = "taxisDataSet";
            this.taxisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Location = new System.Drawing.Point(86, 26);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(162, 20);
            this.txtPropietario.TabIndex = 11;
            // 
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(86, 55);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(162, 20);
            this.txtChofer.TabIndex = 12;
            // 
            // txtNumero_Unidad
            // 
            this.txtNumero_Unidad.Location = new System.Drawing.Point(524, 52);
            this.txtNumero_Unidad.Name = "txtNumero_Unidad";
            this.txtNumero_Unidad.Size = new System.Drawing.Size(100, 20);
            this.txtNumero_Unidad.TabIndex = 13;
            // 
            // txtAutorizacion
            // 
            this.txtAutorizacion.Location = new System.Drawing.Point(86, 90);
            this.txtAutorizacion.Name = "txtAutorizacion";
            this.txtAutorizacion.Size = new System.Drawing.Size(162, 20);
            this.txtAutorizacion.TabIndex = 14;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(322, 26);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 15;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(524, 26);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 16;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(322, 56);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 17;
            // 
            // txtBuscarUnidad
            // 
            this.txtBuscarUnidad.Location = new System.Drawing.Point(165, 26);
            this.txtBuscarUnidad.Name = "txtBuscarUnidad";
            this.txtBuscarUnidad.Size = new System.Drawing.Size(122, 20);
            this.txtBuscarUnidad.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Buscar Usuario:";
            // 
            // grbDatosUnidad
            // 
            this.grbDatosUnidad.Controls.Add(this.txtColor);
            this.grbDatosUnidad.Controls.Add(this.txtMatricula);
            this.grbDatosUnidad.Controls.Add(this.txtPlaca);
            this.grbDatosUnidad.Controls.Add(this.txtAutorizacion);
            this.grbDatosUnidad.Controls.Add(this.txtNumero_Unidad);
            this.grbDatosUnidad.Controls.Add(this.txtChofer);
            this.grbDatosUnidad.Controls.Add(this.txtPropietario);
            this.grbDatosUnidad.Controls.Add(this.label8);
            this.grbDatosUnidad.Controls.Add(this.label7);
            this.grbDatosUnidad.Controls.Add(this.label6);
            this.grbDatosUnidad.Controls.Add(this.label5);
            this.grbDatosUnidad.Controls.Add(this.label4);
            this.grbDatosUnidad.Controls.Add(this.label3);
            this.grbDatosUnidad.Controls.Add(this.label2);
            this.grbDatosUnidad.Location = new System.Drawing.Point(19, 24);
            this.grbDatosUnidad.Name = "grbDatosUnidad";
            this.grbDatosUnidad.Size = new System.Drawing.Size(630, 130);
            this.grbDatosUnidad.TabIndex = 22;
            this.grbDatosUnidad.TabStop = false;
            this.grbDatosUnidad.Text = "Datos de la Unidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarUnidad);
            this.groupBox3.Controls.Add(this.txtBuscarUnidad);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbl_ID);
            this.groupBox3.Location = new System.Drawing.Point(19, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 63);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // btnBuscarUnidad
            // 
            this.btnBuscarUnidad.Image = global::TaxiRemesas.Properties.Resources.buscar;
            this.btnBuscarUnidad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarUnidad.Location = new System.Drawing.Point(304, 14);
            this.btnBuscarUnidad.Name = "btnBuscarUnidad";
            this.btnBuscarUnidad.Size = new System.Drawing.Size(108, 39);
            this.btnBuscarUnidad.TabIndex = 21;
            this.btnBuscarUnidad.Text = "Buscar";
            this.btnBuscarUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUnidad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarUnidad.UseVisualStyleBackColor = true;
            this.btnBuscarUnidad.Click += new System.EventHandler(this.btnBuscarUnidad_Click);
            // 
            // uNIDADESTableAdapter
            // 
            this.uNIDADESTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::TaxiRemesas.Properties.Resources.borrar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(665, 117);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 39);
            this.btnEliminar.TabIndex = 35;
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
            this.btnSalir.Location = new System.Drawing.Point(533, 173);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 39);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::TaxiRemesas.Properties.Resources.guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(665, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 39);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::TaxiRemesas.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(665, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 39);
            this.btnCancelar.TabIndex = 32;
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
            this.btnModificar.Location = new System.Drawing.Point(665, 63);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 39);
            this.btnModificar.TabIndex = 33;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 416);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbDatosUnidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvTablaUnidad);
            this.Controls.Add(this.btnModificar);
            this.Name = "frmUnidad";
            this.Text = "Formulario de Unidades de Transporte";
            this.Load += new System.EventHandler(this.frmUnidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxisDataSet)).EndInit();
            this.grbDatosUnidad.ResumeLayout(false);
            this.grbDatosUnidad.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTablaUnidad;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.TextBox txtNumero_Unidad;
        private System.Windows.Forms.TextBox txtAutorizacion;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtBuscarUnidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarUnidad;
        private System.Windows.Forms.GroupBox grbDatosUnidad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private taxisDataSet taxisDataSet;
        private System.Windows.Forms.BindingSource uNIDADESBindingSource;
        private taxisDataSetTableAdapters.UNIDADESTableAdapter uNIDADESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUNIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPIETARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHOFERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROUNIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLACADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOLORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTORIZACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATRICULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
    }
}