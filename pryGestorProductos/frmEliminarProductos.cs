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
    public partial class frmEliminarProductos : Form
    {
        public frmEliminarProductos()
        {
            InitializeComponent();
        }
        clsconexionBD ObjElimProd = new clsconexionBD();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            ObjElimProd.ListarProductos(dgvProductos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCodigoE.Text);
            ObjElimProd.EliminarProducto(cod);
            ObjElimProd.ListarProductos(dgvProductos);
        }
    }
}
