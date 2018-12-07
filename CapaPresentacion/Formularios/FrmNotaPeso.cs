using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using CapaNegocio;
using CapaEntidad;
using CapaPresentacion.Formularios;



namespace CapaPresentacion.Formularios
{
    public partial class FrmNotaPeso : Form
    {
        CNNotaPeso objNP = new CNNotaPeso();
        public FrmNotaPeso()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmNotaPeso_Load(object sender, EventArgs e)
        {
            LlenarCombobox();
        }

        private void LlenarCombobox()
        {
            slueProductor.Properties.DataSource = objNP.ListadoProductor().Tables["Productor"];
            slueCalidadCafe.Properties.DataSource = objNP.ListadoTipoCafe().Tables["TipoCafe"];
        }


        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
