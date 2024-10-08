﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryGestorProductos
{
    internal class clsconexionBD
    {
        // Definicion de comando, conexion y adaptador.

        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public clsconexionBD()
        {
            cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../DataBase\Productos.accdb;";
        }

        /*public void Conectar()
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                conexion.Open();
                MessageBox.Show("Se conectó correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        public void ListarProductos(DataGridView dgvProductos)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Productos ORDER BY id_Codigo";

                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvProductos.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AgregarProducto(int cod, string nom, string desc, int precio, int stock, string cate)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"INSERT INTO Productos (id_Codigo, Nombre, Descripcion, Precio, Stock, Categoria) VALUES (?, ?, ?, ?, ?, ?)";

                comando.Parameters.AddWithValue("@id_Codigo", cod);
                comando.Parameters.AddWithValue("@Nombre", nom);
                comando.Parameters.AddWithValue("@Descripcion", desc);
                comando.Parameters.AddWithValue("@Precio", precio);
                comando.Parameters.AddWithValue("@Stock", stock);
                comando.Parameters.AddWithValue("@Categoria", cate);

                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado el producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BuscarProducto(DataGridView dgvBuscar, string nom)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Productos WHERE Nombre LIKE @Nombre";

                // Los % es para que busque lo mas parecido/cercano al parametro nom
                comando.Parameters.AddWithValue("@Nombre", "%" + nom + "%");
                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvBuscar.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ModificarProducto(DataGridView dgvModificarProd, string nom, string desc, int precio, int stock, string cate)
        {
            try
            {
                int codigoProducto = int.Parse(dgvModificarProd.SelectedRows[0].Cells["id_Codigo"].Value.ToString());

                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Productos SET Nombre = ?, Descripcion = ?, Precio = ?, Stock = ?, Categoria = ? WHERE id_Codigo = ?";

                comando.Parameters.AddWithValue("@Nombre", nom);
                comando.Parameters.AddWithValue("@Descripcion", desc);
                comando.Parameters.AddWithValue("@Precio", precio);
                comando.Parameters.AddWithValue("@Stock", stock);
                comando.Parameters.AddWithValue("@Categoria", cate);
                comando.Parameters.AddWithValue("@id_Codigo", codigoProducto);


                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha modificado el producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarProductos(dgvModificarProd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EliminarProducto(int cod)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM Productos WHERE id_Codigo = ?";

                comando.Parameters.AddWithValue("@id_Codigo", cod);

                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarCategorias(ComboBox cmbCategorias)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT DISTINCT Categoria FROM Productos";
                conexion.Open();

                //Ejecuta la consulta y devuelve el datareader con los resultados
                OleDbDataReader reader = comando.ExecuteReader();
                cmbCategorias.Items.Clear();
                // Mientras lea cada registro
                while (reader.Read())
                {
                    string categoria = reader["Categoria"].ToString();
                    cmbCategorias.Items.Add(categoria);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BuscarCateg(DataGridView dgvBuscar, string cate)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Productos WHERE Categoria = @Categoria ORDER BY id_Codigo";

                comando.Parameters.AddWithValue("@Categoria", cate);
                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvBuscar.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BuscarCodigo(DataGridView dgvBuscar, int cod)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Productos WHERE id_Codigo = @id_Codigo";
                comando.Parameters.AddWithValue("@id_Codigo", cod);

                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvBuscar.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool VerificarProd(int cod)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM Productos WHERE id_Codigo = @id_Codigo";
                comando.Parameters.AddWithValue("@id_Codigo", cod);

                conexion.Open();
                int contador = (int)comando.ExecuteScalar();
                return contador > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return false;
            }
        }
        public void VerificarStockCero()
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Nombre FROM Productos WHERE Stock <= 0";

                DataTable tablaProductos = new DataTable();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                //Si hay productos en la tabla virtual entra y larga el mensaje de reposicion
                if (tablaProductos.Rows.Count > 0)
                {
                    string mensaje = "Los siguientes productos están sin stock y necesitan reposición:\n";
                    foreach (DataRow row in tablaProductos.Rows)
                    {
                        mensaje += $"- {row["Nombre"]}\n";
                    }
                    MessageBox.Show(mensaje, "Alerta de Reposición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable DatosProductos()
        {
            // Tabla virtual que se llena con los datos Nombre y stock de la tabla productos
            DataTable tablaProductos = new DataTable();
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Nombre, Stock FROM Productos";
               
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);
            } catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            return tablaProductos;
        }   
        public DataTable DatosCategorias()
        {
            DataTable tablaCategorias = new DataTable();
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Categoria, COUNT(*) AS Cantidad FROM Productos GROUP BY Categoria";

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaCategorias);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tablaCategorias;
        }
    }
}
