using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Examen2_Progra2.Clases
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Usuarios()
        {
            this.Nombre = string.Empty;
            this.Email = string.Empty;
            this.Telefono = string.Empty;
        }

        public Usuarios(int id, string nombre, string email, string telefono) // Constructor
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Email = email;
            this.Telefono = telefono;
        }

        public static int Agregar(string nombre)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConeccion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("INGRESARNOMBRE", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@Nombre", nombre));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;

        }

        public static int Borrar(string ID)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConeccion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_USU_ID", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID_USU", ID));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;



        }

        public static int Actualizar(string ID, string nom)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConeccion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID_USU", ID));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", nom));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;



        }

    }
}
