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
    public class CDLogin : Conexion
    {
        public int IniciarSesion(CELogin objLogin)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            try
            {
                cmd = new SqlCommand("Sp_Login", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 20).Value = objLogin.Usuario;
                cmd.Parameters.Add("@Contrasena", SqlDbType.VarChar, 50).Value = objLogin.Contrasena;
                ConectarBD();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return int.Parse(dr["IdUsuario"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception("Error al iniciar sesion", ex);
            }
            finally
            {
                CerrarBD();
            }
        }
    }
}
