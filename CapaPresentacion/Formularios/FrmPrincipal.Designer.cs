namespace CapaPresentacion.Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.txtUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductor = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotaPeso = new DevExpress.XtraBars.BarButtonItem();
            this.btnLugar = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnFeligres = new DevExpress.XtraBars.BarButtonItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.pELogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.txtUsuario,
            this.btnProductor,
            this.btnNotaPeso,
            this.btnLugar,
            this.btnUsuarios,
            this.barButtonGroup1,
            this.skinRibbonGalleryBarItem1,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1314, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.applicationMenu1.ItemLinks.Add(this.barButtonGroup1);
            this.applicationMenu1.ItemLinks.Add(this.barButtonItem1);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "Temas";
            this.skinRibbonGalleryBarItem1.Id = 7;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonGroup1.Id = 6;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Cerrar Sesion";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Caption = "Usuario";
            this.txtUsuario.Id = 1;
            this.txtUsuario.Name = "txtUsuario";
            // 
            // btnProductor
            // 
            this.btnProductor.Caption = "Productor";
            this.btnProductor.Id = 2;
            this.btnProductor.ImageOptions.Image = global::CapaPresentacion.Properties.Resources.hombre;
            this.btnProductor.ImageOptions.LargeImage = global::CapaPresentacion.Properties.Resources.hombre;
            this.btnProductor.Name = "btnProductor";
            this.btnProductor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductor_ItemClick);
            // 
            // btnNotaPeso
            // 
            this.btnNotaPeso.Caption = "Nota de peso";
            this.btnNotaPeso.Id = 3;
            this.btnNotaPeso.ImageOptions.LargeImage = global::CapaPresentacion.Properties.Resources.notapeso1;
            this.btnNotaPeso.Name = "btnNotaPeso";
            this.btnNotaPeso.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotaPeso_ItemClick);
            // 
            // btnLugar
            // 
            this.btnLugar.Caption = "Lugar";
            this.btnLugar.Id = 4;
            this.btnLugar.ImageOptions.LargeImage = global::CapaPresentacion.Properties.Resources.lugar1;
            this.btnLugar.Name = "btnLugar";
            this.btnLugar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLugar_ItemClick);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Caption = "Usuarios";
            this.btnUsuarios.Id = 5;
            this.btnUsuarios.ImageOptions.LargeImage = global::CapaPresentacion.Properties.Resources.usuario;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsuarios_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Control";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProductor);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotaPeso);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Gestiones";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Administracion";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLugar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUsuarios);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Gestiones";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.txtUsuario);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 747);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1314, 31);
            // 
            // btnFeligres
            // 
            this.btnFeligres.Caption = "Feligres";
            this.btnFeligres.Id = 2;
            this.btnFeligres.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFeligres.ImageOptions.Image")));
            this.btnFeligres.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFeligres.ImageOptions.LargeImage")));
            this.btnFeligres.Name = "btnFeligres";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager1_PageAdded);
            this.xtraTabbedMdiManager1.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager1_PageRemoved);
            // 
            // pELogo
            // 
            this.pELogo.BackgroundImage = global::CapaPresentacion.Properties.Resources.FondoMDI;
            this.pELogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pELogo.EditValue = global::CapaPresentacion.Properties.Resources.FondoMDI1;
            this.pELogo.Location = new System.Drawing.Point(0, 137);
            this.pELogo.MenuManager = this.ribbon;
            this.pELogo.Name = "pELogo";
            this.pELogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pELogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pELogo.Properties.ZoomAccelerationFactor = 1D;
            this.pELogo.Size = new System.Drawing.Size(1304, 590);
            this.pELogo.TabIndex = 9;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(870, 795);
            this.Controls.Add(this.pELogo);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FrmPrincipal";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        public DevExpress.XtraBars.BarButtonItem txtUsuario;
        private DevExpress.XtraBars.BarButtonItem btnProductor;
        private DevExpress.XtraBars.BarButtonItem btnFeligres;
        private DevExpress.XtraBars.BarButtonItem btnNotaPeso;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnLugar;
        private DevExpress.XtraBars.BarButtonItem btnUsuarios;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraEditors.PictureEdit pELogo;
    }
}