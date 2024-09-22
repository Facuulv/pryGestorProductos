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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tpTorta = new System.Windows.Forms.TabPage();
            this.ctTorta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tpBarras = new System.Windows.Forms.TabPage();
            this.ctBarra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tcReportes = new System.Windows.Forms.TabControl();
            this.tpTorta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctTorta)).BeginInit();
            this.tpBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctBarra)).BeginInit();
            this.tcReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpTorta
            // 
            this.tpTorta.Controls.Add(this.ctTorta);
            this.tpTorta.Location = new System.Drawing.Point(4, 25);
            this.tpTorta.Name = "tpTorta";
            this.tpTorta.Padding = new System.Windows.Forms.Padding(3);
            this.tpTorta.Size = new System.Drawing.Size(1156, 578);
            this.tpTorta.TabIndex = 1;
            this.tpTorta.Text = "Grafico torta";
            this.tpTorta.UseVisualStyleBackColor = true;
            // 
            // ctTorta
            // 
            chartArea3.Name = "ChartArea1";
            this.ctTorta.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ctTorta.Legends.Add(legend3);
            this.ctTorta.Location = new System.Drawing.Point(401, 114);
            this.ctTorta.Name = "ctTorta";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ctTorta.Series.Add(series3);
            this.ctTorta.Size = new System.Drawing.Size(300, 300);
            this.ctTorta.TabIndex = 0;
            this.ctTorta.Text = "chart1";
            this.ctTorta.Visible = false;
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
            // ctBarra
            // 
            chartArea4.Name = "ChartArea1";
            this.ctBarra.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ctBarra.Legends.Add(legend4);
            this.ctBarra.Location = new System.Drawing.Point(443, 158);
            this.ctBarra.Name = "ctBarra";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ctBarra.Series.Add(series4);
            this.ctBarra.Size = new System.Drawing.Size(300, 300);
            this.ctBarra.TabIndex = 0;
            this.ctBarra.Text = "chart1";
            this.ctBarra.Visible = false;
            // 
            // tcReportes
            // 
            this.tcReportes.Controls.Add(this.tpBarras);
            this.tcReportes.Controls.Add(this.tpTorta);
            this.tcReportes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcReportes.Location = new System.Drawing.Point(12, 12);
            this.tcReportes.Name = "tcReportes";
            this.tcReportes.SelectedIndex = 0;
            this.tcReportes.Size = new System.Drawing.Size(1164, 607);
            this.tcReportes.TabIndex = 0;
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
            this.tpTorta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctTorta)).EndInit();
            this.tpBarras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctBarra)).EndInit();
            this.tcReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpTorta;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctTorta;
        private System.Windows.Forms.TabPage tpBarras;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctBarra;
        private System.Windows.Forms.TabControl tcReportes;
    }
}