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
    public partial class frmAgregarProductos : Form
    {
        public frmAgregarProductos()
        {
            InitializeComponent();
        }

        clsconexionBD ObjAgregarProd = new clsconexionBD();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" &&
                rtxtDescripcion.Text != "" && txtPrecio.Text != "" &&
                txtStock.Text != "" && txtCategoria.Text != "")
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                if (!ObjAgregarProd.VerificarProd(codigo))
                {
                    string nombre = txtNombre.Text;
                    string desc = rtxtDescripcion.Text;
                    int precio = Convert.ToInt32(txtPrecio.Text);
                    int stock = Convert.ToInt32(txtStock.Text);
                    string cate = txtCategoria.Text;

                    ObjAgregarProd.AgregarProducto(codigo, nombre, desc, precio, stock, cate);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show($"El producto con el código {codigo} ya existe.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para agregar un producto", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        public void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            rtxtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCategoria.Text = "";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.') return;
            e.Handled = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.') return;
            e.Handled = true;
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.') return;
            e.Handled = true;
        }
    }
}
