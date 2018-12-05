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
using System.Security.Cryptography;

namespace CapaPresentacion.Formularios
{
    public partial class FrmUsuario : DevExpress.XtraEditors.XtraForm
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtIdUsuario.EditValue = "";
            txtUsuario.EditValue = "";
            txtContrasena.EditValue = "";
            
        }

        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(txtUsuario.EditValue.ToString().Trim()))
            {
                txtUsuario.ErrorText = "Ingrese el usuario";
                return false;
            }
            if (String.IsNullOrEmpty(txtContrasena.EditValue.ToString().Trim()))
            {
                txtContrasena.ErrorText = "Ingrese la contraseña";
                return false;
            }
            
            return true;
        }
        public string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        private void HabilitarControles(Boolean nuevo, Boolean guardar, Boolean actualizar, Boolean cancelar, Boolean regresar,Boolean group)
        {
            pBxNuevo.Enabled = nuevo;
            pBxGuardar.Enabled = guardar;
            pBxActualizar.Enabled = actualizar;
            pBxCancelar.Enabled = cancelar;
            pBxRegresar.Enabled = regresar;
            gcDatos.Enabled = group;

        }

        private void pBxGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNUsuario objInsertarUsuario = new CNUsuario();
                CEUsuario objUsuario = new CEUsuario()
                {

                    Usuario = txtUsuario.Text.Trim(),
                    Contrasena = Hash(txtContrasena.Text.Trim()),
                    Estado = chkEstado.Checked,
                    Administrador = chkAdministrador.Checked
                };

                if (objInsertarUsuario.GuardarUsuario(objUsuario) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, true,false);
                    ListadoUsuario();
                    XtraMessageBox.Show("Registro almacenado satisfactoriamente", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al almacenar el registro", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListadoUsuario()
        {
            CNUsuario objU = new CNUsuario();
            gcDatosUsuario.DataSource = objU.ListadoUsuario().Tables["Usuario"];
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Limpiar();
            ListadoUsuario();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarControles(false, true, false, true, false,true);
        }


        public void MostrarUsuario(int IdUsuario)
        {
            CNUsuario objObtenerUsuario = new CNUsuario();
            CEUsuario objUsuario = objObtenerUsuario.ObtenerUsuario(IdUsuario);
            txtIdUsuario.EditValue = objUsuario.IdUsuario;
            txtUsuario.EditValue = objUsuario.Usuario.Trim();
            chkEstado.Checked = objUsuario.Estado;
            chkAdministrador.Checked = objUsuario.Administrador;
        }
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gvDatosUsuario.GetRowCellValue(gvDatosUsuario.FocusedRowHandle, colIdUsuario).ToString());
            MostrarUsuario(id);
            HabilitarControles(false, false, true, true, true, true);
        }

        private void pBxActualizar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNUsuario objActualizarUsuario = new CNUsuario();
                CEUsuario objUsuario = new CEUsuario()
                {
                    IdUsuario = int.Parse(txtIdUsuario.Text),
                    Usuario = txtUsuario.Text.Trim(),
                    Contrasena = Hash(txtContrasena.Text.Trim()),
                    Estado = chkEstado.Checked,
                    Administrador = chkAdministrador.Checked
                };

                if (objActualizarUsuario.ActualizarUsuario(objUsuario) > 0)
                {
                    Limpiar();
                    HabilitarControles(true, false, false, false, false, false);
                    ListadoUsuario();
                    XtraMessageBox.Show("Registro actualizado satisfactoriamente", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al actualizar el registro", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
