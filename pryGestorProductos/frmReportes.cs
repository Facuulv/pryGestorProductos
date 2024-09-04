using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryGestorProductos
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
            GraficoBarra();
            CargarBarra();

            GraficoTorta();
            CargarTorta();
        }
        clsconexionBD ObjReportes = new clsconexionBD();

        private void GraficoBarra()
        {
            ctBarra = new Chart
            {
                Dock = DockStyle.Fill
            };
            ChartArea ctAreaBarra = new ChartArea("AreaBarras")
            {
                AxisX = 
                {
                    Interval = 1,
                    LabelStyle = { Angle = -45 },
                    Title = "Productos",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold)
                },
                AxisY = 
                {
                    Interval = 1,
                    LabelStyle = { Format = "0" },
                    Title = "Cantidad",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold)
                }
            };
            ctBarra.ChartAreas.Add(ctAreaBarra);
            Series seriesBarra = new Series("GraficoBarras")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Nombre",
                YValueMembers = "Stock",
            };
            ctBarra.Series.Add(seriesBarra);
            ctBarra.Legends.Clear();
            tpBarras.Controls.Add(ctBarra);
        }
        private void CargarBarra()
        {
            DataTable productos = ObjReportes.DatosProductos();

            // Asignar el DataSource al gráfico de barras y vincular los datos
            ctBarra.DataSource = productos;
            ctBarra.DataBind();           
        }
        private void GraficoTorta()
        {
            ctTorta = new Chart
            {
                Dock = DockStyle.Fill
            };

            ctTorta.Titles.Add(new Title
            {
                Text = "Grafico tipo Torta según las Categorías de los Productos",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                Docking = Docking.Top, // Titulo lo posiciona arriba
                Position = new ElementPosition(0, 0, 100, 10)
            });

            Legend legend = new Legend
            {
                Docking = Docking.Right, // Posiciona la leyenda a la derecha
                Font = new Font("Arial", 16, FontStyle.Bold),
                Alignment = StringAlignment.Center,
                IsTextAutoFit = true,
                Position = new ElementPosition(75, 8, 20, 50)
            };
            ctTorta.Legends.Add(legend);

            ChartArea ctAreaTorta = new ChartArea("AreaTorta") { Position = new ElementPosition(0, 8, 100, 90) };
            ctTorta.ChartAreas.Add(ctAreaTorta);
            Series seriesTorta = new Series("GraficoTorta")
            {
                ChartType = SeriesChartType.Pie,
                Font = new Font("Arial", 12, FontStyle.Bold),
                XValueMember = "Categoria",
                YValueMembers = "Cantidad",
                Label = "#PERCENT",
                LegendText = "#VALX",               
            };
            ctTorta.Series.Add(seriesTorta);           
            tpTorta.Controls.Add(ctTorta);
        }

        private void CargarTorta()
        {
            DataTable categorias = ObjReportes.DatosCategorias();
            ctTorta.DataSource = categorias;
            ctTorta.DataBind();
        }
    }
}
