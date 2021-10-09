using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace AppAdmin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void rbCompras_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCompras.Checked)
            {
                dgvCompras.Show();
                actualizarCompras();
            }
            else if (!rbCompras.Checked)
                dgvCompras.Hide();
                
        }

        private void rbSouvenirs_CheckedChanged(object sender, EventArgs e)
        {

            if (rbSouvenirs.Checked)
            {
                btnAlta.Show();
                btnBaja.Show();
                btnModificar.Show();
                dgvSouvenirs.Show();
            } else if (!rbSouvenirs.Checked)
            {
                btnAlta.Hide();
                btnBaja.Hide();
                btnModificar.Hide();
                dgvSouvenirs.Hide();
            }
        }


        private void actualizarCompras()
        {
            DataTable compras = CompraController.listarComrpas();
            dgvCompras.DataSource = compras;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
