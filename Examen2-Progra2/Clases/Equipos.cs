using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Examen2_Progra2.Clases
{
    public class Equipos
    {
        public int Id { get; set; }
        public string TipoEquipo { get; set; }
        public string Modelo { get; set; }
        public int UsuarioID { get; set; }

        public Equipos()
        {
            TipoEquipo = string.Empty;
            Modelo = string.Empty;
        }

        public Equipos(int Id, string TipoEquipo, string Modelo, int UsuarioID)
        {
            this.Id = Id;
            this.TipoEquipo = TipoEquipo;
            this.Modelo = Modelo;
            this.UsuarioID = UsuarioID;
        }

        public static int Agregar(string usuario, string equipo, string modelo)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConeccion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("INGRESARID", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@EQUIPO", equipo));
                    cmd.Parameters.Add(new SqlParameter("@MODELO", modelo));
                    cmd.Parameters.Add(new SqlParameter("@USUARIO", usuario));


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
                    SqlCommand cmd = new SqlCommand("BORRAR_EQUIPOS", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@@ID_EQUIP", ID));


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

        public static int Actualizar(string ID, string tipEquip, string Modelo)
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
                    cmd.Parameters.Add(new SqlParameter("@ID_EQUIP", ID));
                    cmd.Parameters.Add(new SqlParameter("@TIPO_EQUIP", tipEquip));
                    cmd.Parameters.Add(new SqlParameter("@MODELO", Modelo));


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