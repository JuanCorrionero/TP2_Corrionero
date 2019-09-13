using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            bool Anduvo = true;
            try
            {
                categoria.Descripcion = txtNombre.Text;
                negocio.Agregar(categoria);
            }

            catch (SqlException ex)
            {
                Anduvo = false;
                SqlError err = ex.Errors[0];
                if(err.Number == 2627)
                {
                    MessageBox.Show("Esta categoría ya existe! Ingrese otra diferente.");
                }
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
                    MessageBox.Show("Categoria agregada correctamente!");
                }
                Dispose();
            }
            
        }
    }
}
