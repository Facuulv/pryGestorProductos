using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestorProductos
{
    public partial class frmBuscarProductos : Form
    {
        public frmBuscarProductos()
        {
            InitializeComponent();
        }
        conexionBD ObjBuscar = new conexionBD();
        private void frmBuscarProductos_Load(object sender, EventArgs e)
        {
            ObjBuscar.CargarCategorias(cmbCategoria);
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            ObjBuscar.ListarProductos(dgvBuscarProductos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text;
            ObjBuscar.BuscarProducto(dgvBuscarProductos, producto);
        }

        private void btnBuscarCateg_Click(object sender, EventArgs e)
        {
            string cate = cmbCategoria.Text;
            ObjBuscar.BuscarCateg(dgvBuscarProductos, cate);
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt16(txtCodigo.Text);
            ObjBuscar.BuscarCodigo(dgvBuscarProductos, cod);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvBuscarProductos.DataSource = null;
            dgvBuscarProductos.Rows.Clear();
            txtProducto.Text = "";
            cmbCategoria.Text = "";
            txtCodigo.Text = "";
        }
    }
}
