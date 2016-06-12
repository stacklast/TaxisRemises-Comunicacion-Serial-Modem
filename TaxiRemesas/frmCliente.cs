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
    public partial class frmCliente : Form
    {
        OperacionesDB ins = new OperacionesDB();
        public frmCliente()
        {
            InitializeComponent();
            IniciarControles();
        }

        private void IniciarControles()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
            txtReferencia.Text = "";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.taxisDataSet.CLIENTES);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                string celular = txtCelular.Text;
                string direccion = txtDireccion.Text;
                string referecia = txtReferencia.Text;

                ins.Inserta_Cliente(telefono, celular, direccion, referecia, nombre);
                // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
                this.cLIENTESTableAdapter.Fill(this.taxisDataSet.CLIENTES);
                IniciarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al insertar datos " + ex);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                string celular = txtCelular.Text;
                string direccion = txtDireccion.Text;
                string referecia = txtReferencia.Text;
                int id = Convert.ToInt32(lblID.Text);
                ins.Actualiza_Cliente(id, telefono, celular, direccion, referecia, nombre, 'A');
                // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
                this.cLIENTESTableAdapter.Fill(this.taxisDataSet.CLIENTES);
                IniciarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al insertar datos " + ex);
            }
        }

        private void dgvTablaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblID.Text = dgvTablaCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTelefono.Text = dgvTablaCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCelular.Text = dgvTablaCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDireccion.Text = dgvTablaCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtReferencia.Text = dgvTablaCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNombre.Text = dgvTablaCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IniciarControles();
        }
    }
}
