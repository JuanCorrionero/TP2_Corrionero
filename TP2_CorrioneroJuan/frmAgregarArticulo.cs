using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP2_CorrioneroJuan
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
            cboBoxCategoria.DataSource = categoriaNegocio.listar();
            cboBoxMarca.DataSource = marcaNegocio.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog adjuntar = new OpenFileDialog();
                adjuntar.InitialDirectory = "c:\\";
                adjuntar.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (adjuntar.ShowDialog() == DialogResult.OK)
                {
                    txtPathImagen.Text = adjuntar.FileName;
                    picBoxImagen.ImageLocation = adjuntar.FileName;
                }
                else
                {
                    MessageBox.Show("No se seleccionó imagen.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            bool Anduvo = true;
            try
            {
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);
                articulo.Imagen = picBoxImagen.ImageLocation;
                articulo.Categoria = (Categoria)cboBoxCategoria.SelectedItem;
                articulo.Marca = (Marca)cboBoxMarca.SelectedItem;


                negocio.agregar(articulo);
                

                Dispose();
            }
            catch (Exception ex)
            {
                Anduvo = false;
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                if (Anduvo == true)
                {
                MessageBox.Show("Artículo agregado con éxito!");
                }
                Dispose();
            }
            
        }

    }
}
