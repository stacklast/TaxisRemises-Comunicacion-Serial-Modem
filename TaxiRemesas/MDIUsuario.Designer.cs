namespace TaxiRemesas
{
    partial class MDIUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIUsuario));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grbDatosInfo = new System.Windows.Forms.GroupBox();
            this.lblNombreMaquina = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grbDatosInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(791, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.aplicaciónToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 109);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // grbDatosInfo
            // 
            this.grbDatosInfo.BackColor = System.Drawing.Color.DarkCyan;
            this.grbDatosInfo.Controls.Add(this.lblNombreMaquina);
            this.grbDatosInfo.Controls.Add(this.lblFecha);
            this.grbDatosInfo.Controls.Add(this.lblFechaActual);
            this.grbDatosInfo.Controls.Add(this.lblMaquina);
            this.grbDatosInfo.Controls.Add(this.lblHora);
            this.grbDatosInfo.Controls.Add(this.lblHoraActual);
            this.grbDatosInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbDatosInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosInfo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.grbDatosInfo.Location = new System.Drawing.Point(452, 8);
            this.grbDatosInfo.Name = "grbDatosInfo";
            this.grbDatosInfo.Size = new System.Drawing.Size(339, 101);
            this.grbDatosInfo.TabIndex = 16;
            this.grbDatosInfo.TabStop = false;
            this.grbDatosInfo.Text = "Datos Informativos";
            // 
            // lblNombreMaquina
            // 
            this.lblNombreMaquina.AutoSize = true;
            this.lblNombreMaquina.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMaquina.Location = new System.Drawing.Point(47, 21);
            this.lblNombreMaquina.Name = "lblNombreMaquina";
            this.lblNombreMaquina.Size = new System.Drawing.Size(59, 13);
            this.lblNombreMaquina.TabIndex = 11;
            this.lblNombreMaquina.Text = "Máquina:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(139, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.Location = new System.Drawing.Point(47, 77);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(46, 13);
            this.lblFechaActual.TabIndex = 12;
            this.lblFechaActual.Text = "Fecha:";
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.BackColor = System.Drawing.Color.Transparent;
            this.lblMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaquina.Location = new System.Drawing.Point(139, 16);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(71, 20);
            this.lblMaquina.TabIndex = 5;
            this.lblMaquina.Text = "Nombre";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(139, 41);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(88, 24);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "00:00:00";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.Location = new System.Drawing.Point(47, 49);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(38, 13);
            this.lblHoraActual.TabIndex = 10;
            this.lblHoraActual.Text = "Hora:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::TaxiRemesas.Properties.Resources.monitor64x64;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 105);
            this.toolStripMenuItem1.Text = "&Sistema";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "&Salir";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unidadesToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Image = global::TaxiRemesas.Properties.Resources.tablet;
            this.toolStripMenuItem3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(128, 105);
            this.toolStripMenuItem3.Text = "&Configuraciones";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // unidadesToolStripMenuItem
            // 
            this.unidadesToolStripMenuItem.Image = global::TaxiRemesas.Properties.Resources.taxi;
            this.unidadesToolStripMenuItem.Name = "unidadesToolStripMenuItem";
            this.unidadesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.unidadesToolStripMenuItem.Text = "Unidades";
            this.unidadesToolStripMenuItem.Click += new System.EventHandler(this.unidadesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::TaxiRemesas.Properties.Resources._15_clientes;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // aplicaciónToolStripMenuItem
            // 
            this.aplicaciónToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aplicaciónToolStripMenuItem.Image = global::TaxiRemesas.Properties.Resources.centro_llamadas;
            this.aplicaciónToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aplicaciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aplicaciónToolStripMenuItem.Name = "aplicaciónToolStripMenuItem";
            this.aplicaciónToolStripMenuItem.Size = new System.Drawing.Size(87, 105);
            this.aplicaciónToolStripMenuItem.Text = "Aplicación";
            this.aplicaciónToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aplicaciónToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.aplicaciónToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.aplicaciónToolStripMenuItem.Click += new System.EventHandler(this.aplicaciónToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Image = global::TaxiRemesas.Properties.Resources.reportes;
            this.reportesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(92, 105);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.reportesToolStripMenuItem.Visible = false;
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // MDIUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 453);
            this.Controls.Add(this.grbDatosInfo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "MDIUsuario";
            this.Text = "Perfil Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIUsuario_FormClosing);
            this.Load += new System.EventHandler(this.MDIUsuario_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbDatosInfo.ResumeLayout(false);
            this.grbDatosInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicaciónToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbDatosInfo;
        private System.Windows.Forms.Label lblNombreMaquina;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}



