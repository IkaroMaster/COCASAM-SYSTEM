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
    public class CNProductor
    {
        CDProductor objP = new CDProductor();


        public int NuevoProductor(CEProductor objProductor)
        {
            return objP.InsertarProductor(objProductor);
        }
        public int NuevoProductorXLugar(CEProductor objProductor)
        {
            return objP.InsertarProductorXLugar(objProductor);
        }
        public int ActualizarProductor(CEProductor objProductor)
        {
            return objP.ActualizarProductor(objProductor);
        }

        public int EliminarProductor(CEProductor objProductor)
        {
            return objP.EliminarProductor(objProductor);
        }

        public CEProductor ObtenerProductor(String IdProductor)
        {
            return objP.MostrarUnProductor(IdProductor);
        }


        public DataSet ListadoSexo()
        {
            return objP.ListadoSexo();
        }

        public DataSet ListadoProductor()
        {
            return objP.ListadoProductor();
        }

        public DataSet ListarLugarXProductor(String IdProductor)
        {
            return objP.ListarLugarXProductor(IdProductor);
        }

        public int EliminarLugarXProductor(CEProductor objProductor)
        {
            return objP.EliminarLugarXProductor(objProductor);
        }
    }
}
