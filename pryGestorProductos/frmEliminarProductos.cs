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
  
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigoE.Text != "")
            {
                int cod = Convert.ToInt32(txtCodigoE.Text);
                if (ObjElimProd.VerificarProd(cod))
                {
                    DialogResult resultado = MessageBox.Show(
                        "¿Seguro que quieres eliminar este producto?",
                        "Eliminar producto",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ObjElimProd.EliminarProducto(cod);
                        ObjElimProd.ListarProductos(dgvProductos);
                        //MessageBox.Show("El producto ha sido eliminado con éxito.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigoE.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El producto no se ha eliminado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }else
                {
                    MessageBox.Show($"El producto con el codigo {cod} no existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }              
            } else
            {
                MessageBox.Show("No se ha colocado ningún código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void frmEliminarProductos_Load(object sender, EventArgs e)
        {
            ObjElimProd.ListarProductos(dgvProductos);
            AjustarCol();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSelec = dgvProductos.Rows[e.RowIndex];
                txtCodigoE.Text = filaSelec.Cells["id_Codigo"].Value.ToString();
            }
        }

        private void txtCodigoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
