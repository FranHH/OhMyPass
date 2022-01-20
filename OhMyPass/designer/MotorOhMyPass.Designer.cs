
namespace OhMyPass
{
    partial class MotorOhMyPass
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotorOhMyPass));
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lvControl = new System.Windows.Forms.ListView();
            this.PASS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerOcultar = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFiltroGrupo = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnDesEncrypt = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.exportar = new System.Windows.Forms.Button();
            this.ttExportar = new System.Windows.Forms.ToolTip(this.components);
            this.ttEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttNombre = new System.Windows.Forms.ToolTip(this.components);
            this.ttContraseña = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPINToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtuveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnBarra = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.tbPass.Location = new System.Drawing.Point(103, 39);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(698, 23);
            this.tbPass.TabIndex = 1;
            this.ttContraseña.SetToolTip(this.tbPass, "Introduce la contraseña que quieres guardar");
            // 
            // lvControl
            // 
            this.lvControl.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lvControl.BackgroundImageTiled = true;
            this.lvControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PASS,
            this.NAME,
            this.Group});
            this.lvControl.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvControl.ForeColor = System.Drawing.Color.Black;
            this.lvControl.HideSelection = false;
            this.lvControl.HoverSelection = true;
            this.lvControl.Location = new System.Drawing.Point(0, 27);
            this.lvControl.Name = "lvControl";
            this.lvControl.Size = new System.Drawing.Size(1264, 479);
            this.lvControl.TabIndex = 5;
            this.lvControl.UseCompatibleStateImageBehavior = false;
            this.lvControl.View = System.Windows.Forms.View.Details;
            this.lvControl.SelectedIndexChanged += new System.EventHandler(this.lvControl_Click);
            // 
            // PASS
            // 
            this.PASS.Text = "Contraseña";
            this.PASS.Width = 664;
            // 
            // NAME
            // 
            this.NAME.Text = "Nombre";
            this.NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NAME.Width = 305;
            // 
            // Group
            // 
            this.Group.Text = "Grupo";
            this.Group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Group.Width = 291;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.tbNombre.Location = new System.Drawing.Point(103, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(698, 23);
            this.tbNombre.TabIndex = 0;
            this.ttNombre.SetToolTip(this.tbNombre, "Introduce el nombre al que hace referencia la contraseña. Ej: Nombre: Gmail. ");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbGrupo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbGrupo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbNombre);
            this.panel2.Controls.Add(this.btnVerOcultar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbPass);
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 153);
            this.panel2.TabIndex = 15;
            // 
            // tbGrupo
            // 
            this.tbGrupo.Enabled = false;
            this.tbGrupo.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.tbGrupo.Location = new System.Drawing.Point(533, 79);
            this.tbGrupo.Name = "tbGrupo";
            this.tbGrupo.Size = new System.Drawing.Size(268, 23);
            this.tbGrupo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Introduce grupo al que pertenece";
            // 
            // cbGrupo
            // 
            this.cbGrupo.AutoCompleteCustomSource.AddRange(new string[] {
            "Banco",
            "Correo",
            "Instagram",
            "Otros"});
            this.cbGrupo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cbGrupo.ContextMenuStrip = this.contextMenuStrip1;
            this.cbGrupo.DisplayMember = "Selecciona...";
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGrupo.Font = new System.Drawing.Font("Lucida Bright", 13F);
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cbGrupo.Items.AddRange(new object[] {
            "Banco",
            "Correo",
            "Instagram",
            "Otros"});
            this.cbGrupo.Location = new System.Drawing.Point(134, 79);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(111, 28);
            this.cbGrupo.TabIndex = 2;
            this.cbGrupo.SelectedIndexChanged += new System.EventHandler(this.cbGrupo_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Selecciona grupo";
            // 
            // btnVerOcultar
            // 
            this.btnVerOcultar.BackColor = System.Drawing.Color.White;
            this.btnVerOcultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerOcultar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerOcultar.ForeColor = System.Drawing.Color.White;
            this.btnVerOcultar.Image = global::OhMyPass.Properties.Resources.ver;
            this.btnVerOcultar.Location = new System.Drawing.Point(766, 40);
            this.btnVerOcultar.Name = "btnVerOcultar";
            this.btnVerOcultar.Size = new System.Drawing.Size(26, 18);
            this.btnVerOcultar.TabIndex = 9;
            this.btnVerOcultar.UseVisualStyleBackColor = false;
            this.btnVerOcultar.Click += new System.EventHandler(this.btnVerOcultar_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEncrypt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(689, 108);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(112, 35);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Guardar";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 9.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(831, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Filtrar Grupo";
            // 
            // cbFiltroGrupo
            // 
            this.cbFiltroGrupo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.cbFiltroGrupo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbFiltroGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroGrupo.Enabled = false;
            this.cbFiltroGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFiltroGrupo.Font = new System.Drawing.Font("Lucida Bright", 13F);
            this.cbFiltroGrupo.ForeColor = System.Drawing.Color.Black;
            this.cbFiltroGrupo.FormattingEnabled = true;
            this.cbFiltroGrupo.Location = new System.Drawing.Point(928, 512);
            this.cbFiltroGrupo.Name = "cbFiltroGrupo";
            this.cbFiltroGrupo.Size = new System.Drawing.Size(287, 28);
            this.cbFiltroGrupo.TabIndex = 19;
            this.cbFiltroGrupo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbFiltroGrupo_DrawItem);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnFiltrar.Enabled = false;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnFiltrar.Image = global::OhMyPass.Properties.Resources.filtro;
            this.btnFiltrar.Location = new System.Drawing.Point(1221, 512);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(41, 28);
            this.btnFiltrar.TabIndex = 19;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnDesEncrypt
            // 
            this.btnDesEncrypt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnDesEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesEncrypt.Enabled = false;
            this.btnDesEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesEncrypt.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDesEncrypt.Location = new System.Drawing.Point(834, 614);
            this.btnDesEncrypt.Name = "btnDesEncrypt";
            this.btnDesEncrypt.Size = new System.Drawing.Size(136, 26);
            this.btnDesEncrypt.TabIndex = 7;
            this.btnDesEncrypt.Text = "Mostrar contraseña";
            this.btnDesEncrypt.UseVisualStyleBackColor = false;
            this.btnDesEncrypt.Click += new System.EventHandler(this.btnDesEncrypt_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::OhMyPass.Properties.Resources.eliminar;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnEliminar.Location = new System.Drawing.Point(1080, 606);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(33, 34);
            this.btnEliminar.TabIndex = 8;
            this.ttEliminar.SetToolTip(this.btnEliminar, "Eliminar una contraseña");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // exportar
            // 
            this.exportar.BackgroundImage = global::OhMyPass.Properties.Resources.exportar;
            this.exportar.Enabled = false;
            this.exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportar.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.exportar.Location = new System.Drawing.Point(1233, 614);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(25, 26);
            this.exportar.TabIndex = 6;
            this.ttExportar.SetToolTip(this.exportar, "Exportar fichero");
            this.exportar.UseVisualStyleBackColor = true;
            this.exportar.Click += new System.EventHandler(this.btnExportar);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarListaToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // importarListaToolStripMenuItem
            // 
            this.importarListaToolStripMenuItem.Name = "importarListaToolStripMenuItem";
            this.importarListaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarListaToolStripMenuItem.Text = "Importar lista";
            this.importarListaToolStripMenuItem.Click += new System.EventHandler(this.importarListaToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar aplicacion";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarPINToolStripMenuItem1});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // modificarPINToolStripMenuItem1
            // 
            this.modificarPINToolStripMenuItem1.Name = "modificarPINToolStripMenuItem1";
            this.modificarPINToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.modificarPINToolStripMenuItem1.Text = "Modificar PIN";
            this.modificarPINToolStripMenuItem1.Click += new System.EventHandler(this.modificarPINToolStripMenuItem1_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarDatosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // borrarDatosToolStripMenuItem
            // 
            this.borrarDatosToolStripMenuItem.Name = "borrarDatosToolStripMenuItem";
            this.borrarDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarDatosToolStripMenuItem.Text = "Borrar datos";
            this.borrarDatosToolStripMenuItem.Click += new System.EventHandler(this.borrarDatosToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem,
            this.instagramToolStripMenuItem,
            this.youtuveToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // instagramToolStripMenuItem
            // 
            this.instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            this.instagramToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.instagramToolStripMenuItem.Text = "Instagram";
            this.instagramToolStripMenuItem.Click += new System.EventHandler(this.instagramToolStripMenuItem_Click);
            // 
            // youtuveToolStripMenuItem
            // 
            this.youtuveToolStripMenuItem.Name = "youtuveToolStripMenuItem";
            this.youtuveToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.youtuveToolStripMenuItem.Text = "Youtube";
            this.youtuveToolStripMenuItem.Click += new System.EventHandler(this.youtuveToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnBarra
            // 
            this.btnBarra.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarra.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.btnBarra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBarra.Location = new System.Drawing.Point(1166, 646);
            this.btnBarra.Name = "btnBarra";
            this.btnBarra.Size = new System.Drawing.Size(92, 23);
            this.btnBarra.TabIndex = 4;
            this.btnBarra.Text = "Ocultar panel";
            this.btnBarra.UseVisualStyleBackColor = false;
            this.btnBarra.Click += new System.EventHandler(this.btnBarra_Click);
            // 
            // MotorOhMyPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.exportar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDesEncrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFiltroGrupo);
            this.Controls.Add(this.btnBarra);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lvControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnFiltrar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MotorOhMyPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OhMyPass";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.ColumnHeader PASS;
        private System.Windows.Forms.ColumnHeader NAME;
        public System.Windows.Forms.ListView lvControl;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exportar;
        private System.Windows.Forms.Button btnDesEncrypt;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerOcultar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip ttExportar;
        private System.Windows.Forms.ToolTip ttEliminar;
        private System.Windows.Forms.ToolTip ttNombre;
        private System.Windows.Forms.ToolTip ttContraseña;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPINToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtuveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Group;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.TextBox tbGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFiltrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFiltroGrupo;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarListaToolStripMenuItem;
        private System.Windows.Forms.Button btnBarra;
    }
}

