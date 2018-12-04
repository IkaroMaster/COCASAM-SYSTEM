using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CapaDatos
{
    class Conexion
    {
        public SqlConnection cn;

        public Conexion()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        }

        public void ConectarBD()
        {
            try
            {
                if(cn.State ==ConnectionState.Broken || cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

            }
            catch(Exception exc)
            {
                throw new Exception("Error al tratar de abrir la conexion con la Base de Datos COCASAM", exc);
            }
        }

        public void CerrarBD()
        {
            try
            {
                if(cn.State == ConnectionState.Open)
                {
                    cn.Close();

                }
            }
            catch (Exception exc)
            {
                throw new Exception("Error al tratar de cerrar la conexion con la base de datos COCASAM", exc);
            }
        }
    }
}
