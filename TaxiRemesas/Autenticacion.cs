using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiRemesas
{
    public partial class Autenticacion : Form
    {
        private int intentos = 3;
        OperacionesDB ins = new OperacionesDB();
        public Autenticacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            string user = txtUsuario.Text;
            string pass = txtContraseña.Text;
            string tipoPrivilegio;

            if (ins.Autentificar(user, pass) > 0)
            {
                tipoPrivilegio = ins.DevuelvePrivilegio(user, pass);

                if (tipoPrivilegio == "ADMINISTRADOR")
                {
                    MessageBox.Show("Usuario correcto", "Bienvenido Al Sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    MDIAdministrador adm = new MDIAdministrador(user);
                    adm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario correcto", "Bienvenido Al Sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    /*string idCliente = controlUsuario.DevuelveIdCliente(alias, pass);
                    MDICliente adm = new MDICliente(idCliente);
                    adm.ShowDialog();*/
                }

            }
            else
            {
                if (intentos == 0)
                {
                    MessageBox.Show("Lo lamento a completado los 3 Intentos", "Login Fallido !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto Le quedan : " + intentos + " intentos", "Error al Ingresar! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Text = "";
                    txtUsuario.Text = "";
                    intentos--;
                }
            }
        }
    }
}
