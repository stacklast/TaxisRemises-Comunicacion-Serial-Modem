using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiRemesas.Properties;

namespace TaxiRemesas
{
    public class BD
    {
        SqlConnection MiConexion;//OBJETO DE CONEXION
        //METODO CONECTAR

        public void Conectar()
        {
            try
            {
                //la cadena de conexión va a cambiar en sus computadoras... 
                //string cadena_conexion = @"Data Source=EDWIN\SQLEXPRESS;Initial Catalog=taxis;Integrated Security=True";
                string cadena_conexion = Settings.Default.taxisConnectionString;
                MiConexion = new SqlConnection(cadena_conexion);
                MiConexion.Open();//ABRIMOS LA CONEXION
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la conexion BD " + ex);
            }
            
        }

        //METODO PARA DESCONECTARSE
        public void Desconectar()
        {

            MiConexion.Close();
        }

        //METODO CON PARAMETRO
        public SqlConnection ObtenerMiConexion()
        {
            return MiConexion;
        }
    }
}
