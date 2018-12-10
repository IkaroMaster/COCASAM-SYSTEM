using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CapaPresentacion.Reportes
{
    public partial class rptNotaPeso : DevExpress.XtraReports.UI.XtraReport
    {
        public rptNotaPeso(int idNota)
        {
           // DataSetReportes.sp_mo ta = 
            InitializeComponent();
            //DataSetReportes.Sp_Mostrar_Todo_NotaPesoDataTable NotaPeso = new DataSetReportes.Sp_Mostrar_Todo_NotaPesoDataTable();

            //sp_Mostrar_Todo_NotaPesoTableAdapter.FillById(NotaPeso, idNota);

        }



    }
}
