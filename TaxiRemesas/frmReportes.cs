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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {   
            if(cmbFiltro.Text == "Dirección")
            {
                frmMostrarReporteFiltro frmReport = new frmMostrarReporteFiltro();
                frmReport.fecha = dtpFecha.Value;
                frmReport.fechafin = dtpFecha2.Value;
                frmReport.direccion = txtDireccion.Text;
                frmReport.Show();
            }
            else if (cmbFiltro.Text == "Fechas")
            {
                frmMostrarReporte frmReport = new frmMostrarReporte();
                frmReport.fecha = dtpFecha.Value;
                frmReport.fechafin = dtpFecha2.Value;
                frmReport.Show();
            }
            else{
                MessageBox.Show("Debe seleccionar una filtro");
            }
            
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            cmbFiltro.Items.Add("Fechas");
            cmbFiltro.Items.Add("Dirección");
        }

        private void cmbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.Text == "Fechas")
            {
                txtDireccion.Enabled = false;
            }
            else
            {
                txtDireccion.Enabled = true;
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbFiltro.Text == "Fechas")
            {
                txtDireccion.Enabled = false;
            }
            else
            {
                txtDireccion.Enabled = true;
            }
        }
    }
}
