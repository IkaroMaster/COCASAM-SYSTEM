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
    public class CNUsuario
    {
        CDUsuario objU = new CDUsuario();

        public int GuardarUsuario(CEUsuario objUsuario)
        {
            return objU.GuardarUsuario(objUsuario);
        }
        public int ActualizarUsuario(CEUsuario objUsuario)
        {
            return objU.ActualizarUsuario(objUsuario);
        }

        public DataSet ListadoUsuario()
        {
            return objU.ListadoUsuario();
        }

        public CEUsuario ObtenerUsuario(int IdUsuario)
        {
            return objU.MostrarUnUsuario(IdUsuario);
        }
    }
}
