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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tcReportes = new System.Windows.Forms.TabControl();
            this.tpBarras = new System.Windows.Forms.TabPage();
            this.tpTorta = new System.Windows.Forms.TabPage();
            this.tpGrilla = new System.Windows.Forms.TabPage();
            this.ctBarra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ctTorta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.tcReportes.SuspendLayout();
            this.tpBarras.SuspendLayout();
            this.tpTorta.SuspendLayout();
            this.tpGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctTorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // tcReportes
            // 
            this.tcReportes.Controls.Add(this.tpBarras);
            this.tcReportes.Controls.Add(this.tpTorta);
            this.tcReportes.Controls.Add(this.tpGrilla);
            this.tcReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcReportes.Location = new System.Drawing.Point(12, 12);
            this.tcReportes.Name = "tcReportes";
            this.tcReportes.SelectedIndex = 0;
            this.tcReportes.Size = new System.Drawing.Size(1164, 607);
            this.tcReportes.TabIndex = 0;
            // 
            // tpBarras
            // 
            this.tpBarras.Controls.Add(this.ctBarra);
            this.tpBarras.Location = new System.Drawing.Point(4, 25);
            this.tpBarras.Name = "tpBarras";
            this.tpBarras.Padding = new System.Windows.Forms.Padding(3);
            this.tpBarras.Size = new System.Drawing.Size(1156, 578);
            this.tpBarras.TabIndex = 0;
            this.tpBarras.Text = "Grafico de barras";
            this.tpBarras.UseVisualStyleBackColor = true;
            // 
            // tpTorta
            // 
            this.tpTorta.Controls.Add(this.ctTorta);
            this.tpTorta.Location = new System.Drawing.Point(4, 22);
            this.tpTorta.Name = "tpTorta";
            this.tpTorta.Padding = new System.Windows.Forms.Padding(3);
            this.tpTorta.Size = new System.Drawing.Size(1156, 581);
            this.tpTorta.TabIndex = 1;
            this.tpTorta.Text = "Grafico torta";
            this.tpTorta.UseVisualStyleBackColor = true;
            // 
            // tpGrilla
            // 
            this.tpGrilla.Controls.Add(this.dgvReportes);
            this.tpGrilla.Location = new System.Drawing.Point(4, 22);
            this.tpGrilla.Name = "tpGrilla";
            this.tpGrilla.Size = new System.Drawing.Size(1156, 581);
            this.tpGrilla.TabIndex = 2;
            this.tpGrilla.Text = "Grilla";
            this.tpGrilla.UseVisualStyleBackColor = true;
            // 
            // ctBarra
            // 
            chartArea19.Name = "ChartArea1";
            this.ctBarra.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.ctBarra.Legends.Add(legend19);
            this.ctBarra.Location = new System.Drawing.Point(443, 158);
            this.ctBarra.Name = "ctBarra";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.ctBarra.Series.Add(series19);
            this.ctBarra.Size = new System.Drawing.Size(300, 300);
            this.ctBarra.TabIndex = 0;
            this.ctBarra.Text = "chart1";
            this.ctBarra.Visible = false;
            // 
            // ctTorta
            // 
            chartArea20.Name = "ChartArea1";
            this.ctTorta.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.ctTorta.Legends.Add(legend20);
            this.ctTorta.Location = new System.Drawing.Point(7, 7);
            this.ctTorta.Name = "ctTorta";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            this.ctTorta.Series.Add(series20);
            this.ctTorta.Size = new System.Drawing.Size(300, 300);
            this.ctTorta.TabIndex = 0;
            this.ctTorta.Text = "chart1";
            // 
            // dgvReportes
            // 
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(4, 4);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Size = new System.Drawing.Size(361, 335);
            this.dgvReportes.TabIndex = 0;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 631);
            this.Controls.Add(this.tcReportes);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes - Listados";
            this.tcReportes.ResumeLayout(false);
            this.tpBarras.ResumeLayout(false);
            this.tpTorta.ResumeLayout(false);
            this.tpGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctTorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcReportes;
        private System.Windows.Forms.TabPage tpBarras;
        private System.Windows.Forms.TabPage tpTorta;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctBarra;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctTorta;
        private System.Windows.Forms.TabPage tpGrilla;
        private System.Windows.Forms.DataGridView dgvReportes;
    }
}