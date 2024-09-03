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
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
            //MessageBox.Show("Bienvenido al Gestor de Productos Hardware", "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        clsconexionBD ObjPrincipal = new clsconexionBD();
        private void btnListar_Click(object sender, EventArgs e)
        {
            ObjPrincipal.ListarProductos(dgvProductos);
            AjustarCol();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarProductos frmAgregar = new frmAgregarProductos();
            frmAgregar.Show();
        }

        private void modificarProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModificarProductos frmModificar = new frmModificarProductos();
            frmModificar.Show();
        }

        private void eliminarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarProductos frmEliminar = new frmEliminarProductos();
            frmEliminar.Show();
        }
        public void AjustarCol()
        {
            dgvProductos.Columns["id_Codigo"].Width = 60;
            dgvProductos.Columns["Nombre"].Width = 180;
            dgvProductos.Columns["Descripcion"].Width = 220;
            dgvProductos.Columns["Stock"].Width = 50;
            dgvProductos.Columns["Categoria"].Width = 100;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarProductos frmBuscar = new frmBuscarProductos();
            frmBuscar.Show();
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReportes frmReportes = new frmReportes();
            frmReportes.Show();
        }

        private void frmVentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
