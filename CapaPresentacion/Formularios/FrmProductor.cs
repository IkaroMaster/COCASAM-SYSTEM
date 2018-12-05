﻿using System;
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
    public partial class FrmProductor : DevExpress.XtraEditors.XtraForm
    {
        public FrmProductor()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            sexoTableAdapter1.Fill(cafeDBDataSet1.Sexo);
        }

        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(txtIdProductor.EditValue.ToString().Trim()))
            {
                txtIdProductor.ErrorText = "Ingrese el codigo del productor";
                return false;
            }
            if (String.IsNullOrEmpty(txtNombreProductor.EditValue.ToString().Trim()))
            {
                txtNombreProductor.ErrorText = "Ingrese el nombre del productor";
                return false;
            }
            if (String.IsNullOrEmpty(txtApellidoProductor.EditValue.ToString().Trim()))
            {
                txtApellidoProductor.ErrorText = "Ingrese el Apellido del productor";
                return false;
            }
            if (lueSexo.EditValue == null)
            {
                lueSexo.ErrorText = "Seleccione el sexo del productor";
                return false;
            }

            return true;
            
        }

        private void Limpiar()
        {
            txtIdProductor.EditValue = "";
            txtNombreProductor.EditValue = "";
            txtApellidoProductor.EditValue = "";
            lueSexo.EditValue = null;

        }

        private void LlenarComboSexo()
        {
            CNProductor objP = new CNProductor();
            lueSexo.Properties.DataSource = objP.ListadoSexo().Tables["Sexo"];
        }

        private void ListadoProductor()
        {
            CNProductor objP = new CNProductor();
            gcDatosProductor.DataSource = objP.ListadoProductor().Tables["Productor"];
        }

        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean actualizar, Boolean cancelar,Boolean regresar)
        {
            pbxNuevo.Enabled = nuevo;
            pbxGuardar.Enabled = guardar;
            pbxActualizar.Enabled = actualizar;
            pbxCancelar.Enabled = cancelar;
            pbxRegresar.Enabled = regresar;
            
        }

        private void pbxGuardar_Click(object sender, EventArgs e)
        {
            this.Validar();
            if (Validar())
            {
                CNProductor objGuardarProductor = new CNProductor();
                CEProductor objProductor = new CEProductor()
                {
                    IdProductor = txtIdProductor.Text.Trim(),
                    Nombre = txtNombreProductor.Text.Trim(),
                    Apellido = txtApellidoProductor.Text.Trim(),
                    IdSexo = int.Parse(lueSexo.EditValue.ToString()),
                    Socio = chkSocio.Checked
                };

                if (objGuardarProductor.NuevoProductor(objProductor) > 0 )
                {
                    Limpiar();
                    HabilitarControles(true, false, true, false, true);
                    XtraMessageBox.Show("Registro almacenado satisfatoriamente", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void FrmProductor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cafeDBDataSet.Sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.cafeDBDataSet.Sexo);
            // TODO: esta línea de código carga datos en la tabla 'cafeDBDataSet11.Sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter2.Fill(this.cafeDBDataSet11.Sexo);
            // TODO: esta línea de código carga datos en la tabla 'cafeDBDataSet.Sexo' Puede moverla o quitarla según sea necesario.
            this.sexoTableAdapter.Fill(this.cafeDBDataSet.Sexo);
            Limpiar();
            LlenarComboSexo();
            ListadoProductor();
        }

        private void eliminarStripMenuItem1_Click(object sender, EventArgs e)
        {
            CNProductor objEliminarProductor = new CNProductor();
            String idProductor = gvDatosProductor.GetRowCellValue(gvDatosProductor.FocusedRowHandle, colIdProductor).ToString();
            CEProductor objProductor = new CEProductor()
            {
                IdProductor = idProductor
            };

            if (objEliminarProductor.EliminarProductor(objProductor) > 0)
            {
                ListadoProductor();
                XtraMessageBox.Show("Registro Eliminado Satisfactoriamente", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Error al Eliminar el Registro", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxActualizar_Click(object sender, EventArgs e)
        {
           
            this.Validate();
            if (Validar())
            {
                CNProductor objActualizarProductor = new CNProductor();
                CEProductor objProductor = new CEProductor()
                {
                    IdProductor = txtIdProductor.Text.Trim(),
                    Nombre = txtNombreProductor.Text.Trim(),
                    Apellido = txtApellidoProductor.Text.Trim(),
                    IdSexo = int.Parse(lueSexo.EditValue.ToString()),
                    Socio = chkSocio.Checked
                };

                if (objActualizarProductor.ActualizarProductor(objProductor) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false);
                    ListadoProductor();
                    XtraMessageBox.Show("Registro Actualizado Satisfactoriamente", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al Actualizar el Registro", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void editarStripMenuItem1_Click(object sender, EventArgs e)
        {
            String id = gvDatosProductor.GetRowCellValue(gvDatosProductor.FocusedRowHandle, colIdProductor).ToString();

            MostrarProductor(id);
            HabilitarControles(false, false, true, true, true);
        }

        public void MostrarProductor(String IdProductor)
        {
            CNProductor objObtenerProductor = new CNProductor();
            CEProductor objP = objObtenerProductor.ObtenerProductor(IdProductor.Trim());

            txtIdProductor.EditValue = objP.IdProductor.Trim();
            txtNombreProductor.EditValue = objP.Nombre.Trim();
            txtApellidoProductor.EditValue = objP.Apellido.Trim();
            lueSexo.EditValue = objP.IdSexo;
            chkSocio.Checked = objP.Socio;
        }
    }
}