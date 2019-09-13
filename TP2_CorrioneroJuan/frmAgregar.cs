using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_CorrioneroJuan
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo AgregarArticulo = new frmAgregarArticulo();
            AgregarArticulo.ShowDialog();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca AgregarMarca = new frmAgregarMarca();
            AgregarMarca.ShowDialog();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria AgregarCategoria = new frmAgregarCategoria();
            AgregarCategoria.ShowDialog();
        }
    }
}
