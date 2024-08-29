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
        clsconexionBD ObjModificarProd = new clsconexionBD();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                string producto = txtProducto.Text;
                ObjModificarProd.BuscarProducto(dgvProductos, producto);
            }else
            {
                MessageBox.Show("Debe colocar el nombre de algún producto", "Error");
            }        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
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
            txtCodigo.Enabled = true;
            txtCodigo.Text = "";
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
        private void frmModificarProductos_Load(object sender, EventArgs e)
        {
            txtProducto.Select();
            txtCodigo.TabIndex = 3;
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
        }
    }
}
