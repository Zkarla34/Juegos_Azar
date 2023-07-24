using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juegoss
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
        private void btnapuestacs_Click(object sender, EventArgs e)
        {
            Carisellazo juego1 = new Carisellazo();

            int moneda = juego1.generarAleatorio();
            int eleccion = opcioncs.SelectedIndex;

            Jugador jugador = new Jugador();
            jugador.Nombre = lbnombrecs.Text;
            jugador.Total = int.Parse(lbtotalcs.Text);

            if (moneda == 0 && eleccion == 0)
            {

                lbtotalcs.Text = jugador.aumentarTotal(int.Parse(textapuestacs.Text)).ToString();
                MessageBox.Show("Escogiste Cara, salió la cara Ganaste!" + eleccion + moneda);


            }
            else if (moneda == 0 && eleccion == 1)
            {
                //Disminuir total
                lbtotalcs.Text = jugador.disminuirTotal(int.Parse(textapuestacs.Text)).ToString();
                MessageBox.Show("Escogiste Sello, salió cara Perdiste!" + eleccion + moneda);

            }
            else if (moneda == 1 && eleccion == 1)
            {
                //pbmoneda.Image = Image.FromFile("monedasello.jpg");
                lbtotalcs.Text = jugador.aumentarTotal(int.Parse(textapuestacs.Text)).ToString();
                MessageBox.Show("Escogiste Sello, salió sello Gane!" + eleccion + moneda);

            }
            else if (moneda == 1 && eleccion == 0)
            {
                //pbmoneda.Image = Image.FromFile("monedasello.jpg");
                lbtotalcs.Text = jugador.disminuirTotal(int.Parse(textapuestacs.Text)).ToString();
                MessageBox.Show("Escogiste Cara, salió sello Perdiste!" + eleccion + moneda);

            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Carisellazo salir = new Carisellazo();
            salir.finalizarJuego();
        }
    }
}


