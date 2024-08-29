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
    public partial class frmModificarProductos : Form
    {
        public frmModificarProductos()
        {
            InitializeComponent();
        }
        conexionBD ObjModificarProd = new conexionBD();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text;
            ObjModificarProd.BuscarProducto(dgvProductos, producto);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigoProd.Text);
            string nombre = txtNombre.Text;
            string desc = rtxtDescripcion.Text;
            int precio = Convert.ToInt32(txtPrecio.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            string cate = txtCategoria.Text;

            ObjModificarProd.ModificarProducto(dgvProductos, codigo, nombre, desc, precio, stock, cate);
            Limpiar();
        }
        public void Limpiar()
        {
            txtCodigoProd.Enabled = true;
            txtCodigoProd.Text = "";
            txtNombre.Text = "";
            rtxtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCategoria.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtCodigoProd_Leave(object sender, EventArgs e)
        {
            txtCodigoProd.Enabled = false;
        }
    }
}
