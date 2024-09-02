namespace pryGestorProductos
{
    partial class frmBuscarProductos
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
            this.gbCodigo = new System.Windows.Forms.GroupBox();
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscarCateg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBuscarProductos = new System.Windows.Forms.DataGridView();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.optProducto = new System.Windows.Forms.RadioButton();
            this.optCategoria = new System.Windows.Forms.RadioButton();
            this.optCodigo = new System.Windows.Forms.RadioButton();
            this.gbCodigo.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProductos)).BeginInit();
            this.gbProducto.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCodigo
            // 
            this.gbCodigo.Controls.Add(this.btnBuscarCod);
            this.gbCodigo.Controls.Add(this.txtCodigo);
            this.gbCodigo.Controls.Add(this.label3);
            this.gbCodigo.Location = new System.Drawing.Point(5, 287);
            this.gbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.gbCodigo.Name = "gbCodigo";
            this.gbCodigo.Padding = new System.Windows.Forms.Padding(2);
            this.gbCodigo.Size = new System.Drawing.Size(205, 83);
            this.gbCodigo.TabIndex = 12;
            this.gbCodigo.TabStop = false;
            // 
            // btnBuscarCod
            // 
            this.btnBuscarCod.Location = new System.Drawing.Point(76, 46);
            this.btnBuscarCod.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCod.Name = "btnBuscarCod";
            this.btnBuscarCod.Size = new System.Drawing.Size(121, 29);
            this.btnBuscarCod.TabIndex = 2;
            this.btnBuscarCod.Text = "Buscar";
            this.btnBuscarCod.UseVisualStyleBackColor = true;
            this.btnBuscarCod.Click += new System.EventHandler(this.btnBuscarCod_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 22);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(610, 387);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 46);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(440, 387);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(145, 46);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "CARGAR PRODUCTOS";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cmbCategoria);
            this.gbCategoria.Controls.Add(this.btnBuscarCateg);
            this.gbCategoria.Controls.Add(this.label2);
            this.gbCategoria.Location = new System.Drawing.Point(5, 199);
            this.gbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Padding = new System.Windows.Forms.Padding(2);
            this.gbCategoria.Size = new System.Drawing.Size(205, 84);
            this.gbCategoria.TabIndex = 9;
            this.gbCategoria.TabStop = false;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(76, 22);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 3;
            // 
            // btnBuscarCateg
            // 
            this.btnBuscarCateg.Location = new System.Drawing.Point(76, 48);
            this.btnBuscarCateg.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCateg.Name = "btnBuscarCateg";
            this.btnBuscarCateg.Size = new System.Drawing.Size(121, 29);
            this.btnBuscarCateg.TabIndex = 2;
            this.btnBuscarCateg.Text = "Buscar";
            this.btnBuscarCateg.UseVisualStyleBackColor = true;
            this.btnBuscarCateg.Click += new System.EventHandler(this.btnBuscarCateg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categoría:";
            // 
            // dgvBuscarProductos
            // 
            this.dgvBuscarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProductos.Location = new System.Drawing.Point(222, 18);
            this.dgvBuscarProductos.Name = "dgvBuscarProductos";
            this.dgvBuscarProductos.Size = new System.Drawing.Size(750, 363);
            this.dgvBuscarProductos.TabIndex = 8;
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.btnBuscar);
            this.gbProducto.Controls.Add(this.txtProducto);
            this.gbProducto.Controls.Add(this.label1);
            this.gbProducto.Location = new System.Drawing.Point(5, 118);
            this.gbProducto.Margin = new System.Windows.Forms.Padding(2);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Padding = new System.Windows.Forms.Padding(2);
            this.gbProducto.Size = new System.Drawing.Size(205, 77);
            this.gbProducto.TabIndex = 7;
            this.gbProducto.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(76, 41);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(76, 17);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(121, 20);
            this.txtProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.gbCodigo);
            this.groupBox4.Controls.Add(this.gbProducto);
            this.groupBox4.Controls.Add(this.gbCategoria);
            this.groupBox4.Location = new System.Drawing.Point(1, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 380);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BÚSQUEDA DE PRODUCTOS";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.optCodigo);
            this.groupBox5.Controls.Add(this.optCategoria);
            this.groupBox5.Controls.Add(this.optProducto);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 94);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FILTROS";
            // 
            // optProducto
            // 
            this.optProducto.AutoSize = true;
            this.optProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optProducto.Location = new System.Drawing.Point(6, 19);
            this.optProducto.Name = "optProducto";
            this.optProducto.Size = new System.Drawing.Size(99, 17);
            this.optProducto.TabIndex = 0;
            this.optProducto.TabStop = true;
            this.optProducto.Text = "Por Producto";
            this.optProducto.UseVisualStyleBackColor = true;
            this.optProducto.CheckedChanged += new System.EventHandler(this.optProducto_CheckedChanged);
            // 
            // optCategoria
            // 
            this.optCategoria.AutoSize = true;
            this.optCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCategoria.Location = new System.Drawing.Point(6, 42);
            this.optCategoria.Name = "optCategoria";
            this.optCategoria.Size = new System.Drawing.Size(104, 17);
            this.optCategoria.TabIndex = 1;
            this.optCategoria.TabStop = true;
            this.optCategoria.Text = "Por Categoría";
            this.optCategoria.UseVisualStyleBackColor = true;
            this.optCategoria.CheckedChanged += new System.EventHandler(this.optCategoria_CheckedChanged);
            // 
            // optCodigo
            // 
            this.optCodigo.AutoSize = true;
            this.optCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCodigo.Location = new System.Drawing.Point(6, 65);
            this.optCodigo.Name = "optCodigo";
            this.optCodigo.Size = new System.Drawing.Size(87, 17);
            this.optCodigo.TabIndex = 2;
            this.optCodigo.TabStop = true;
            this.optCodigo.Text = "Por Código";
            this.optCodigo.UseVisualStyleBackColor = true;
            this.optCodigo.CheckedChanged += new System.EventHandler(this.optCodigo_CheckedChanged);
            // 
            // frmBuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 436);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvBuscarProductos);
            this.Name = "frmBuscarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Productos";
            this.Load += new System.EventHandler(this.frmBuscarProductos_Load);
            this.gbCodigo.ResumeLayout(false);
            this.gbCodigo.PerformLayout();
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProductos)).EndInit();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCodigo;
        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnBuscarCateg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBuscarProductos;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton optCodigo;
        private System.Windows.Forms.RadioButton optCategoria;
        private System.Windows.Forms.RadioButton optProducto;
    }
}