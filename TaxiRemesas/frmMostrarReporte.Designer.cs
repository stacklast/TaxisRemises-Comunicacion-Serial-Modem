namespace TaxiRemesas
{
    partial class frmMostrarReporte
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.taxisDataSet = new TaxiRemesas.taxisDataSet();
            this.Reporte_LlamadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_LlamadasTableAdapter = new TaxiRemesas.taxisDataSetTableAdapters.Reporte_LlamadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.taxisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_LlamadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetTaxi";
            reportDataSource1.Value = this.Reporte_LlamadasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TaxiRemesas.ReporteAsignaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(858, 564);
            this.reportViewer1.TabIndex = 0;
            // 
            // taxisDataSet
            // 
            this.taxisDataSet.DataSetName = "taxisDataSet";
            this.taxisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_LlamadasBindingSource
            // 
            this.Reporte_LlamadasBindingSource.DataMember = "Reporte_Llamadas";
            this.Reporte_LlamadasBindingSource.DataSource = this.taxisDataSet;
            // 
            // Reporte_LlamadasTableAdapter
            // 
            this.Reporte_LlamadasTableAdapter.ClearBeforeFill = true;
            // 
            // frmMostrarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 564);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMostrarReporte";
            this.Text = "Mostrar Reporte";
            this.Load += new System.EventHandler(this.frmMostrarReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_LlamadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_LlamadasBindingSource;
        private taxisDataSet taxisDataSet;
        private taxisDataSetTableAdapters.Reporte_LlamadasTableAdapter Reporte_LlamadasTableAdapter;
    }
}