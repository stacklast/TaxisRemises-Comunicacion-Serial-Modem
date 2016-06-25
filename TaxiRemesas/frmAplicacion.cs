using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaxiRemesas
{
    public partial class frmAplicacion : Form
    {
       CommunicationManager comm = new CommunicationManager();
       CommunicationManager comm2 = new CommunicationManager();
        BD conexion = new BD();
        BD conexion2 = new BD();
        //string transType = string.Empty;
        OperacionesDB ins = new OperacionesDB();
        public static frmAplicacion f1;
        public frmAplicacion()
        {
            InitializeComponent();
            //asignando la instancia actual
            frmAplicacion.f1 = this;
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            
            try
            {
                dgvAsignaciones.DataSource = ins.ActualizarGridAsignaciones();


                conexion.Conectar();
                SqlCommand comando = new SqlCommand("Select * from CONFIGURACIONES where PUERTO = 'COM3';", conexion.ObtenerMiConexion());


                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    comm.Parity = leer["PARIDAD"].ToString();
                    comm.StopBits = leer["BITS_PARADA"].ToString();
                    comm.DataBits = leer["BITS_DATOS"].ToString();
                    comm.BaudRate = leer["VELOCIDAD"].ToString();
                    comm.DisplayWindow = richTextBox1;
                    comm.DisplayCallNumber = caller1;
                    comm.PortName = leer["PUERTO"].ToString();
                    comm.OpenPort();
                    comm.WriteData("AT");
                    // comm.WriteData("ATZ");
                    comm.WriteData("AT+VCID=1");
                    conexion.Desconectar();
                }

                conexion2.Conectar();
                SqlCommand comando1 = new SqlCommand("Select * from CONFIGURACIONES where PUERTO = 'COM4';", conexion2.ObtenerMiConexion());


                SqlDataReader leer1 = comando1.ExecuteReader();
                if (leer1.Read() == true)
                {
                    comm2.Parity = leer1["PARIDAD"].ToString();
                    comm2.StopBits = leer1["BITS_PARADA"].ToString();
                    comm2.DataBits = leer1["BITS_DATOS"].ToString();
                    comm2.BaudRate = leer1["VELOCIDAD"].ToString();
                    comm2.DisplayCallNumber = caller2;
                    comm2.DisplayWindow = richTextBox1;
                    comm2.PortName = leer1["PUERTO"].ToString();
                    comm2.OpenPort();
                    comm2.WriteData("AT");
                    comm2.WriteData("AT+VCID=1");
                    conexion2.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }



        }

        private void caller2_TextChanged(object sender, EventArgs e)
        {
            if(caller2.Text != "Llamada Modem 2")
            {
                frmRegistrosLlamadas frmCall = new frmRegistrosLlamadas();
                frmCall.Numero = caller2.Text;
                frmCall.Show();
                caller2.Text = "Llamada Modem 2"; 
            }
            
        }

        private void caller1_TextChanged(object sender, EventArgs e)
        {
            if(caller1.Text != "Llamada Modem 1")
            {
                frmRegistrosLlamadas frmCall = new frmRegistrosLlamadas();
                frmCall.Numero = caller1.Text;
                frmCall.Show();
                caller1.Text = "Llamada Modem 1"; 
            }
        }

        private void frmAplicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            comm.ClosePort();
            comm2.ClosePort();
            System.Threading.Thread.Sleep(5000);
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try { 
                dgvAsignaciones.DataSource = ins.ActualizarGridAsignacionesBuscar(txtBusquedaAsignaciones.Text);
            }
            catch(Exception ex){
                MessageBox.Show("No se ha Encontrado Datos");
            }
        }

        private void dgvAsignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    string id_asignaciones;
                    id_asignaciones = dgvAsignaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
                    frmRegistrosLlamadas frmCall = new frmRegistrosLlamadas();
                    frmCall.Id_asignaciones = Convert.ToInt32(id_asignaciones);
                    frmCall.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
               
            }

        }
        public void refrescar()
        {
            dgvAsignaciones.DataSource = ins.ActualizarGridAsignaciones();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgvAsignaciones.DataSource = ins.ActualizarGridAsignaciones();
           
        }

        private void btnCelular_Click(object sender, EventArgs e)
        {
            frmRegistrosLlamadas frmCall = new frmRegistrosLlamadas("vacio");
            frmCall.Show();
        }
    }
}
