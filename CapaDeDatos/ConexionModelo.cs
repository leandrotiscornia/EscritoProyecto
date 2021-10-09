using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class ConexionModelo
    {
        public string ip { get; set; }
        public string puerto { get; set; }
        public string nombreDB { get; set; }
        public string usuarioDB { get; set; }
        public string passwordDB { get; set; }
        public MySqlConnection conexion { get; set; }
        public MySqlCommand comando { get; set; }
        public MySqlDataReader lector { get; set; }

        public ConexionModelo()
        {
            /*Se que en este caso el "this" se puede evitar, pero tengo 
            una paranoia por algo que pasó una vez, siempre lo pongo igual*/
            this.conexion = new MySqlConnection();
            this.comando = new MySqlCommand();

            this.ip = ConfiguracionDB.Default.ip;
            this.puerto = ConfiguracionDB.Default.puertoDB;
            this.nombreDB = ConfiguracionDB.Default.nombreDB;
            this.usuarioDB = ConfiguracionDB.Default.usuarioDB;
            this.passwordDB = ConfiguracionDB.Default.passwordDB;
            abrirConexion();
        }
        public ConexionModelo(string usuario, string contraseña) 
        {
            ConfiguracionDB.Default.usuarioDB = usuario;
            ConfiguracionDB.Default.passwordDB = contraseña;

            this.conexion = new MySqlConnection();
            this.comando = new MySqlCommand();

            this.ip = ConfiguracionDB.Default.ip;
            this.puerto = ConfiguracionDB.Default.puertoDB;
            this.nombreDB = ConfiguracionDB.Default.nombreDB;
            this.usuarioDB = ConfiguracionDB.Default.usuarioDB;
            this.passwordDB = ConfiguracionDB.Default.passwordDB;
            abrirConexion();

        }
        protected void abrirConexion()
        {
            comando.Connection = conexion;
            conexion.ConnectionString =
                "server=" + ip + "; " +
                "port=" + puerto + "; " +
                "database=" + nombreDB + "; " +
                "userid=" + usuarioDB + "; " +
                "password=" + passwordDB + ";";
            try
            {
                conexion.Open();
                Console.WriteLine("Conexión abierta");
            }
            catch (MySqlException ex)
            {
                manejarExcepcion(ex);
            }
        }

        protected void ejecutarComando()
        {
            try
            {
                if (lector != null) lector.Close();
                comando.Prepare();
                comando.ExecuteNonQuery();
                Console.WriteLine(comando.CommandText);
            }
            catch (MySqlException ex)
            {
                manejarExcepcion(ex);
            }
            finally
            {
                comando.Parameters.Clear();
                Console.WriteLine(comando.CommandText);
            }
        }

        protected void leerComando()
        {
            try
            {
                comando.Prepare();
                if (lector!= null) lector.Close();
                lector= comando.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                manejarExcepcion(ex);
            }
            finally
            {
                comando.Parameters.Clear();
                Console.WriteLine(comando.CommandText);
            }
        }
        protected DataTable leerTabla()
        {
            DataTable result = new DataTable();
            try
            {
                if (lector.HasRows) result.Load(lector);
            }
            catch (MySqlException ex)
            {
                manejarExcepcion(ex);
            }
            finally
            {
                comando.Parameters.Clear();
            }
            return result;
        }
        protected string leerTexto(int index)
        {
            string result = "";
            try
            {
                lector.Read();
                if (lector.HasRows && !lector.IsDBNull(index)) result = lector.GetString(index);
                else return null;
            }
            catch (MySqlException ex)
            {
                manejarExcepcion(ex);
            }
            return result;
        }

        protected int leerEntero(int index)
        {
            int result = -1;
            try
            {
                lector.Read();
                if (lector.HasRows && !lector.IsDBNull(index)) result = lector.GetInt32(index);
                else throw new Exception("Null Number");
            }
            catch (MySqlException ex)
            {
                manejarExcepcion(ex);
            }
            return result;
        }

        protected DateTime leerFecha(int index)
        {
            DateTime result = DateTime.MinValue;
            try
            {
                lector.Read();
                if (lector.HasRows && !lector.IsDBNull(index)) result = lector.GetDateTime(index);
                else return result;
            }
            catch (MySqlException ex)
            {
                manejarExcepcion(ex);
            }
            return result;
        }

        protected void manejarExcepcion(MySqlException ex)
        {
            Console.WriteLine(ex.Message);
            int exceptionNumber;
            if (ex.InnerException != null && ex.InnerException is MySqlException)
                exceptionNumber = ((MySqlException)ex.InnerException).Number;
            else
                exceptionNumber = ex.Number;
            int indexFrom;
            int indexTo;
            switch (exceptionNumber)
            {
                case 0:
                    throw new Exception("Cannot Connect To Server", ex);
                case 1042:
                    throw new Exception("Access To Server Dennied", ex);
                case 1045:
                    throw new Exception("Incorrect Database Credentials", ex);
                case 1049:
                    throw new Exception("Unknown Database", ex);
                case 1054:
                    indexFrom = ex.Message.IndexOf("'");
                    indexTo = ex.Message.IndexOf("'", indexFrom + 1) - indexFrom + 1;
                    throw new Exception("Column " + ex.Message.Substring(indexFrom, indexTo) + " Does Not Exist", ex);
                case 1064:
                    indexFrom = ex.Message.IndexOf("'");
                    indexTo = ex.Message.IndexOf("'", indexFrom + 1) - indexFrom + 1;
                    throw new Exception("SQL Syntax Error At: " + ex.Message.Substring(indexFrom, indexTo), ex);
                case 1146:
                    indexFrom = ex.Message.IndexOf("'");
                    indexTo = ex.Message.IndexOf("'", indexFrom + 1) - indexFrom + 1;
                    throw new Exception("Table " + ex.Message.Substring(indexFrom, indexTo) + " Does Not Exist", ex);
                case 1406:
                    indexFrom = ex.Message.IndexOf("'");
                    indexTo = ex.Message.LastIndexOf("'") - indexFrom;
                    throw new Exception("Field Value Too Long For Table " + ex.Message.Substring(indexFrom, indexTo), ex);
                case 1452:
                    throw new Exception("Foregin Key Constraint Error", ex);
                default:
                    throw new Exception("UNHADLED INTERNAL EXCEPTION: " + ex.Message, ex);
            }
        }
    }
}
