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
        clsconexionBD ObjBuscar = new clsconexionBD();
        private void frmBuscarProductos_Load(object sender, EventArgs e)
        {          
            ObjBuscar.CargarCategorias(cmbCategoria);
            optProducto.Select();
            BotonesOpcion();           
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            ObjBuscar.ListarProductos(dgvBuscarProductos);
            AjustarCol();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                string producto = txtProducto.Text;
                ObjBuscar.BuscarProducto(dgvBuscarProductos, producto);
            }
            else
            {
                MessageBox.Show("Debe colocar el dato a buscar", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }        
        }

        private void btnBuscarCateg_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.Text != "")
            {
                string cate = cmbCategoria.Text;
                ObjBuscar.BuscarCateg(dgvBuscarProductos, cate);
            }
            else
            {
                MessageBox.Show("Debe colocar el dato a buscar", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                int cod = Convert.ToInt16(txtCodigo.Text);
                if (ObjBuscar.VerificarProd(cod))
                {
                    ObjBuscar.BuscarCodigo(dgvBuscarProductos, cod);
                } else
                {
                    MessageBox.Show($"El producto con el codigo {cod} no existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                             
            }
            else
            {
                MessageBox.Show("Debe colocar el dato a buscar", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvBuscarProductos.DataSource = null;
            dgvBuscarProductos.Rows.Clear();
            txtProducto.Text = "";
            cmbCategoria.Text = "";
            txtCodigo.Text = "";
            optProducto.Select();
        }   
        private void optProducto_CheckedChanged(object sender, EventArgs e)
        {
            BotonesOpcion();
        }

        private void optCategoria_CheckedChanged(object sender, EventArgs e)
        {
            BotonesOpcion();
        }

        private void optCodigo_CheckedChanged(object sender, EventArgs e)
        {
            BotonesOpcion();
        }
        public void BotonesOpcion()
        {
            gbProducto.Enabled = false;
            gbCategoria.Enabled = false;
            gbCodigo.Enabled = false;

            if (optProducto.Checked)
            {
                gbProducto.Enabled = true;
                cmbCategoria.Text = "";
                txtCodigo.Text = "";
            }
            else if (optCategoria.Checked)
            {
                gbCategoria.Enabled = true;
                txtProducto.Text = "";
                txtCodigo.Text = "";
            }
            else if (optCodigo.Checked)
            {
                gbCodigo.Enabled = true;
                txtProducto.Text = "";
                cmbCategoria.Text = "";
            }
        }
        public void AjustarCol()
        {
            dgvBuscarProductos.Columns[0].HeaderText = "Código";
            dgvBuscarProductos.Columns["id_Codigo"].Width = 60;
            dgvBuscarProductos.Columns["Nombre"].Width = 180;
            dgvBuscarProductos.Columns["Descripcion"].Width = 220;
            dgvBuscarProductos.Columns["Stock"].Width = 50;
            dgvBuscarProductos.Columns["Categoria"].Width = 100;
        }
    }
}
