using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TP2_CorrioneroJuan
{
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoria = new Categoria();
            try
            {
                categoria.Descripcion = txtNombre.Text;
                negocio.Agregar(categoria);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            finally
            {
                MessageBox.Show("Categoria agregada correctamente!");
                Dispose();
            }
            
        }
    }
}
