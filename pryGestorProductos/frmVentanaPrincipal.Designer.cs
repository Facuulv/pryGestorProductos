namespace pryGestorProductos
{
    partial class frmVentanaPrincipal
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.msBarra = new System.Windows.Forms.MenuStrip();
            this.gESTIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.bUSCARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbPanel = new System.Windows.Forms.GroupBox();
            this.btnReposicion = new System.Windows.Forms.Button();
            this.agregarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.msBarra.SuspendLayout();
            this.gbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(6, 91);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 54);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "LIMPIAR TABLA";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(6, 19);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(119, 54);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "LISTAR PRODUCTOS";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(160, 52);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(750, 377);
            this.dgvProductos.TabIndex = 7;
            // 
            // msBarra
            // 
            this.msBarra.AutoSize = false;
            this.msBarra.BackColor = System.Drawing.Color.Beige;
            this.msBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gESTIÓNToolStripMenuItem,
            this.toolStripTextBox1,
            this.bUSCARToolStripMenuItem,
            this.toolStripTextBox2,
            this.rEPORTESToolStripMenuItem});
            this.msBarra.Location = new System.Drawing.Point(0, 0);
            this.msBarra.Name = "msBarra";
            this.msBarra.Size = new System.Drawing.Size(937, 49);
            this.msBarra.TabIndex = 10;
            this.msBarra.Text = "menuStrip1";
            // 
            // gESTIÓNToolStripMenuItem
            // 
            this.gESTIÓNToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gESTIÓNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductosToolStripMenuItem,
            this.modificarProductosToolStripMenuItem,
            this.modificarProductosToolStripMenuItem1,
            this.eliminarProductosToolStripMenuItem});
            this.gESTIÓNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gESTIÓNToolStripMenuItem.Name = "gESTIÓNToolStripMenuItem";
            this.gESTIÓNToolStripMenuItem.Size = new System.Drawing.Size(70, 45);
            this.gESTIÓNToolStripMenuItem.Text = "GESTIÓN";
            // 
            // modificarProductosToolStripMenuItem
            // 
            this.modificarProductosToolStripMenuItem.Name = "modificarProductosToolStripMenuItem";
            this.modificarProductosToolStripMenuItem.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BackColor = System.Drawing.Color.Beige;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(10, 45);
            this.toolStripTextBox1.Text = "|";
            // 
            // bUSCARToolStripMenuItem
            // 
            this.bUSCARToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bUSCARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.bUSCARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUSCARToolStripMenuItem.Name = "bUSCARToolStripMenuItem";
            this.bUSCARToolStripMenuItem.Size = new System.Drawing.Size(66, 45);
            this.bUSCARToolStripMenuItem.Text = "BUSCAR";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BackColor = System.Drawing.Color.Beige;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(10, 23);
            this.toolStripTextBox2.Text = "|";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.rEPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem1});
            this.rEPORTESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(90, 45);
            this.rEPORTESToolStripMenuItem.Text = "INVENTARIO";
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.Image = global::pryGestorProductos.Properties.Resources.export_notes_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.reportesToolStripMenuItem1.Text = "Reportes...";
            this.reportesToolStripMenuItem1.Click += new System.EventHandler(this.reportesToolStripMenuItem1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(6, 235);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 54);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbPanel
            // 
            this.gbPanel.Controls.Add(this.btnReposicion);
            this.gbPanel.Controls.Add(this.btnListar);
            this.gbPanel.Controls.Add(this.btnSalir);
            this.gbPanel.Controls.Add(this.btnLimpiar);
            this.gbPanel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPanel.Location = new System.Drawing.Point(12, 52);
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.Size = new System.Drawing.Size(130, 307);
            this.gbPanel.TabIndex = 12;
            this.gbPanel.TabStop = false;
            this.gbPanel.Text = "PANEL DE CONTROL";
            // 
            // btnReposicion
            // 
            this.btnReposicion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReposicion.Location = new System.Drawing.Point(6, 163);
            this.btnReposicion.Name = "btnReposicion";
            this.btnReposicion.Size = new System.Drawing.Size(119, 54);
            this.btnReposicion.TabIndex = 13;
            this.btnReposicion.Text = "REPOSICIÓN";
            this.btnReposicion.UseVisualStyleBackColor = true;
            this.btnReposicion.Click += new System.EventHandler(this.btnReposicion_Click);
            // 
            // agregarProductosToolStripMenuItem
            // 
            this.agregarProductosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.agregarProductosToolStripMenuItem.Image = global::pryGestorProductos.Properties.Resources.add_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            this.agregarProductosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.agregarProductosToolStripMenuItem.Text = "Agregar productos...";
            this.agregarProductosToolStripMenuItem.Click += new System.EventHandler(this.agregarProductosToolStripMenuItem_Click);
            // 
            // modificarProductosToolStripMenuItem1
            // 
            this.modificarProductosToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modificarProductosToolStripMenuItem1.Image = global::pryGestorProductos.Properties.Resources.edit_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.modificarProductosToolStripMenuItem1.Name = "modificarProductosToolStripMenuItem1";
            this.modificarProductosToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.modificarProductosToolStripMenuItem1.Text = "Modificar productos...";
            this.modificarProductosToolStripMenuItem1.Click += new System.EventHandler(this.modificarProductosToolStripMenuItem1_Click);
            // 
            // eliminarProductosToolStripMenuItem
            // 
            this.eliminarProductosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eliminarProductosToolStripMenuItem.Image = global::pryGestorProductos.Properties.Resources.delete_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.eliminarProductosToolStripMenuItem.Name = "eliminarProductosToolStripMenuItem";
            this.eliminarProductosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.eliminarProductosToolStripMenuItem.Text = "Eliminar Productos...";
            this.eliminarProductosToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::pryGestorProductos.Properties.Resources.search_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos...";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 447);
            this.Controls.Add(this.gbPanel);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.msBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.msBarra;
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVentanaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.msBarra.ResumeLayout(false);
            this.msBarra.PerformLayout();
            this.gbPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.MenuStrip msBarra;
        private System.Windows.Forms.ToolStripMenuItem gESTIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator modificarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUSCARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbPanel;
        private System.Windows.Forms.Button btnReposicion;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}

