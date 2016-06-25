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
    public partial class frmMostrarReporteFiltro : Form
    {
        public frmMostrarReporteFiltro()
        {
            InitializeComponent();
        }

        public DateTime fecha { get; set; }
        public DateTime fechafin { get; set; }
        public String direccion { get; set; }
        private void frmMostrarReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.Reporte_Llamadas' Puede moverla o quitarla según sea necesario.
            this.Reporte_Llamadas_DireccionTableAdapter.Fill(this.taxisDataSet.Reporte_Llamadas_Direccion, fecha, fechafin, direccion);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
