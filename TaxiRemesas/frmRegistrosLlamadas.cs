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
    public partial class frmRegistrosLlamadas : Form
    {
        private string numero;
        private int id_asignaciones;

        public int Id_asignaciones
        {
            get { return id_asignaciones; }
            set { id_asignaciones = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        OperacionesDB ins = new OperacionesDB();
        public frmRegistrosLlamadas()
        {
            InitializeComponent();
        }

        public frmRegistrosLlamadas(string numero)
            : this()
        {

                this.numero = numero;            
        }
        private void frmRegistrosLlamadas_Load(object sender, EventArgs e)
        {
            InicializaCombo();
            if(numero != "vacio")
            {
                if (id_asignaciones > 0)
                {
                    btnRegistro.Visible = false;
                    btnAsignarUnidad.Visible = true;
                    ActualizarCamposAsignaciones();
                }
                else
                {

                    ObtieneNumeroCajas();
                    mostrarElementos();
                    btnRegistro.Visible = true;
                    btnAsignarUnidad.Visible = false;
                    ActualizarCamposTelefono();
                    btnRegistro.Enabled = true;
                }
            }
            else
            {
                mostrarElementos();
                btnRegistro.Visible = true;
                btnAsignarUnidad.Visible = false;
                //ActualizarCamposTelefono();
                btnRegistro.Enabled = true;
            }
            
            
            
        }
        public void ObtieneNumeroCajas()
        {
            string numID = this.numero;
            numID = numID.Replace("=", "");
            lblNumero.Text = numID;
            txtTelefono.Text = numID;
        }
        public void InicializaCombo()
        {
            int num = Convert.ToInt32(ins.DevuelveNumUnidades());
            if (num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    cmbUnidad.Items.Add(i);
                }
            }
            else
            {
                for (int i = 1; i <= 40; i++)
                {
                    cmbUnidad.Items.Add(i);
                }
            }
        }
        public void ActualizarCamposTelefono()
        {
            string numID = this.numero;
            numID = numID.Replace("=", "");
            DataTable dtCliente = ins.ActualizarGridClienteTelefono(numID);

            if (dtCliente.Rows.Count != 0)
            {
                lblMensaje.Text = "Cliente Encontrado";
                txtNombre.Text = dtCliente.Rows[0]["NOMBRE"].ToString();
                txtTelefono.Text = dtCliente.Rows[0]["TELEFONO"].ToString();
                txtCelular.Text = dtCliente.Rows[0]["CELULAR"].ToString();
                txtDireccion.Text = dtCliente.Rows[0]["DIRECCION"].ToString();
                txtReferencia.Text = dtCliente.Rows[0]["REFERENCIA"].ToString();
                lblIDCli.Text = dtCliente.Rows[0]["ID_CLIENTE"].ToString();
                Habilita(false);
            }
            else
            {
                lblMensaje.Text = "No Hay un cliente encontrado ingrese los datos para poder asignarlo";
                btnRegistro.Enabled = false;
                cmbUnidad.Enabled = false;
            }
        }

        public void ActualizarCamposAsignaciones()
        {

            DataTable dtAsignaciones = ins.ActualizarGridAsignacionesBuscarID(Convert.ToString(this.id_asignaciones));
            //MessageBox.Show(Convert.ToString(this.id_asignaciones));
            if (dtAsignaciones.Rows.Count != 0)
            {
                lblMensaje.Text = "Asignar Unidad ";
                txtNombre.Text = dtAsignaciones.Rows[0]["NOMBRE"].ToString();
                txtTelefono.Text = dtAsignaciones.Rows[0]["TELEFONO"].ToString();
                txtCelular.Text = dtAsignaciones.Rows[0]["CELULAR"].ToString();
                txtDireccion.Text = dtAsignaciones.Rows[0]["DIRECCION"].ToString();
                txtReferencia.Text = dtAsignaciones.Rows[0]["REFERENCIA"].ToString();
                lblIDCli.Text = dtAsignaciones.Rows[0]["ID_CLIENTE"].ToString();
                txtDireccionOrigen.Text = dtAsignaciones.Rows[0]["DIRECCION_ORIGEN"].ToString();

                
                if (dtAsignaciones.Rows[0]["NUM_UNIDAD"] != null)
                {
                    cmbUnidad.SelectedText = dtAsignaciones.Rows[0]["NUM_UNIDAD"].ToString();
                }
               
                Habilita(false);
                lblFecha.Visible = false;
                lblHora.Visible = false;
            }
            else
            {
                lblMensaje.Text = "No se Puede Asignar una unidad";
                btnRegistro.Enabled = false;
                cmbUnidad.Enabled = false;
            }
        }

        public void mostrarElementos()
        {
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToLongTimeString();
            lblFecha.Text = fecha;
            lblHora.Text = hora;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mostrarElementos();
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

                DataTable dtCliente = ins.ActualizarGridCliente(telefono);

                if (dtCliente.Rows.Count != 0)
                {
                    lblMensaje.Text = "Cliente Encontrado";
                    txtNombre.Text = dtCliente.Rows[0]["NOMBRE"].ToString();
                    txtTelefono.Text = dtCliente.Rows[0]["TELEFONO"].ToString();
                    txtCelular.Text = dtCliente.Rows[0]["CELULAR"].ToString();
                    txtDireccion.Text = dtCliente.Rows[0]["DIRECCION"].ToString();
                    txtReferencia.Text = dtCliente.Rows[0]["REFERENCIA"].ToString();
                    lblIDCli.Text = dtCliente.Rows[0]["ID_CLIENTE"].ToString();
                    Habilita(false);
                    btnRegistro.Enabled = true;
                    cmbUnidad.Enabled = true;
                }
                else
                {
                    lblMensaje.Text = "No Hay un cliente encontrado ingrese los datos para poder asignarlo";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al insertar datos " + ex);
            }
            limpiar();

        }
        public void limpiar()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
            txtReferencia.Text = "";
        }
        public void Habilita(bool valor)
        {
            txtNombre.Enabled = valor;
            txtTelefono.Enabled = valor;
            txtCelular.Enabled = valor;
            txtDireccion.Enabled = valor;
            txtReferencia.Enabled = valor;
           // txtDireccionOrigen.Enabled = valor;
        }
        private void btnRegistro_Click(object sender, EventArgs e)
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

                DataTable dtCliente = ins.ActualizarGridCliente(telefono);

                if (dtCliente.Rows.Count != 0)
                {
                    lblMensaje.Text = "Cliente Encontrado";
                    txtNombre.Text = dtCliente.Rows[0]["NOMBRE"].ToString();
                    txtTelefono.Text = dtCliente.Rows[0]["TELEFONO"].ToString();
                    txtCelular.Text = dtCliente.Rows[0]["CELULAR"].ToString();
                    txtDireccion.Text = dtCliente.Rows[0]["DIRECCION"].ToString();
                    txtReferencia.Text = dtCliente.Rows[0]["REFERENCIA"].ToString();
                    lblIDCli.Text = dtCliente.Rows[0]["ID_CLIENTE"].ToString();
                    Habilita(false);
                    btnRegistro.Enabled = true;
                    cmbUnidad.Enabled = true;
                }
                else
                {
                    lblMensaje.Text = "No Hay un cliente encontrado ingrese los datos para poder asignarlo";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al insertar datos " + ex);
            }
            limpiar();
            if (lblIDCli.Text != "")
            {
                try
                {
                    string direct;
                    int? unidad;
                    if (txtDireccionOrigen.Text == "")
                    {
                        direct = txtDireccion.Text;
                    }
                    else
                    {

                        direct = txtDireccionOrigen.Text;
                    }
                    if (cmbUnidad.Text == "")
                    {
                        unidad = null;
                    }
                    else
                    {
                        unidad = Convert.ToInt32(cmbUnidad.Text);
                    }

                    ins.Inserta_Asignaciones(unidad,Convert.ToInt32(lblIDCli.Text), DateTime.Now, DateTime.Now, direct);
                    MessageBox.Show("Asignación Realizada!");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                limpiar();
            }
            else
            {
                MessageBox.Show("No se puede Ingresar un Registro sin existir un Cliente");
                limpiar();
            }
            frmAplicacion.f1.refrescar();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmAplicacion.f1.refrescar();
            this.Close();
        }

        private void btnAsignarUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                ins.Actualiza_Asignaciones(Convert.ToInt32(this.id_asignaciones), Convert.ToInt32(cmbUnidad.Text), txtDireccionOrigen.Text);
                MessageBox.Show("Se ha agregado la Unidad " + cmbUnidad.Text + " a la llamada telefónica");

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido agregar la Unidad");
            }
            frmAplicacion.f1.refrescar();
        }

        private void checkBoxDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDireccion.Checked)
            {
                txtDireccionOrigen.Text = txtDireccion.Text + txtReferencia.Text;
            }
            else {
                txtDireccionOrigen.Text = "";
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* Validaciones.es_domicilio(e);*/
        }

    }
}
