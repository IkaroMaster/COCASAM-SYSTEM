﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CNLogin
    {
        CDLogin objL = new CDLogin();
        public int IniciarSesion(CELogin objLogin)
        {
            return objL.IniciarSesion(objLogin);
        }
    }
}
