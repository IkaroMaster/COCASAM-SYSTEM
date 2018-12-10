using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace CapaDatos
{
    public class CDNotaPeso : Conexion
    {

        public int InsertarNotaPeso(CENotaPeso objNP)
        {
            int resultado;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_NotaPeso", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@IdNotaPeso", SqlDbType.Int).Value = objNP.IdNotaPeso;
                cmd.Parameters.Add("@IdProductor", SqlDbType.NVarChar, 5).Value = objNP.IdProductor;
                cmd.Parameters.Add("@IdTipoCafe", SqlDbType.Int).Value = objNP.IdTipoCafe;
                cmd.Parameters.Add("@IdLugar", SqlDbType.Int).Value = objNP.IdLugar;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = objNP.IdUsuario;
                cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = objNP.Fecha;
                cmd.Parameters.Add("@PesoBruto", SqlDbType.Float).Value = objNP.PesoBruto;
                cmd.Parameters.Add("@Tara", SqlDbType.Decimal).Value = objNP.Tara;
                cmd.Parameters.Add("@Descuento", SqlDbType.Decimal).Value = objNP.Descuento;
                cmd.Parameters.Add("@Humedad", SqlDbType.Float).Value = objNP.Humedad;
                cmd.Parameters.Add("@Observaciones", SqlDbType.VarChar, 100).Value = objNP.Observaciones;
                cmd.Parameters.Add("@PrecioUnitario", SqlDbType.Decimal).Value = objNP.PrecioUnitario;
                cmd.Parameters.Add("@Anulada", SqlDbType.Bit).Value = objNP.Anulada;

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

        public int ActualizarAnularNotaPeso(CENotaPeso objNP)
        {
            int resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Actualizar_AnularNotaPeso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdNotaPeso", SqlDbType.Int).Value = objNP.IdNotaPeso;
                cmd.Parameters.Add("@Anulada", SqlDbType.Bit).Value = objNP.Anulada;

                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de Anular la Nota Peso", ex);
            }
            finally
            {
                CerrarBD();
            }
            return resultado;
        }

        public int InsertarDetalleNotaPeso(CENotaPeso objNP)
        {
            int resultado;

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Guardar_DetalleNotaPeso", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@IdNotaPeso", SqlDbType.Int).Value = objNP.IdNotaPeso;
                cmd.Parameters.Add("@Peso", SqlDbType.Decimal).Value = objNP.Peso;
                cmd.Parameters.Add("@Saco", SqlDbType.Int).Value = objNP.Saco;
                

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
        public DataSet ListadoProductor()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                da = new SqlDataAdapter("Sp_Mostrar_Productor_Combobox", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "Productor");

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro al solicitar los datos ", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ListadoTipoCafe()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                da = new SqlDataAdapter("Sp_Mostrar_TipoCafe", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "TipoCafe");

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro al solicitar los datos ", ex);
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

        public DataSet ListadoNotaPeso()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_Todo_NotaPeso", cn);
                da.Fill(ds, "NotaPeso");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar los datos de la nota peso", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }

        public DataSet ObtenerMaximoNotaPeso()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_Mostrar_MaximoNotaPeso", cn);
                da.Fill(ds, "NotaPeso");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ultimo codigo de nota de peso", ex);
            }
            finally
            {
                CerrarBD();
                ds.Dispose();
            }
        }
    }
}
