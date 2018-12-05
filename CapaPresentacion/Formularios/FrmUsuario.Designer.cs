namespace CapaPresentacion.Formularios
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdProductor = new System.Windows.Forms.TextBox();
            this.gBxControles = new System.Windows.Forms.GroupBox();
            this.pBxRegresar = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pBxActualizar = new System.Windows.Forms.PictureBox();
            this.pBxGuardar = new System.Windows.Forms.PictureBox();
            this.pBxCancelar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pBxNuevo = new System.Windows.Forms.PictureBox();
            this.gcDatosUsuario = new DevExpress.XtraGrid.GridControl();
            this.gvDatosUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContrasena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDatos = new DevExpress.XtraEditors.GroupControl();
            this.chkAdministrador = new DevExpress.XtraEditors.CheckEdit();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdUsuario = new DevExpress.XtraEditors.TextEdit();
            this.colAdministrador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).BeginInit();
            this.gcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdministrador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdUsuario.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdProductor);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 79);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 65);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(92, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario";
            // 
            // txtIdProductor
            // 
            this.txtIdProductor.Enabled = false;
            this.txtIdProductor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProductor.Location = new System.Drawing.Point(191, 27);
            this.txtIdProductor.Name = "txtIdProductor";
            this.txtIdProductor.Size = new System.Drawing.Size(10, 27);
            this.txtIdProductor.TabIndex = 5;
            this.txtIdProductor.Visible = false;
            // 
            // gBxControles
            // 
            this.gBxControles.Controls.Add(this.pBxRegresar);
            this.gBxControles.Controls.Add(this.label10);
            this.gBxControles.Controls.Add(this.label9);
            this.gBxControles.Controls.Add(this.label8);
            this.gBxControles.Controls.Add(this.label7);
            this.gBxControles.Controls.Add(this.pBxActualizar);
            this.gBxControles.Controls.Add(this.pBxGuardar);
            this.gBxControles.Controls.Add(this.pBxCancelar);
            this.gBxControles.Controls.Add(this.label6);
            this.gBxControles.Controls.Add(this.pBxNuevo);
            this.gBxControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxControles.Location = new System.Drawing.Point(224, 346);
            this.gBxControles.Name = "gBxControles";
            this.gBxControles.Size = new System.Drawing.Size(413, 124);
            this.gBxControles.TabIndex = 18;
            this.gBxControles.TabStop = false;
            this.gBxControles.Text = "Controles";
            // 
            // pBxRegresar
            // 
            this.pBxRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBxRegresar.BackgroundImage")));
            this.pBxRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBxRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBxRegresar.Location = new System.Drawing.Point(322, 31);
            this.pBxRegresar.Name = "pBxRegresar";
            this.pBxRegresar.Size = new System.Drawing.Size(57, 60);
            this.pBxRegresar.TabIndex = 10;
            this.pBxRegresar.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Regresar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(163, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Actualizar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cancelar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Guardar";
            // 
            // pBxActualizar
            // 
            this.pBxActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBxActualizar.BackgroundImage")));
            this.pBxActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBxActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBxActualizar.Location = new System.Drawing.Point(173, 33);
            this.pBxActualizar.Name = "pBxActualizar";
            this.pBxActualizar.Size = new System.Drawing.Size(57, 58);
            this.pBxActualizar.TabIndex = 4;
            this.pBxActualizar.TabStop = false;
            this.pBxActualizar.Click += new System.EventHandler(this.pBxActualizar_Click);
            // 
            // pBxGuardar
            // 
            this.pBxGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBxGuardar.BackgroundImage")));
            this.pBxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBxGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBxGuardar.Location = new System.Drawing.Point(98, 33);
            this.pBxGuardar.Name = "pBxGuardar";
            this.pBxGuardar.Size = new System.Drawing.Size(57, 58);
            this.pBxGuardar.TabIndex = 2;
            this.pBxGuardar.TabStop = false;
            this.pBxGuardar.Click += new System.EventHandler(this.pBxGuardar_Click);
            // 
            // pBxCancelar
            // 
            this.pBxCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBxCancelar.BackgroundImage")));
            this.pBxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBxCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBxCancelar.Location = new System.Drawing.Point(250, 31);
            this.pBxCancelar.Name = "pBxCancelar";
            this.pBxCancelar.Size = new System.Drawing.Size(57, 60);
            this.pBxCancelar.TabIndex = 3;
            this.pBxCancelar.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nuevo";
            // 
            // pBxNuevo
            // 
            this.pBxNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBxNuevo.BackgroundImage")));
            this.pBxNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBxNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBxNuevo.Location = new System.Drawing.Point(28, 32);
            this.pBxNuevo.Name = "pBxNuevo";
            this.pBxNuevo.Size = new System.Drawing.Size(57, 58);
            this.pBxNuevo.TabIndex = 0;
            this.pBxNuevo.TabStop = false;
            // 
            // gcDatosUsuario
            // 
            this.gcDatosUsuario.ContextMenuStrip = this.contextMenuStrip1;
            gridLevelNode2.RelationName = "Level1";
            this.gcDatosUsuario.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gcDatosUsuario.Location = new System.Drawing.Point(383, 85);
            this.gcDatosUsuario.MainView = this.gvDatosUsuario;
            this.gcDatosUsuario.Name = "gcDatosUsuario";
            this.gcDatosUsuario.Size = new System.Drawing.Size(517, 255);
            this.gcDatosUsuario.TabIndex = 153;
            this.gcDatosUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatosUsuario});
            // 
            // gvDatosUsuario
            // 
            this.gvDatosUsuario.ColumnPanelRowHeight = 26;
            this.gvDatosUsuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUsuario,
            this.colUsuario,
            this.colContrasena,
            this.colEstado,
            this.colAdministrador});
            this.gvDatosUsuario.GridControl = this.gcDatosUsuario;
            this.gvDatosUsuario.Name = "gvDatosUsuario";
            this.gvDatosUsuario.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvDatosUsuario.OptionsBehavior.Editable = false;
            this.gvDatosUsuario.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvDatosUsuario.OptionsFind.AlwaysVisible = true;
            this.gvDatosUsuario.OptionsFind.FindNullPrompt = "Buscar aquí";
            this.gvDatosUsuario.OptionsView.ShowFooter = true;
            this.gvDatosUsuario.OptionsView.ShowGroupPanel = false;
            this.gvDatosUsuario.RowHeight = 22;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colIdUsuario.AppearanceCell.Options.UseFont = true;
            this.colIdUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colIdUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUsuario.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colIdUsuario.AppearanceHeader.Options.UseFont = true;
            this.colIdUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdUsuario.Caption = "Id Usuario";
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Usuario = {0}", "{0}")});
            this.colIdUsuario.Width = 149;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colUsuario.AppearanceCell.Options.UseFont = true;
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colUsuario.AppearanceHeader.Options.UseFont = true;
            this.colUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUsuario.Caption = "Usuario";
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 0;
            this.colUsuario.Width = 206;
            // 
            // colContrasena
            // 
            this.colContrasena.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colContrasena.AppearanceCell.Options.UseFont = true;
            this.colContrasena.AppearanceCell.Options.UseTextOptions = true;
            this.colContrasena.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colContrasena.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colContrasena.AppearanceHeader.Options.UseFont = true;
            this.colContrasena.AppearanceHeader.Options.UseTextOptions = true;
            this.colContrasena.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContrasena.Caption = "Contraseña";
            this.colContrasena.FieldName = "Contraseña";
            this.colContrasena.Name = "colContrasena";
            this.colContrasena.Width = 188;
            // 
            // colEstado
            // 
            this.colEstado.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colEstado.AppearanceCell.Options.UseFont = true;
            this.colEstado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colEstado.AppearanceHeader.Options.UseFont = true;
            this.colEstado.AppearanceHeader.Options.UseTextOptions = true;
            this.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.Caption = "Activo";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 1;
            this.colEstado.Width = 215;
            // 
            // gcDatos
            // 
            this.gcDatos.Controls.Add(this.chkAdministrador);
            this.gcDatos.Controls.Add(this.chkEstado);
            this.gcDatos.Controls.Add(this.labelControl3);
            this.gcDatos.Controls.Add(this.txtContrasena);
            this.gcDatos.Controls.Add(this.labelControl2);
            this.gcDatos.Controls.Add(this.txtUsuario);
            this.gcDatos.Controls.Add(this.labelControl1);
            this.gcDatos.Controls.Add(this.txtIdUsuario);
            this.gcDatos.Location = new System.Drawing.Point(4, 85);
            this.gcDatos.Name = "gcDatos";
            this.gcDatos.Size = new System.Drawing.Size(373, 255);
            this.gcDatos.TabIndex = 152;
            this.gcDatos.Text = "Datos del Usuario";
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.Location = new System.Drawing.Point(185, 206);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdministrador.Properties.Appearance.Options.UseFont = true;
            this.chkAdministrador.Properties.Caption = "Administrador";
            this.chkAdministrador.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkAdministrador.Size = new System.Drawing.Size(133, 23);
            this.chkAdministrador.TabIndex = 193;
            // 
            // chkEstado
            // 
            this.chkEstado.Location = new System.Drawing.Point(54, 206);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Properties.Appearance.Options.UseFont = true;
            this.chkEstado.Properties.Caption = "Activo";
            this.chkEstado.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkEstado.Size = new System.Drawing.Size(71, 23);
            this.chkEstado.TabIndex = 192;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(44, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 21);
            this.labelControl3.TabIndex = 176;
            this.labelControl3.Text = "Usuario";
            // 
            // txtContrasena
            // 
            this.txtContrasena.EditValue = "";
            this.txtContrasena.Location = new System.Drawing.Point(108, 142);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Properties.Appearance.Options.UseFont = true;
            this.txtContrasena.Properties.UseSystemPasswordChar = true;
            this.txtContrasena.Size = new System.Drawing.Size(212, 28);
            this.txtContrasena.TabIndex = 175;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 145);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 21);
            this.labelControl2.TabIndex = 174;
            this.labelControl2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "";
            this.txtUsuario.Location = new System.Drawing.Point(108, 91);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Size = new System.Drawing.Size(212, 28);
            this.txtUsuario.TabIndex = 173;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 21);
            this.labelControl1.TabIndex = 172;
            this.labelControl1.Text = "Id Usuario";
            this.labelControl1.Visible = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(108, 47);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(181, 28);
            this.txtIdUsuario.TabIndex = 171;
            this.txtIdUsuario.Visible = false;
            // 
            // colAdministrador
            // 
            this.colAdministrador.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.colAdministrador.AppearanceCell.Options.UseFont = true;
            this.colAdministrador.AppearanceHeader.Options.UseFont = true;
            this.colAdministrador.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdministrador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdministrador.Caption = "Administrador";
            this.colAdministrador.FieldName = "Administrador";
            this.colAdministrador.Name = "colAdministrador";
            this.colAdministrador.Visible = true;
            this.colAdministrador.VisibleIndex = 2;
            this.colAdministrador.Width = 76;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 26);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 474);
            this.Controls.Add(this.gcDatosUsuario);
            this.Controls.Add(this.gcDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gBxControles);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gBxControles.ResumeLayout(false);
            this.gBxControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatos)).EndInit();
            this.gcDatos.ResumeLayout(false);
            this.gcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdministrador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdUsuario.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProductor;
        private System.Windows.Forms.GroupBox gBxControles;
        private System.Windows.Forms.PictureBox pBxRegresar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pBxActualizar;
        private System.Windows.Forms.PictureBox pBxGuardar;
        private System.Windows.Forms.PictureBox pBxCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pBxNuevo;
        private DevExpress.XtraGrid.GridControl gcDatosUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDatosUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colContrasena;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.GroupControl gcDatos;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtIdUsuario;
        private DevExpress.XtraEditors.CheckEdit chkAdministrador;
        private DevExpress.XtraGrid.Columns.GridColumn colAdministrador;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}