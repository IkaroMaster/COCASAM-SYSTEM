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
            InitializeComponent();

            //sp_Mostrar_Todo_NotaPesoTableAdapter.FillById(DataSetReportes.Sp_Mostrar_Todo_NotaPesoDataTable  , idNota);
        }



    }
}
