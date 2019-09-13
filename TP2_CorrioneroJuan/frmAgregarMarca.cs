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
using Dominio;
using Negocio;

namespace TP2_CorrioneroJuan
{
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            bool anduvo = true;
            try
            {
                marca.Descripcion = txtNombreMarca.Text;
                negocio.Agregar(marca);
            }

            catch (SqlException ex)
            {
                anduvo = false;
                SqlError err = ex.Errors[0];
                if (err.Number == 2627)
                {
                    MessageBox.Show("Esta marca ya existe! Ingrese otra diferente.");
                }
            }

            catch (Exception ex)
            {
                anduvo = false;
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                if (anduvo == true)
                {
                    MessageBox.Show("Marca agregada correctamente!");
                    Dispose();
                }
            }

        }
    }
}
