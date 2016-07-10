using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxiRemesas
{
    public partial class frmMostrarReporte : Form
    {
        public frmMostrarReporte()
        {
            InitializeComponent();
        }

        public DateTime fecha { get; set; }
        public DateTime fechafin { get; set; }
        public String direccion { get; set; }
        private void frmMostrarReporte_Load(object sender, EventArgs e)
        {
            this.taxisDataSet.EnforceConstraints = false;
            // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.Reporte_Llamadas' Puede moverla o quitarla según sea necesario.
            this.Reporte_LlamadasTableAdapter.Fill(this.taxisDataSet.Reporte_Llamadas,fecha,fechafin);

            this.reportViewer1.RefreshReport();
        }
    }
}
