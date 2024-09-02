namespace pryGestorProductos
{
    partial class frmReportes
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
            this.tcReportes = new System.Windows.Forms.TabControl();
            this.tpBarras = new System.Windows.Forms.TabPage();
            this.tpTorta = new System.Windows.Forms.TabPage();
            this.tcReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcReportes
            // 
            this.tcReportes.Controls.Add(this.tpBarras);
            this.tcReportes.Controls.Add(this.tpTorta);
            this.tcReportes.Location = new System.Drawing.Point(12, 12);
            this.tcReportes.Name = "tcReportes";
            this.tcReportes.SelectedIndex = 0;
            this.tcReportes.Size = new System.Drawing.Size(776, 426);
            this.tcReportes.TabIndex = 0;
            // 
            // tpBarras
            // 
            this.tpBarras.Location = new System.Drawing.Point(4, 22);
            this.tpBarras.Name = "tpBarras";
            this.tpBarras.Padding = new System.Windows.Forms.Padding(3);
            this.tpBarras.Size = new System.Drawing.Size(768, 400);
            this.tpBarras.TabIndex = 0;
            this.tpBarras.Text = "Grafico de barras";
            this.tpBarras.UseVisualStyleBackColor = true;
            // 
            // tpTorta
            // 
            this.tpTorta.Location = new System.Drawing.Point(4, 22);
            this.tpTorta.Name = "tpTorta";
            this.tpTorta.Padding = new System.Windows.Forms.Padding(3);
            this.tpTorta.Size = new System.Drawing.Size(768, 400);
            this.tpTorta.TabIndex = 1;
            this.tpTorta.Text = "Grafico torta";
            this.tpTorta.UseVisualStyleBackColor = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcReportes);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes - Listados";
            this.tcReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcReportes;
        private System.Windows.Forms.TabPage tpBarras;
        private System.Windows.Forms.TabPage tpTorta;
    }
}