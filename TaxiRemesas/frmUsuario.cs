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
    public partial class frmUsuario : Form
    {
        OperacionesDB ins = new OperacionesDB();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rol = cmbRol.Text;
                string pass = txtPass.Text;
                string user = txtUsuario.Text;

                ins.Inserta_Usuario(rol, pass, user);
                // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
                this.uSUARIOSTableAdapter.Fill(this.taxisDataSet.USUARIOS);
                IniciarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al insertar datos " + ex);
            }
        }
        private void IniciarControles()
        {
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            txtPass.Text = "";
            txtUsuario.Text = "";
            cmbRol.SelectedValue = 1;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.taxisDataSet.USUARIOS);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string rol = cmbRol.Text;
                string pass = txtPass.Text;
                string user = txtUsuario.Text;
                int id = Convert.ToInt32(lbl_ID.Text);
                ins.Actualiza_Usuario(id, rol, pass, user, 'A');
                // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
                this.uSUARIOSTableAdapter.Fill(this.taxisDataSet.USUARIOS);
                IniciarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al insertar datos " + ex);
            }
        }

        private void gvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblID.Text = gvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbRol.SelectedItem = gvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPass.Text = gvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtUsuario.Text = gvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                //Estado = dgvConfiguraciones.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string rol = cmbRol.Text;
                string pass = txtPass.Text;
                string user = txtUsuario.Text;
                int id = Convert.ToInt32(lbl_ID.Text);
                ins.Actualiza_Usuario(id, rol, pass, user, 'X');
                // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
                this.uSUARIOSTableAdapter.Fill(this.taxisDataSet.USUARIOS);
                IniciarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al eliminar datos " + ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IniciarControles();
        }


    }
}
