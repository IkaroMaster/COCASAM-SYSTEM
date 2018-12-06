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
    public class CNLugar
    {
        CDLugar objL = new CDLugar();

        public int GuardarLugar(CELugar objLugar)
        {
            return objL.InsertarLugar(objLugar);
        }

        public int ElimarLugar(CELugar objLugar)
        {
            return objL.EliminarLugar(objLugar);
        }

        public DataSet ListadoLugar()
        {
            return objL.ListadoLugar();
        }

        public CELugar ObtenerLugar(int idLugar)
        {
            return objL.MostrarUnLugar(idLugar);
        }

        public int ActualizarLugar(CELugar objLugar)
        {
            return objL.ActualizarLugar(objLugar);
        }
    }
}
