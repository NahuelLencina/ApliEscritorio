using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;

using MySql.Data.MySqlClient;

namespace ApliEscritorio
{

        public class AccesoDatos
        {
            private MySqlConnection conexion;
            private MySqlCommand comando;
            private MySqlDataReader lector;

            // Properti
            public MySqlDataReader Lector
            {
                get { return lector; }
            }

            // Constructor 
            public AccesoDatos()
            {
                conexion = new MySqlConnection (@"server=bz3ob4jnk0kzhcindczw-mysql.services.clever-cloud.com;user id=uhf3oeubzruyf9n0;password=aGhlzmPpOdGB08f0mc15;database=bz3ob4jnk0kzhcindczw;persistsecurityinfo=True");
                comando = new MySqlCommand();
            }
            public void setearConsulta(string consulta)
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
            }

            public void ejecutarLectura()
            {
                comando.Connection = conexion;
                try
                {
                    conexion.Open();
                    lector = comando.ExecuteReader();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            public void setearParametro(string nombre, string valor)
            {
                comando.Parameters.AddWithValue(nombre, valor);
            }

            public void ejecutarAccion()
            {
                comando.Connection = conexion;

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            public void setearParametro(string nombre, object valor)
            {
                comando.Parameters.AddWithValue(nombre, valor);
            }

            public void clear()
            {
                  comando.Parameters.Clear();
            }
           
            public void cerrarConexion()
            {
               if (lector != null)
                   lector.Close();
                 conexion.Close();
            }
        }
           
}

