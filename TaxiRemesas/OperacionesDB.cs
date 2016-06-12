
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiRemesas
{
    public class OperacionesDB
    {
        BD conexion = new BD();
        #region ///---AUTENTIFICACION----////
        public String DevuelvePrivilegio(String pUsuario, String pContraseña)
        {
            conexion.Conectar();
            SqlCommand _comando = new SqlCommand("SELECT * from USUARIOS  WHERE [USER] = '" + pUsuario + "' AND ESTADO = 'A' ;", conexion.ObtenerMiConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            _reader.Read();
            String valor = Convert.ToString(_reader["ROL"]);
            conexion.Desconectar();
            return valor;
        }

        public int Autentificar(String pUsuario, String pContraseña)
        {
            int resultado = -1;

            BD conexion = new BD();
            conexion.Conectar();

            string consulta = "SELECT * FROM USUARIOS WHERE [USER]= '{0}' AND PASS = '{1}' AND ESTADO = 'A'";
            SqlCommand _comando = new SqlCommand(
            String.Format(consulta, pUsuario, pContraseña), conexion.ObtenerMiConexion());
            SqlDataReader reader = _comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Desconectar();
            //MessageBox.Show(resultado.ToString());
            return resultado;
        }
        
        public int ValidarUsuarioExistente(String pUsuario)
        {
            int resultado = -1;
            conexion.Conectar();

            string consulta = "SELECT EMP_USUARIO FROM EMPLEADO WHERE EMP_USUARIO= '{0}' AND EMP_ESTADO = 'A'; ";
            SqlCommand _comando = new SqlCommand(
            String.Format(consulta, pUsuario), conexion.ObtenerMiConexion());
            SqlDataReader reader = _comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Desconectar();
            return resultado;
        }
        #endregion

        #region ///---Configuraciones---///
        public void Inserta_Configuracion(string PUERTO, int VELOCIDAD, string PARIDAD,int  BITS_DATOS, string BITS_PARADA)
        {
                conexion.Conectar();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "Inserta_Configuracion";
                cmdact.CommandType = System.Data.CommandType.StoredProcedure;
                cmdact.Connection = conexion.ObtenerMiConexion();

                cmdact.Parameters.AddWithValue("@PUERTO", PUERTO);
                cmdact.Parameters.AddWithValue("@VELOCIDAD", VELOCIDAD);
                cmdact.Parameters.AddWithValue("@PARIDAD", PARIDAD);
                cmdact.Parameters.AddWithValue("@BITS_DATOS", BITS_DATOS);
                cmdact.Parameters.AddWithValue("@BITS_PARADA", BITS_PARADA);
                cmdact.ExecuteNonQuery();
                conexion.Desconectar();
        }
        public void Actualiza_Configuracion(int ID_CONFIGURACION, string PUERTO, int VELOCIDAD, string PARIDAD, char ESTADO, int BITS_DATOS, string BITS_PARADA)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Actualiza_Configuracion";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            cmdact.Parameters.AddWithValue("@ID_CONFIGURACION", ID_CONFIGURACION);
            cmdact.Parameters.AddWithValue("@PUERTO", PUERTO);
            cmdact.Parameters.AddWithValue("@VELOCIDAD", VELOCIDAD);
            cmdact.Parameters.AddWithValue("@PARIDAD", PARIDAD);
            cmdact.Parameters.AddWithValue("@ESTADO", ESTADO);
            cmdact.Parameters.AddWithValue("@BITS_DATOS", BITS_DATOS);
            cmdact.Parameters.AddWithValue("@BITS_PARADA", BITS_PARADA);
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();
        }
        
        #endregion

        #region ///---Usuarios---///
        public void Inserta_Usuario(string ROL, string PASS, string USER)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Inserta_Usuario";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            cmdact.Parameters.AddWithValue("@ROL", ROL);
            cmdact.Parameters.AddWithValue("@PASS", PASS);
            cmdact.Parameters.AddWithValue("@USER", USER);
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();

        }
        public void Actualiza_Usuario(int USU_ID, string ROL, string PASS, string USER, char ESTADO)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Actualiza_Usuario";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            cmdact.Parameters.AddWithValue("@USU_ID", USU_ID);
            cmdact.Parameters.AddWithValue("@ROL", ROL);
            cmdact.Parameters.AddWithValue("@PASS", PASS);
            cmdact.Parameters.AddWithValue("@USER", USER);
            cmdact.Parameters.AddWithValue("@ESTADO", ESTADO);
          
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();
        }
       
        #endregion
        #region///---UNIDADES---///
        public void Inserta_Unidad(string PROPIETARIO, string CHOFER, int NUMERO_UNIDAD, string PLACA, 
            string COLOR, string AUTORIZACION, string MATRICULA, char ESTADO)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Inserta_Unidad";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            cmdact.Parameters.AddWithValue("@PROPIETARIO", PROPIETARIO);
            cmdact.Parameters.AddWithValue("@CHOFER", CHOFER);
            cmdact.Parameters.AddWithValue("@NUMERO_UNIDAD", NUMERO_UNIDAD);
            cmdact.Parameters.AddWithValue("@PLACA", PLACA);
            cmdact.Parameters.AddWithValue("@COLOR", COLOR);
            cmdact.Parameters.AddWithValue("@AUTORIZACION", AUTORIZACION);
            cmdact.Parameters.AddWithValue("@MATRICULA", MATRICULA);
            cmdact.Parameters.AddWithValue("@ESTADO", ESTADO);
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();
        }
        public void Actualiza_Unidad(int UNI_ID, string PROPIETARIO, string CHOFER, int NUMERO_UNIDAD, string PLACA,
            string COLOR, string AUTORIZACION, string MATRICULA, char ESTADO)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Actualiza_Unidad";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            cmdact.Parameters.AddWithValue("@UNI_ID", UNI_ID);
            cmdact.Parameters.AddWithValue("@PROPIETARIO", PROPIETARIO);
            cmdact.Parameters.AddWithValue("@CHOFER", CHOFER);
            cmdact.Parameters.AddWithValue("@NUMERO_UNIDAD", NUMERO_UNIDAD);
            cmdact.Parameters.AddWithValue("@PLACA", PLACA);
            cmdact.Parameters.AddWithValue("@COLOR", COLOR);
            cmdact.Parameters.AddWithValue("@AUTORIZACION", AUTORIZACION);
            cmdact.Parameters.AddWithValue("@MATRICULA", MATRICULA);
            cmdact.Parameters.AddWithValue("@ESTADO", ESTADO);

            cmdact.ExecuteNonQuery();
            conexion.Desconectar();
        }
        #endregion

        #region///---CLIENTES---///
        public void Inserta_Cliente(string TELEFONO, string CELULAR, string DIRECCION, string REFERENCIA,
            string NOMBRE)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Inserta_Cliente";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            cmdact.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            cmdact.Parameters.AddWithValue("@CELULAR", CELULAR);
            cmdact.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            cmdact.Parameters.AddWithValue("@REFERENCIA", REFERENCIA);
            cmdact.Parameters.AddWithValue("@NOMBRE", NOMBRE);
          
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();
        }
        public void Actualiza_Cliente(int CLI_ID, string TELEFONO, string CELULAR, string DIRECCION, string REFERENCIA,
            string NOMBRE, char ESTADO)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Actualiza_Cliente";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();
            cmdact.Parameters.AddWithValue("@CLI_ID", CLI_ID);
            cmdact.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            cmdact.Parameters.AddWithValue("@CELULAR", CELULAR);
            cmdact.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            cmdact.Parameters.AddWithValue("@REFERENCIA", REFERENCIA);
            cmdact.Parameters.AddWithValue("@NOMBRE", NOMBRE);
            cmdact.Parameters.AddWithValue("@ESTADO", ESTADO);
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();
        }
        #endregion
    }
}
