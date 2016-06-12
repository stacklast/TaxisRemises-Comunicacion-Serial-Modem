using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using PCComm;


namespace TaxiRemesas
{
    public partial class frmConfiguraModem : Form
    {
        CommunicationManager comm = new CommunicationManager();
        string transType = string.Empty;
        OperacionesDB ins = new OperacionesDB();

        public frmConfiguraModem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.CONFIGURACIONES' Puede moverla o quitarla según sea necesario.
            this.cONFIGURACIONESTableAdapter.Fill(this.taxisDataSet.CONFIGURACIONES);
            InicializarCombos();
            ValoresPorDefecto();
            IniciarControles();
        }
        /// <summary>
        /// methos to load our serial
        /// port option values
        /// </summary>
        private void InicializarCombos()
        {
            comm.SetPortNameValues(cmbPuerto);
            comm.SetParityValues(cmbParidad);
            comm.SetStopBitValues(cmbBitsParada);
        }
        private void ValoresPorDefecto()
        {
            cmbPuerto.SelectedIndex = 0;
            cmbVelocidad.SelectedIndex = 5;
            cmbParidad.SelectedIndex = 0;
            cmbBitsParada.SelectedIndex = 1;
            cmbBitsDatos.SelectedIndex = 1;
        }
        private void IniciarControles()
        {
            rdoText.Checked = true;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnEnviar.Enabled = false;
            txtSend.Enabled = false;
            txtNumero.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            comm.Parity = cmbParidad.Text;
            comm.StopBits = cmbBitsParada.Text;
            comm.DataBits = cmbBitsDatos.Text;
            comm.BaudRate = cmbVelocidad.Text;
            comm.DisplayWindow = rtbRecibe;
            comm.DisplayCallNumber = lblCallerID;
            comm.PortName = cmbPuerto.Text;
            comm.OpenPort();
            comm.WriteData("AT");
           // comm.WriteData("ATZ");
            comm.WriteData("AT+VCID=1");

            btnConectar.Enabled = false;
            btnDesconectar.Enabled = true;
            btnEnviar.Enabled = true;
            txtSend.Enabled = true;
            txtNumero.Enabled = true;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            comm.ClosePort();
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnEnviar.Enabled = false;
        }

       
        private void btnColgarLlamada_Click(object sender, EventArgs e)
        {
            /*if ((serialPort1 != null) && (serialPort1.IsOpen == true)) // verifica que los puertos esten abiertos
                serialPort1.Write("ATH");*/
            comm.WriteData("ATH");
        }

        private void rdoHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHex.Checked == true)
            {
                comm.CurrentTransmissionType = PCComm.CommunicationManager.TransmissionType.Hex;
            }
            else
            {
                comm.CurrentTransmissionType = PCComm.CommunicationManager.TransmissionType.Text;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            comm.WriteData(txtSend.Text);
        }

        private void btnLlamar_Click_1(object sender, EventArgs e)
        {
            comm.WriteData("ATH");
            comm.WriteData("ATDT" + txtNumero.Text + ";");
        }

        private void btnContestar_Click(object sender, EventArgs e)
        {
           // comm.WriteData("ATA");
            comm.WriteData("ATM2"); // para que funcionen los auriculares
            comm.WriteData("ATA");
            //comm.WriteData("ATH0"); // para descolgar y contestar via auriculares  
        }

        private void grbAcciones_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try {
                string puerto = cmbPuerto.Text;
                int velocidad = Convert.ToInt32(cmbVelocidad.Text);
                string paridad = cmbParidad.Text;
                int bits_datos = Convert.ToInt32(cmbBitsDatos.Text);
                string bits_parada = cmbBitsParada.Text;
                ins.Inserta_Configuracion(puerto, velocidad, paridad, bits_datos, bits_parada);
                // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.CONFIGURACIONES' Puede moverla o quitarla según sea necesario.
                this.cONFIGURACIONESTableAdapter.Fill(this.taxisDataSet.CONFIGURACIONES);
                IniciarControles();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al insertar datos " + ex);
            }
        }

        private void dgvConfiguraciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblID.Text = dgvConfiguraciones.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbPuerto.SelectedItem = dgvConfiguraciones.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbVelocidad.SelectedItem = dgvConfiguraciones.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbParidad.SelectedItem = dgvConfiguraciones.Rows[e.RowIndex].Cells[3].Value.ToString();
                //Estado = dgvConfiguraciones.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbBitsDatos.SelectedItem = dgvConfiguraciones.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbBitsParada.SelectedItem = dgvConfiguraciones.Rows[e.RowIndex].Cells[6].Value.ToString();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblID.Text);
                string puerto = cmbPuerto.Text;
                int velocidad = Convert.ToInt32(cmbVelocidad.Text);
                string paridad = cmbParidad.Text;
                int bits_datos = Convert.ToInt32(cmbBitsDatos.Text);
                string bits_parada = cmbBitsParada.Text;
                ins.Actualiza_Configuracion(id, puerto, velocidad, paridad, 'A' , bits_datos, bits_parada);
                
                // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.CONFIGURACIONES' Puede moverla o quitarla según sea necesario.
                this.cONFIGURACIONESTableAdapter.Fill(this.taxisDataSet.CONFIGURACIONES);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al actualizar datos " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblID.Text);
                string puerto = cmbPuerto.Text;
                int velocidad = Convert.ToInt32(cmbVelocidad.Text);
                string paridad = cmbParidad.Text;
                int bits_datos = Convert.ToInt32(cmbBitsDatos.Text);
                string bits_parada = cmbBitsParada.Text;
                ins.Actualiza_Configuracion(id, puerto, velocidad, paridad, 'X', bits_datos, bits_parada);
                // TODO: esta línea de código carga datos en la tabla 'taxisDataSet.CONFIGURACIONES' Puede moverla o quitarla según sea necesario.
                this.cONFIGURACIONESTableAdapter.Fill(this.taxisDataSet.CONFIGURACIONES);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al actualizar datos " + ex);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cONFIGURACIONESTableAdapter.Fill(this.taxisDataSet.CONFIGURACIONES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ValoresPorDefecto();
        }

        
    }
}
