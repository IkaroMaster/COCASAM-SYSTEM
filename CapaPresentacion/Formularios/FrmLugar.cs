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

namespace CapaPresentacion.Formularios
{
    public partial class FrmLugar : DevExpress.XtraEditors.XtraForm
    {
        public Boolean llamado = false;
        public FrmLugar()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtIdLugar.EditValue = "";
            txtLugar.EditValue = "";
        }

        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean actualizar, Boolean cancelar, Boolean group, Boolean grid)
        {
            pBxNuevo.Enabled = nuevo;
            pBxGuardar.Enabled = guardar;
            pBxActualizar.Enabled = actualizar;
            pBxCancelar.Enabled = cancelar;
            gcDatos.Enabled = group;
            gcDatosLugar.Enabled = grid;
        }

        private void pBxGuardar_Click(object sender, EventArgs e)
        {

            this.Validate();
            if (Validar())
            {
                CNLugar objInsertarLugar = new CNLugar();
                CELugar objLugar = new CELugar()
                {
                    Lugar = txtLugar.Text.Trim()
                };

                if (objInsertarLugar.GuardarLugar(objLugar) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    ListadoLugar();
                    XtraMessageBox.Show("Registro Almacenado Satisfactoriamente.", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al almacenar el Registro", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void ListadoLugar()
        {
            CNLugar objL = new CNLugar();
            gcDatosLugar.DataSource = objL.ListadoLugar().Tables["Lugar"];
        }

        private void pBxNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(false, true, false, true, true, false);
        }

        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(txtLugar.EditValue.ToString().Trim()))
            {
                txtLugar.ErrorText = "Ingrese el nombre del Lugar.";
                return false;
            }

            return true;
        }

        private void FrmLugar_Load(object sender, EventArgs e)
        {
            Limpiar();
            ListadoLugar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CNLugar objEliminarLugar = new CNLugar();
            int id = int.Parse(gvDatosLugar.GetRowCellValue(gvDatosLugar.FocusedRowHandle, colIdLugar).ToString());
            CELugar objLugar = new CELugar()
            {
                IdLugar = id
            };

            if (objEliminarLugar.ElimarLugar(objLugar) > 0)
            {
                ListadoLugar();
                XtraMessageBox.Show("Registro eliminado satisfactoriamente", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Error al eliminar el registro", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarLugar(int idLugar)
        {
            CNLugar objObtenerLugar = new CNLugar();
            CELugar objCargo = objObtenerLugar.ObtenerLugar(idLugar);

            txtIdLugar.EditValue = objCargo.IdLugar;
            txtLugar.EditValue = objCargo.Lugar.Trim();
        }
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvDatosLugar.GetRowCellValue(gvDatosLugar.FocusedRowHandle, colIdLugar).ToString());
            MostrarLugar(id);
            HabilitarControles(false, false, true, true, true, false);
        }

        private void pBxActualizar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNLugar objActualizarLugar = new CNLugar();
                CELugar objLugar = new CELugar()
                {
                    IdLugar = int.Parse(txtIdLugar.Text.Trim()),
                    Lugar = txtLugar.Text.Trim()
                };

                if (objActualizarLugar.ActualizarLugar(objLugar) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, true);
                    ListadoLugar();
                    XtraMessageBox.Show("Registro actualizado satisfactoriamente.", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al actualizar el registro", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
