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
    }
}
