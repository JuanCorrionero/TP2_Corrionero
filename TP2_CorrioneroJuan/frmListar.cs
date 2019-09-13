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
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> lista;
            try
            {
                lista = negocio.Listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }
}
