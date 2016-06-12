using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiRemesas
{
    public partial class frmUnidad : Form
    {
        OperacionesDB ins = new OperacionesDB();
        public frmUnidad()
        {
            InitializeComponent();
        }

        private void frmUnidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.UNIDADES' Puede moverla o quitarla según sea necesario.
            this.uNIDADESTableAdapter.Fill(this.taxisDataSet.UNIDADES);
            IniciarControles();

        }
        private void IniciarControles()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtPropietario.Text = "";
            txtChofer.Text = "";
            txtAutorizacion.Text = "";
            txtPlaca.Text = "";
            txtColor.Text = "";
            txtMatricula.Text = "";
            txtNumero_Unidad.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string propietario = txtPropietario.Text;
                string chofer = txtChofer.Text;
                string autorizacion = txtAutorizacion.Text;
                string placa = txtPlaca.Text;
                string color = txtColor.Text;
                string matricula = txtMatricula.Text;
                int numero_unidad = Convert.ToInt32(txtNumero_Unidad.Text);
                ins.Inserta_Unidad(propietario, chofer, numero_unidad, placa, color, autorizacion, matricula, 'A');
                this.uNIDADESTableAdapter.Fill(this.taxisDataSet.UNIDADES);
                IniciarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al insertar datos " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string propietario = txtPropietario.Text;
                string chofer = txtChofer.Text;
                string autorizacion = txtAutorizacion.Text;
                string placa = txtPlaca.Text;
                string color = txtColor.Text;
                string matricula = txtMatricula.Text;
                int numero_unidad = Convert.ToInt32(txtNumero_Unidad.Text);
                int id = Convert.ToInt32(lbl_ID.Text);

                ins.Actualiza_Unidad(id, propietario, chofer, numero_unidad, placa, color, autorizacion, matricula, 'X');
                this.uNIDADESTableAdapter.Fill(this.taxisDataSet.UNIDADES);
                IniciarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al eliminar datos " + ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string propietario = txtPropietario.Text;
                string chofer = txtChofer.Text;
                string autorizacion = txtAutorizacion.Text;
                string placa = txtPlaca.Text;
                string color = txtColor.Text;
                string matricula = txtMatricula.Text;
                int numero_unidad = Convert.ToInt32(txtNumero_Unidad.Text);
                int id = Convert.ToInt32(lbl_ID.Text);

                ins.Actualiza_Unidad(id, propietario, chofer, numero_unidad, placa, color, autorizacion, matricula, 'A');
                this.uNIDADESTableAdapter.Fill(this.taxisDataSet.UNIDADES);
                IniciarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al modificar datos " + ex);
            }
        }

        private void dgvTablaUnidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lbl_ID.Text = dgvTablaUnidad.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPropietario.Text = dgvTablaUnidad.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtChofer.Text = dgvTablaUnidad.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAutorizacion.Text = dgvTablaUnidad.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPlaca.Text = dgvTablaUnidad.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtColor.Text = dgvTablaUnidad.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMatricula.Text = dgvTablaUnidad.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNumero_Unidad.Text = dgvTablaUnidad.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IniciarControles();
        }
    }
}
