using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEUsuario
    {
        public int IdUsuario { get; set; }
        public String Usuario { get; set; }
        public String Contrasena { get; set; }
        public Boolean Estado { get; set; }
        public Boolean Administrador { get; set; }
    }
}
