
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
            SqlCommand _comando = new SqlCommand("SELECT * from USUARIOS  WHERE [USER] = '" + pUsuario + "' ;", conexion.ObtenerMiConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            _reader.Read();
            String valor = Convert.ToString(_reader["ROL"]);
            conexion.Desconectar();
            return valor;
        }

        public String DevuelveNombrePrivilegio(String idPrivilegio)
        {
            conexion.Conectar();
            SqlCommand _comando = new SqlCommand("SELECT * from PERFIL WHERE PER_ID = '" + idPrivilegio + "' AND PER_ESTADO = 'A';", conexion.ObtenerMiConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            _reader.Read();
            String valor = Convert.ToString(_reader["PER_NOMBRE"]);
            conexion.Desconectar();
            return valor;
        }
        public int Autentificar(String pUsuario, String pContraseña)
        {
            int resultado = -1;

            BD conexion = new BD();
            conexion.Conectar();

            string consulta = "SELECT * FROM USUARIOS WHERE [USER]= '{0}' AND PASS = '{1}'";
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
        
        public DataTable ActualizarGridEmpleado(string buscar)
        {
            string consulta;
            conexion.Conectar();

            consulta = "Select * from EMPLEADO where EMP_CEDULA like '" + buscar + "%' or EMP_NOMBRE like '" + buscar + "%' AND EMP_ESTADO = 'A';";

            SqlCommand cmdact = conexion.ObtenerMiConexion().CreateCommand();
            cmdact.CommandType = System.Data.CommandType.Text;
            cmdact.CommandText = consulta;
            cmdact.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdact);
            da.Fill(dt);
            //gvEmpleado.Datasource = dt;
            conexion.Desconectar();
            return dt;


        }
        public int ValidarCedulaEmpleadoExistente(String EMP_CEDULA)
        {
            try
            {
                int resultado = -1;

                BD conexion = new BD();
                conexion.Conectar();

                string consulta = "SELECT EMP_CEDULA FROM EMPLEADO WHERE EMP_CEDULA= '{0}' AND EMP_ESTADO = 'A';";
                SqlCommand _comando = new SqlCommand(
                String.Format(consulta, EMP_CEDULA), conexion.ObtenerMiConexion());
                SqlDataReader reader = _comando.ExecuteReader();

                while (reader.Read())
                {
                    resultado = 50;
                }
                conexion.Desconectar();
                return resultado;
            }
            catch (Exception)
            {
                int a = 0;
                return a;
            }

        }
        public int ValidarUsuarioEmpleadoExistente(String EMP_USUARIO)
        {
            try
            {
                int resultado = -1;

                BD conexion = new BD();
                conexion.Conectar();

                string consulta = "SELECT EMP_USUARIO FROM EMPLEADO WHERE EMP_USUARIO= '{0}' AND EMP_ESTADO = 'A';";
                SqlCommand _comando = new SqlCommand(
                String.Format(consulta, EMP_USUARIO), conexion.ObtenerMiConexion());
                SqlDataReader reader = _comando.ExecuteReader();

                while (reader.Read())
                {
                    resultado = 50;
                }
                conexion.Desconectar();
                return resultado;
            }
            catch (Exception)
            {
                int a = 0;
                return a;
            }

        }
        #endregion

        #region ///---PACIENTE---///
        public void Inserta_Paciente(string PAC_APELLIDO, string PAC_NOMBRE, DateTime PAC_FECHANA, string PAC_CEDULA, string PAC_GENERO,
                                     string PAC_EMAIL, string PAC_TELEFONO, string PAC_DIRECCION, string PAC_ESTADO)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Inserta_Paciente";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            cmdact.Parameters.AddWithValue("@PAC_APELLIDO", PAC_APELLIDO);
            cmdact.Parameters.AddWithValue("@PAC_NOMBRE", PAC_NOMBRE);
            cmdact.Parameters.AddWithValue("@PAC_FECHANA", PAC_FECHANA);
            cmdact.Parameters.AddWithValue("@PAC_CEDULA", PAC_CEDULA);
            cmdact.Parameters.AddWithValue("@PAC_GENERO", PAC_GENERO);
            cmdact.Parameters.AddWithValue("@PAC_EMAIL", PAC_EMAIL);
            cmdact.Parameters.AddWithValue("@PAC_TELEFONO", PAC_TELEFONO);
            cmdact.Parameters.AddWithValue("@PAC_DIRECCION", PAC_DIRECCION);
            cmdact.Parameters.AddWithValue("@PAC_ESTADO", PAC_ESTADO);
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();

        }
        public void Actualiza_Paciente(int PAC_ID, string PAC_APELLIDO, string PAC_NOMBRE, DateTime PAC_FECHANA, string PAC_CEDULA, string PAC_GENERO,
                                     string PAC_EMAIL, string PAC_TELEFONO, string PAC_DIRECCION, string PAC_ESTADO)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Actualiza_Paciente";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            cmdact.Parameters.AddWithValue("@PAC_ID", PAC_ID);
            cmdact.Parameters.AddWithValue("@PAC_APELLIDO", PAC_APELLIDO);
            cmdact.Parameters.AddWithValue("@PAC_NOMBRE", PAC_NOMBRE);
            cmdact.Parameters.AddWithValue("@PAC_FECHANA", PAC_FECHANA);
            cmdact.Parameters.AddWithValue("@PAC_CEDULA", PAC_CEDULA);
            cmdact.Parameters.AddWithValue("@PAC_GENERO", PAC_GENERO);
            cmdact.Parameters.AddWithValue("@PAC_EMAIL", PAC_EMAIL);
            cmdact.Parameters.AddWithValue("@PAC_TELEFONO", PAC_TELEFONO);
            cmdact.Parameters.AddWithValue("@PAC_DIRECCION", PAC_DIRECCION);
            cmdact.Parameters.AddWithValue("@PAC_ESTADO", PAC_ESTADO);
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();
        }
        public DataTable ActualizarGridPaciente(string buscar)
        {
            string consulta;
            conexion.Conectar();

            consulta = "Select * from PACIENTE where PAC_CEDULA like '" + buscar + "%' or PAC_NOMBRE like '" + buscar + "%' AND PAC_ESTADO = 'A';";

            SqlCommand cmdact = conexion.ObtenerMiConexion().CreateCommand();
            cmdact.CommandType = System.Data.CommandType.Text;
            cmdact.CommandText = consulta;
            cmdact.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdact);
            da.Fill(dt);
            //gvPaciente.Datasource = dt;
            conexion.Desconectar();
            return dt;
        }
        public int ValidarCedulaPacienteExistente(String PAC_CEDULA)
        {
            try
            {
                int resultado = -1;

                BD conexion = new BD();
                conexion.Conectar();

                string consulta = "SELECT PAC_CEDULA FROM PACIENTE WHERE PAC_CEDULA= '{0}' AND PAC_ESTADO = 'A';";
                SqlCommand _comando = new SqlCommand(
                String.Format(consulta, PAC_CEDULA), conexion.ObtenerMiConexion());
                SqlDataReader reader = _comando.ExecuteReader();

                while (reader.Read())
                {
                    resultado = 50;
                }
                conexion.Desconectar();
                return resultado;
            }
            catch (Exception)
            {
                int a = 0;
                return a;
            }

        }
        #endregion
        #region///---CITAS---///
        public void Inserta_Cita(int PAC_ID, int EMP_ID, DateTime CITA_INICIO, DateTime CITA_FINALIACION, string CITA_ESTADO)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Inserta_Cita";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            cmdact.Parameters.AddWithValue("@PAC_ID", PAC_ID);
            cmdact.Parameters.AddWithValue("@EMP_ID", EMP_ID);
            cmdact.Parameters.AddWithValue("@CITA_INICIO", CITA_INICIO);
            cmdact.Parameters.AddWithValue("@CITA_FINALIACION", CITA_FINALIACION);
            cmdact.Parameters.AddWithValue("@CITA_ESTADO", CITA_ESTADO);
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();

        }
        public void Actualiza_Cita(int CITA_ID, int PAC_ID, int EMP_ID, DateTime CITA_INICIO, DateTime CITA_FINALIACION, string CITA_ESTADO)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Actualiza_Cita";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();
            cmdact.Parameters.AddWithValue("@CITA_ID", CITA_ID);
            cmdact.Parameters.AddWithValue("@PAC_ID", PAC_ID);
            cmdact.Parameters.AddWithValue("@EMP_ID", EMP_ID);
            cmdact.Parameters.AddWithValue("@CITA_INICIO", CITA_INICIO);
            cmdact.Parameters.AddWithValue("@CITA_FINALIACION", CITA_FINALIACION);
            cmdact.Parameters.AddWithValue("@CITA_ESTADO", CITA_ESTADO);
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();

        }
        public void Elimina_Cita(int CITA_ID)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Elimina_Cita";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();
            cmdact.Parameters.AddWithValue("@CITA_ID", CITA_ID);

            cmdact.ExecuteNonQuery();
            conexion.Desconectar();

        }


        #endregion
    }
}
