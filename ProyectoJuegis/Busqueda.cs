using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJuegis
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textPresupuesto.Text != "" && textTamanio.Text != "")
            {
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Debe ingresar los datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            textTamanio.Text = "0";
            textPresupuesto.Text = "0";
            this.Hide();
        }
    }
}
