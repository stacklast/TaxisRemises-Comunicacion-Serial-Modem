
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

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
        public DataTable ActualizarGridUnidad(string buscar)
        {
            string consulta;
            conexion.Conectar();
            consulta = "SELECT * from UNIDADES  WHERE PROPIETARIO like '%" + buscar + "%' OR CHOFER like '%" + buscar + "%' OR NUMERO_UNIDAD like '%" + buscar + "%'  AND ESTADO = 'A' ;";

            SqlCommand cmdact = conexion.ObtenerMiConexion().CreateCommand();
            cmdact.CommandType = CommandType.Text;
            cmdact.CommandText = consulta;
            cmdact.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdact);
            da.Fill(dt);
            conexion.Desconectar();
            return dt;
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
        public void Actualiza_Cliente(int ID_CLIENTE, string TELEFONO, string CELULAR, string DIRECCION, string REFERENCIA,
            string NOMBRE, char ESTADO)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Actualiza_Cliente";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();
            cmdact.Parameters.AddWithValue("@ID_CLIENTE", ID_CLIENTE);
            cmdact.Parameters.AddWithValue("@TELEFONO", TELEFONO);
            cmdact.Parameters.AddWithValue("@CELULAR", CELULAR);
            cmdact.Parameters.AddWithValue("@DIRECCION", DIRECCION);
            cmdact.Parameters.AddWithValue("@REFERENCIA", REFERENCIA);
            cmdact.Parameters.AddWithValue("@NOMBRE", NOMBRE);
            cmdact.Parameters.AddWithValue("@ESTADO", ESTADO);
            cmdact.ExecuteNonQuery();
            conexion.Desconectar();
        }

        public DataTable ActualizarGridCliente(string buscar)
        {
            string consulta;
            conexion.Conectar();
            consulta = "SELECT * from CLIENTES  WHERE TELEFONO like '%" + buscar + "%' OR CELULAR like '%" + buscar + "%' OR NOMBRE like '%" + buscar + "%'  AND ESTADO = 'A' ;";

            SqlCommand cmdact = conexion.ObtenerMiConexion().CreateCommand();
            cmdact.CommandType = CommandType.Text;
            cmdact.CommandText = consulta;
            cmdact.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdact);
            da.Fill(dt);
            conexion.Desconectar();
            return dt;
        }
        public DataTable ActualizarGridClienteTelefono(string telefono)
        {
            string consulta;
            conexion.Conectar();
            consulta = "SELECT * from CLIENTES  WHERE TELEFONO Like  '" + telefono + "' OR CELULAR like '" + telefono + "'  AND ESTADO = 'A' ;";

            SqlCommand cmdact = conexion.ObtenerMiConexion().CreateCommand();
            cmdact.CommandType = CommandType.Text;
            cmdact.CommandText = consulta;
            cmdact.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdact);
            da.Fill(dt);
            conexion.Desconectar();
            return dt;
        }
        #endregion

        #region //// APLICACION
        public DataTable ActualizarGridAsignaciones()
        {
            string consulta;
            conexion.Conectar();
            consulta = "Select ID_ASIGNACIONES AS NUM, TELEFONO ,/*CELULAR,*/ DIRECCION_ORIGEN,REFERENCIA, a.ID_UNIDAD , FECHA from CLIENTES c,  /*UNIDADES u,*/ ASIGNACIONES a where a.ID_CLIENTE = c.ID_CLIENTE  /*AND (a.ID_UNIDAD = u.ID_UNIDAD)*/  AND FECHA BETWEEN CONVERT(datetime, DATEADD(DAY, -1, GETDATE())) AND CONVERT(datetime,  GETDATE()) ORDER BY ID_ASIGNACIONES DESC";

            SqlCommand cmdact = conexion.ObtenerMiConexion().CreateCommand();
            cmdact.CommandType = CommandType.Text;
            cmdact.CommandText = consulta;
            cmdact.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdact);
            da.Fill(dt);
            conexion.Desconectar();
            return dt;
        }

        public DataTable ActualizarGridAsignacionesBuscar(string valor)
        {
            string consulta;
            conexion.Conectar();
            if (IsNumeric(valor))
            {
                consulta = "Select ID_ASIGNACIONES AS NUM, TELEFONO ,/*CELULAR,*/ DIRECCION,REFERENCIA, a.ID_UNIDAD AS NUM_UNIDAD , " +
                       " FECHA from CLIENTES c,  UNIDADES u, ASIGNACIONES a " +
                       " where a.ID_CLIENTE = c.ID_CLIENTE  AND a.ID_UNIDAD = u.ID_UNIDAD " +
                       " AND (TELEFONO = '" + valor + "' OR CELULAR = '" + valor + "' OR  u.ID_UNIDAD = " + valor + ")";
            }
            else
            {
                consulta = "Select ID_ASIGNACIONES AS NUM, TELEFONO ,/*CELULAR,*/ DIRECCION, REFERENCIA, a.ID_UNIDAD AS NUM_UNIDAD , " +
                       " FECHA from CLIENTES c,  UNIDADES u, ASIGNACIONES a " +
                       " where a.ID_CLIENTE = c.ID_CLIENTE  AND a.ID_UNIDAD = u.ID_UNIDAD " +
                       " AND (DIRECCION  LIKE '%" + valor + "%')";
            }
            

            SqlCommand cmdact = conexion.ObtenerMiConexion().CreateCommand();
            cmdact.CommandType = CommandType.Text;
            cmdact.CommandText = consulta;
            cmdact.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdact);
            da.Fill(dt);
            conexion.Desconectar();
            return dt;
        }
        public static bool IsNumeric(string dato)
        {
              bool isNumber;
              double isItNumeric;
              isNumber = Double.TryParse(Convert.ToString(dato), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out isItNumeric);
              return isNumber;
        }
        public DataTable ActualizarGridAsignacionesBuscarID(string id_asignaciones)
        {
            string consulta;
            conexion.Conectar();
            consulta = "Select   ID_ASIGNACIONES AS NUM, c.NOMBRE, c.TELEFONO , c.CELULAR, c.DIRECCION, c.REFERENCIA, c.ID_CLIENTE, a.ID_UNIDAD AS NUM_UNIDAD , a.DIRECCION_ORIGEN, " +
                       " FECHA from CLIENTES c,  /*UNIDADES u,*/ ASIGNACIONES a " +
                       " where a.ID_CLIENTE = c.ID_CLIENTE  /*AND a.ID_UNIDAD = u.ID_UNIDAD*/ " +
                       " AND ID_ASIGNACIONES = '" + id_asignaciones + "'" ;

            SqlCommand cmdact = conexion.ObtenerMiConexion().CreateCommand();
            cmdact.CommandType = CommandType.Text;
            cmdact.CommandText = consulta;
            cmdact.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdact);
            da.Fill(dt);
            conexion.Desconectar();
            return dt;
        }

        public void Inserta_Asignaciones(int? ID_UNIDAD, int ID_CLIENTE, DateTime FECHA, DateTime HORA, string DIRECCION_ORIGEN)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Inserta_Asignaciones";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            if (ID_UNIDAD == null)
            {
                cmdact.Parameters.Add("@ID_UNIDAD", SqlDbType.Int, 18).Value = DBNull.Value;
            }
            else
            {
                cmdact.Parameters.Add("@ID_UNIDAD", SqlDbType.Int, 18).Value = ID_UNIDAD;
            }
            //cmdact.Parameters.AddWithValue("@ID_UNIDAD", ID_UNIDAD);
            cmdact.Parameters.AddWithValue("@ID_CLIENTE", ID_CLIENTE);
            cmdact.Parameters.AddWithValue("@FECHA", FECHA);
            cmdact.Parameters.AddWithValue("@HORA", HORA);
            cmdact.Parameters.AddWithValue("@DIRECCION_ORIGEN", DIRECCION_ORIGEN);

            cmdact.ExecuteNonQuery();
            conexion.Desconectar();
        }

        public void Actualiza_Asignaciones(int ID_ASIGNACIONES, int ID_UNIDAD, string DIRECCION_ORIGEN)
        {
            conexion.Conectar();
            SqlCommand cmdact = new SqlCommand();
            cmdact.CommandText = "Actualiza_Asignaciones";
            cmdact.CommandType = System.Data.CommandType.StoredProcedure;
            cmdact.Connection = conexion.ObtenerMiConexion();

            cmdact.Parameters.AddWithValue("@ID_ASIGNACIONES", ID_ASIGNACIONES);
            cmdact.Parameters.AddWithValue("@ID_UNIDAD", ID_UNIDAD);
            cmdact.Parameters.AddWithValue("@DIRECCION_ORIGEN", DIRECCION_ORIGEN);

            cmdact.ExecuteNonQuery();
            conexion.Desconectar();
        }

        public int DevuelveNumUnidades()
        {
            conexion.Conectar();
            SqlCommand _comando = new SqlCommand("SELECT MAX(ID_UNIDAD) AS NUM from Unidades ;", conexion.ObtenerMiConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            _reader.Read();
            int valor = 0;
            if (_reader.HasRows)
            {
                if (_reader["NUM"] == DBNull.Value)
                {
                    valor = 0;
                }
                else
                {
                    valor = Convert.ToInt32(_reader["NUM"]);
                }
               
            }
            conexion.Desconectar();
            return valor;
        }
        #endregion
    }
}
