using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDUsuario : Conexion
    {
        public int GuardarUsuario(CEUsuario objU)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Usuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = objU.Usuario;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 20).Value = objU.Usuario;
                cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar, 500).Value = objU.Contrasena;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = objU.Estado;
                cmd.Parameters.Add("@Administrador", SqlDbType.Bit).Value = objU.Administrador;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el usuario", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public int ActualizarUsuario(CEUsuario objU)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_Usuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = objU.IdUsuario;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 20).Value = objU.Usuario;
                cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar, 500).Value = objU.Contrasena;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = objU.Estado;
                cmd.Parameters.Add("@Administrador", SqlDbType.Bit).Value = objU.Administrador;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de actualizar el usuario", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }


        public DataSet ListadoUsuario()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Todo_Usuario", cn);
                da.Fill(ds, "Usuario");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public CEUsuario MostrarUnUsuario(int IdUsuario)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CEUsuario objUsuario = new CEUsuario();
            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_UnUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = IdUsuario;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objUsuario.IdUsuario = int.Parse(dr["IdUsuario"].ToString());
                    objUsuario.Usuario = dr["Usuario"].ToString();
                    objUsuario.Estado = dr.GetBoolean(3);
                    objUsuario.Administrador = dr.GetBoolean(4);
                }
                return objUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos", ex);
            }
            finally
            {
                CerrarBD();
            }
        }
    }
}
