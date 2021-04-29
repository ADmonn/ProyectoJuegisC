using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProyectoJuegis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] matrizJuego = { { "FIFA", "DEPORTES", "200kb", "200000", "200" },
                                  { "CALL_OF_DUTY","ACCION","180kb","190000","1000" },
                                  { "NFS", "VELOCIDAD","1500Kb","160000","50" },
                                  { "LEAGUE_OF_LEGENDS","AVENTURA","130KB","140000","100"}
        };
        int[] vectorVentas = { 0, 0, 0, 0 };
        int indiceJuegoSeleccionado = -1;
        double descuento = 0, subtotal = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < matrizJuego.GetLength(0); i++)
            {
                cmbJuegos.Items.Add(matrizJuego[i, 0]);
            }
        }


        private void cmbJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceJuegoSeleccionado = cmbJuegos.SelectedIndex;
            textNombre.Text = matrizJuego[indiceJuegoSeleccionado, 0];
            textCategoria.Text = matrizJuego[indiceJuegoSeleccionado, 1];
            textTamaño.Text = matrizJuego[indiceJuegoSeleccionado, 2];
            textPrecio.Text = matrizJuego[indiceJuegoSeleccionado, 3];
            textDisponibles.Text = matrizJuego[indiceJuegoSeleccionado, 4];
            switch (indiceJuegoSeleccionado)
            {
                case 0:
                    ptbJuego.Image = ProyectoJuegis.Properties.Resources.fifa;
                    break;
                case 1:
                    ptbJuego.Image = ProyectoJuegis.Properties.Resources.call;
                    break;
                case 2:
                    ptbJuego.Image = ProyectoJuegis.Properties.Resources.nft;
                    break;
                case 3:
                    ptbJuego.Image = ProyectoJuegis.Properties.Resources.lol;
                    break;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El subtotal es " + subtotal + "\n+ El descuento es " + descuento + "%\n" + "El valor del descuento es " +
                subtotal * descuento / 100 + "\n El total a pagar es " + (subtotal - (subtotal * descuento / 100)));

            subtotal = 0;
            descuento = 0;
            btnComprar.Enabled = true;
            btnFinalizar.Enabled = false;
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            int cantidadCompra;
            cantidadCompra = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la cantidad a comprar", "Compra", "0"));

            matrizJuego[indiceJuegoSeleccionado, 4] =
                (int.Parse(matrizJuego[indiceJuegoSeleccionado, 4]) + cantidadCompra).ToString();
            textDisponibles.Text = matrizJuego[indiceJuegoSeleccionado, 4];
        }

        private void btnBuscarJuego_Click(object sender, EventArgs e)
        {
            int presupuesto, tamanio;
            Busqueda busqueda = new Busqueda();
            busqueda.ShowDialog();
            presupuesto = int.Parse(busqueda.textPresupuesto.Text);
            tamanio = int.Parse(busqueda.textTamanio.Text);
            if (presupuesto>50000 && presupuesto<140000 && tamanio > 100 && tamanio < 140)
            {
                MessageBox.Show("El juego mas apropiado es "+matrizJuego[3,0]);
            }
            else if (presupuesto > 140000 && presupuesto < 180000 && tamanio > 150 && tamanio < 180)
            {
                MessageBox.Show("EL juego mas apropiado es "+matrizJuego[2,0]);
            }
            else if (presupuesto >= 180000 && presupuesto < 190000 && tamanio >= 180 && tamanio < 190)
            {
                MessageBox.Show("EL juego mas apropiado es " + matrizJuego[1, 0]);
            }
            else if (presupuesto > 190000 && presupuesto < 210000 && tamanio >= 190 && tamanio < 210)
            {
                MessageBox.Show("EL juego mas apropiado es " + matrizJuego[0, 0]);
            }
            else
            {
                MessageBox.Show("No tenemos juego con esas caracteristicas");
            }
        }

        private void btnJuegoMasVendido_Click(object sender, EventArgs e)
        {
            int mayor = 0,res=0;

            for (int i = 0; i < 4; i++)
            {
                if (vectorVentas[i] > mayor)
                {
                    mayor = vectorVentas[i];
                    res = i;
                }
            }

            if (res == 0)
            {
                MessageBox.Show("FIFA");
            }else if(res == 1)
            {
                MessageBox.Show("CAll OF DUTTY");
            }
            else if (res == 2)
            {
                MessageBox.Show("NFS ");
            }
            else if (res == 3)
            {
                MessageBox.Show("LEAGUE OF LEGENDS");
            }
            else
            {
                MessageBox.Show("No hay juego vendidos");
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            btnFinalizar.Enabled = true;
            btnComprar.Enabled = false;
            int cantidadVendida;
            cantidadVendida = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la cantidad a vender", "venta", "0"));
            if (cantidadVendida <= int.Parse(matrizJuego[indiceJuegoSeleccionado, 4]))
            {
                vectorVentas[indiceJuegoSeleccionado] += cantidadVendida;
                matrizJuego[indiceJuegoSeleccionado, 4] =
                (int.Parse(matrizJuego[indiceJuegoSeleccionado, 4]) - cantidadVendida).ToString();
                textDisponibles.Text = matrizJuego[indiceJuegoSeleccionado, 4];

                if (cantidadVendida >= 25 && matrizJuego[indiceJuegoSeleccionado, 1] == "ACCION")
                {
                    descuento = 15;
                }
                else if (descuento < 10 && cantidadVendida >= 32 && matrizJuego[indiceJuegoSeleccionado, 0] == "FIFA"
                    || cantidadVendida >= 12 && matrizJuego[indiceJuegoSeleccionado, 1] == "DEPORTES"
                    || cantidadVendida >= 15 && matrizJuego[indiceJuegoSeleccionado, 1] == "VELOCIDAD")
                {
                    descuento = 10;
                }
                subtotal += cantidadVendida * int.Parse(matrizJuego[indiceJuegoSeleccionado, 3]);
            }
            else
            {
                MessageBox.Show("No disponemos de la cantidd seleccionada");
            }
        }
    }
}
