using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CDProductor : Conexion
    {
        public int InsertarProductor(CEProductor objP)
        {
            int resultado;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_Productor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdProductor", SqlDbType.NVarChar, 5).Value = objP.IdProductor;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 20).Value = objP.Nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 20).Value = objP.Apellido;
                cmd.Parameters.Add("@IdSexo", SqlDbType.Int).Value = objP.IdSexo;
                cmd.Parameters.Add("@Socio", SqlDbType.Bit).Value = objP.Socio;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception exc)
            {
                throw new Exception("Error al tratar de almacenar el nuevo Productor", exc);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public int InsertarProductorXLugar(CEProductor objP)
        {
            int resultado;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_ProductorXLugar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdProductor", SqlDbType.NVarChar, 5).Value = objP.IdProductor;
                cmd.Parameters.Add("@IdLugar", SqlDbType.Int).Value = objP.IdLugar;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception exc)
            {
                throw new Exception("Error al tratar de almacenar el nuevo Lugar del Productor", exc);
            }
            finally
            {
                CerrarBD();
            }

            return resultado;
        }

        public int ActualizarProductor(CEProductor objP)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_Productor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdProductor", SqlDbType.NVarChar, 5).Value = objP.IdProductor;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 20).Value = objP.Nombre;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 20).Value = objP.Apellido;
                cmd.Parameters.Add("@IdSexo", SqlDbType.Int).Value = objP.IdSexo;
                cmd.Parameters.Add("@Socio", SqlDbType.Bit).Value = objP.Socio;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar Actualizar el Productor", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public int EliminarProductor(CEProductor objP)
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Eliminar_Productor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdProductor", SqlDbType.NVarChar, 5).Value = objP.IdProductor;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar Eliminar el Productor", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public int EliminarLugarXProductor(CEProductor objP)
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Eliminar_LugarXProductor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdProductor", SqlDbType.NVarChar, 5).Value = objP.IdProductor;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar Eliminar los lugares del productor", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public CEProductor MostrarUnProductor(String IdProductor)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            CEProductor objP = new CEProductor();
            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_Un_Productor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdProductor", SqlDbType.NVarChar, 5).Value = IdProductor;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objP.IdProductor = dr["IdProductor"].ToString();
                    objP.Nombre = dr["Nombre"].ToString();
                    objP.Apellido = dr["Apellido"].ToString();
                    objP.IdSexo = int.Parse(dr["IdSexo"].ToString());
                    objP.Socio = dr.GetBoolean(4);
                }
                return objP;
            }
            catch (Exception exc)
            {
                throw new Exception("Error al solicitar los datos", exc);
            }
            finally
            {
                CerrarBD();
            }
        }

        



        public DataSet ListadoSexo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Sexo", cn);
                da.Fill(ds, "Sexo");
                return ds;

            }
            catch (Exception exc)
            {

                throw new Exception("Error al solicitar los datos de la tabla sexo",exc);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoProductor()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Todo_Productor", cn);
                da.Fill(ds, "Productor");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar los datos de los productores", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListarLugarXProductor(String IdProductor)
        {

            
            
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd;
            try
            {
                ConectarBD();
                cmd = new SqlCommand("Sp_Mostrar_LugarXProductor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdProductor", SqlDbType.NVarChar, 5).Value = IdProductor;
                da.SelectCommand = cmd;
                da.Fill(ds, "Productor");
                return ds;



            }
            catch (Exception exc)
            {
                throw new Exception("Error al solicitar los datos", exc);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }





        }
    }
}
