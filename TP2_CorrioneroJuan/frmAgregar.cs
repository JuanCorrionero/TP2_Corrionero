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
    }
}
