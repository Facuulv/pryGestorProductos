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
            ConfigurarGraficos();
            CargarGraficos();
        }
        clsconexionBD ObjReportes = new clsconexionBD();

        private void ConfigurarGraficos()
        {
            ctBarra = new Chart
            {
                Dock = DockStyle.Fill // Asegurar que se expanda para llenar el TabPage
            };
            ChartArea ctArea = new ChartArea("AreaBarras")
            {
                AxisX = {
                    Interval = 1,
                    LabelStyle = {Angle = -45},                   
                    Title = "Productos",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold)
                },
                AxisY =
                {
                    Interval = 1, // Intervalo entre etiquetas en el eje Y                    
                    LabelStyle = { Format = "0" }, // Formato de etiquetas en el eje Y
                    Title = "Cantidad",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold)
                }
            };
            ctBarra.ChartAreas.Add(ctArea);
            Series series = new Series("Grafico")
            {
                ChartType = SeriesChartType.Column,
                XValueMember = "Nombre",
                YValueMembers = "Stock",
            };

            ctBarra.Series.Add(series);
            ctBarra.Legends.Clear();
            tpBarras.Controls.Add(ctBarra);
        }
        private void CargarGraficos()
        {
            DataTable productos = ObjReportes.DatosProductos();

            // Asignar el DataSource al gráfico de barras y vincular los datos
            ctBarra.DataSource = productos;
            ctBarra.DataBind();
        }
    }
}
