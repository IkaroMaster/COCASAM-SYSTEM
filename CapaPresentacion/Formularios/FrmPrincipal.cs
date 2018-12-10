using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace CapaPresentacion.Formularios
{
    public partial class FrmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
           // SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true);

           // if (!Properties.Settings.Default.Tema.Trim().Equals(""))
           // {
                //DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = Properties.Settings.Default.Tema.Trim();
           // }

            //CargarDatosGenerales();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Properties.Settings.Default.Tema = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        //private void CargarDatosGenerales()
        //{
        //    CNDatosGenerales objDatos = new CNDatosGenerales();
        //    CEDatosGenerales objDatosG = new CEDatosGenerales();

        //    objDatosG = objDatos.Mostrar_Datos();

        //    lblNombreParroquia.Text = "Parroquia " + objDatosG.Nombre_Parroquia;
        //    Funciones.Funciones.nombreParroquia = "Parroquia " + objDatosG.Nombre_Parroquia;
        //    this.Text = objDatosG.Nombre_Parroquia;

        //    MemoryStream ms = new MemoryStream((byte[])objDatosG.Logo);
        //    pELogo.Image = Image.FromStream(ms);
        //}

        private void btnProductor_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmProductor frm = new FrmProductor();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void btnNotaPeso_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmNotaPeso frm = new FrmNotaPeso();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void btnLugar_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmLugar frm = new FrmLugar();
           // frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void btnUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (xtraTabbedMdiManager1.Pages.Count > 0)
            {
                pELogo.Visible = false;
            }
            else
            {
                pELogo.Visible = true;
            }
        }

        private void FrmPrincipal_Activated(object sender, EventArgs e)
        {
            //CargarDatosGenerales();
        }

        private void tabFormContentContainer1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (xtraTabbedMdiManager1.Pages.Count > 0)
            {
                pELogo.Visible = false;
            }
            else
            {
                pELogo.Visible = true;
            }
        }
    }
}