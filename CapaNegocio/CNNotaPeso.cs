using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CNNotaPeso
    {
        CDNotaPeso objNP = new CDNotaPeso();

        public int NuevaNotaPeso(CENotaPeso objNotaPeso)
        {
            return objNP.InsertarNotaPeso(objNotaPeso);
        }

        public int NuevoDetalleNotaPeso(CENotaPeso objNotaPeso)
        {
            return objNP.InsertarDetalleNotaPeso(objNotaPeso);
        }

        public int ActualizarNotaPeso(CENotaPeso objNotaPeso)
        {
            return objNP.ActualizarAnularNotaPeso(objNotaPeso);
        }

        public DataSet ListadoProductor()
        {
            return objNP.ListadoProductor();
        }

        public DataSet ListadoTipoCafe()
        {
            return objNP.ListadoTipoCafe();
        }

        public DataSet ListarLugarXProductor(String IdProductor)
        {
            return objNP.ListarLugarXProductor(IdProductor);
        }

        public DataSet ListadoNotaPeso()
        {
            return objNP.ListadoNotaPeso();
        }

    }
}
