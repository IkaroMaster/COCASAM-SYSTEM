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

        public DataSet ListadoProductor()
        {
            return objNP.ListadoProductor();
        }

        public DataSet ListadoTipoCafe()
        {
            return objNP.ListadoTipoCafe();
        }

    }
}
