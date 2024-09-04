using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace pryGestorProductos
{
    public partial class frmModificarProductos : Form
    {
        public frmModificarProductos()
        {
            InitializeComponent();           
        }
        private string nombreSelec;
        private string descSelec;
        private string precioSelec;
        private string stockSelec;
        private string cateSelec;

        clsconexionBD ObjModificarProd = new clsconexionBD();

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" &&
                rtxtDescripcion.Text != "" && txtPrecio.Text != ""  &&
                txtStock.Text != "" && txtCategoria.Text != "")
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string nombre = txtNombre.Text;
                string desc = rtxtDescripcion.Text;
                int precio = Convert.ToInt32(txtPrecio.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                string cate = txtCategoria.Text;

                if (nombre != nombreSelec || desc != descSelec ||
                    precio != Convert.ToInt32(precioSelec) || 
                    stock != Convert.ToInt32(stockSelec) || 
                    cate != cateSelec)
                {
                    ObjModificarProd.ModificarProducto(dgvProductos, nombre, desc, precio, stock, cate);
                    Limpiar();
                } else
                {
                    MessageBox.Show("No se ha realizado ningún cambio en los datos del producto", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }              
            } else
            {
                MessageBox.Show($"Debe seleccionar un producto para modificar sus valores", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
        public void AjustarCol()
        {
            dgvProductos.Columns[0].HeaderText = "Código";
            dgvProductos.Columns["id_Codigo"].Width = 60;
            dgvProductos.Columns["Nombre"].Width = 180;
            dgvProductos.Columns["Descripcion"].Width = 220;
            dgvProductos.Columns["Stock"].Width = 50;
            dgvProductos.Columns["Categoria"].Width = 100;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void frmModificarProductos_Load(object sender, EventArgs e)
        {
            ObjModificarProd.ListarProductos(dgvProductos);
            AjustarCol();
            txtCodigo.Enabled = false;
            txtNombre.Select();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Para verificar que la fila seleccionada sea valida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSelec = dgvProductos.Rows[e.RowIndex];

                txtCodigo.Text = filaSelec.Cells["id_Codigo"].Value.ToString();
                txtNombre.Text = nombreSelec = filaSelec.Cells["Nombre"].Value.ToString();
                rtxtDescripcion.Text = descSelec = filaSelec.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = precioSelec = filaSelec.Cells["Precio"].Value.ToString();
                txtStock.Text = stockSelec = filaSelec.Cells["Stock"].Value.ToString();
                txtCategoria.Text = cateSelec = filaSelec.Cells["Categoria"].Value.ToString();
            }
        }
    }
}
