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
    public partial class frmVentanaPrincipal : Form
    {

        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar Agregar = new frmAgregar();
            Agregar.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar Buscar = new frmBuscar();
            Buscar.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListar Listar = new frmListar();
            Listar.ShowDialog();
        }
    }
}
