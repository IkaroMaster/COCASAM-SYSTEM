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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            //if (!Properties.Settings.Default.Tema.Trim().Equals(""))
            //{
            //    DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = Properties.Settings.Default.Tema.Trim();
            //}

        }

        private Boolean Validar()
        {
            if (String.IsNullOrEmpty(txtUsuario.EditValue.ToString().Trim()))
            {
                txtUsuario.ErrorText = "Ingrese el nombre de usuario";
                return false;
            }
            if (String.IsNullOrEmpty(txtContrasena.EditValue.ToString().Trim()))
            {
                txtContrasena.ErrorText = "Ingrese la contraseña";
                return false;
            }

            return true;
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Validar())
            {
                CNLogin objIniciarSesion = new CNLogin();
                CELogin objLogin = new CELogin()
                {
                    Usuario = txtUsuario.Text.Trim().Replace("'", ""),
                    Contrasena = Funciones.Funciones.Hash((txtContrasena.Text.Trim().Replace("'", "")))
                };
                //XtraMessageBox.Show(Funciones.Funciones.Hash((txtContrasena.Text.Trim().Replace("'", ""))), "probando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (objIniciarSesion.IniciarSesion(objLogin) > 0)
                {
                    this.Hide();
                    Funciones.Funciones.idUsuario = objIniciarSesion.IniciarSesion(objLogin);
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.txtUsuario.Caption = txtUsuario.Text.ToString().ToUpper();
                    frm.Show();
                }
                else
                {
                    XtraMessageBox.Show("Usuario o contraseña incorrecto", "COCASAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciar.PerformClick();
            }
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciar.PerformClick();
            }
        }
    }
}
