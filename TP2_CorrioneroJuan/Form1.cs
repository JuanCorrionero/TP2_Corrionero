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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void tlSpButton_Listar_Click(object sender, EventArgs e)
        {
            frm_Listar Listar = new frm_Listar();
           // Listar.MdiParent = this;
            Listar.Show();
        }

        private void tlSpButton_Buscar_Click(object sender, EventArgs e)
        {
            frm_Buscar Buscar = new frm_Buscar();
           // Buscar.MdiParent = this;
            Buscar.Show();
        }

        private void tlSpButton_Agregar_Click(object sender, EventArgs e)
        {
            frm_Agregar Agregar = new frm_Agregar();
           // Agregar.MdiParent = this;
            Agregar.Show();
        }
    }
}
