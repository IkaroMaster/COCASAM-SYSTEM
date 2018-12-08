using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CENotaPeso
    { 
        public int IdNotaPeso { get; set; }
        public string IdProductor { get; set; }
        public int IdTipoCafe { get; set; }
        public int IdLugar { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public float PesoBruto { get; set; }
        public Decimal Tara { get; set; }
        public Decimal Descuento { get; set; }
        public float Humedad { get; set; }
        public string Observaciones { get; set; }
        public Decimal PrecioUnitario { get; set; }
        public Boolean Anulada { get; set; }

        public Decimal Peso { get; set; }
        public int Saco { get; set; }
        

        //public String IdProductor { get; set; }
        //public String NombreCompleto { get; set; }

    }
}
