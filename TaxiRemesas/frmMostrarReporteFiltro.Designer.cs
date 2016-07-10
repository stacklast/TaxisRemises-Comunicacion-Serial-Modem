namespace TaxiRemesas
{
    partial class frmMostrarReporteFiltro
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Reporte_Llamadas_DireccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxisDataSet = new TaxiRemesas.taxisDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_Llamadas_DireccionTableAdapter = new TaxiRemesas.taxisDataSetTableAdapters.Reporte_Llamadas_DireccionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Llamadas_DireccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Reporte_Llamadas_DireccionBindingSource
            // 
            this.Reporte_Llamadas_DireccionBindingSource.DataMember = "Reporte_Llamadas_Direccion";
            this.Reporte_Llamadas_DireccionBindingSource.DataSource = this.taxisDataSet;
            // 
            // taxisDataSet
            // 
            this.taxisDataSet.DataSetName = "taxisDataSet";
            this.taxisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Reporte_Llamadas_DireccionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TaxiRemesas.ReporteFiltroDireccion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1021, 564);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Reporte_Llamadas_DireccionTableAdapter
            // 
            this.Reporte_Llamadas_DireccionTableAdapter.ClearBeforeFill = true;
            // 
            // frmMostrarReporteFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 564);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMostrarReporteFiltro";
            this.Text = "Mostrar Reporte";
            this.Load += new System.EventHandler(this.frmMostrarReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Llamadas_DireccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxisDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private taxisDataSet taxisDataSet;
        private System.Windows.Forms.BindingSource Reporte_Llamadas_DireccionBindingSource;
        private taxisDataSetTableAdapters.Reporte_Llamadas_DireccionTableAdapter Reporte_Llamadas_DireccionTableAdapter;
    }
}