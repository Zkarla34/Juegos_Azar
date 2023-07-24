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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btndados_Click(object sender, EventArgs e)
        {
            Dados juego1 = new Dados();
            Dados juego2 = new Dados();
            Jugador jugador = new Jugador();
            jugador.Nombre = lbnombred.Text;
            jugador.Total = int.Parse(lbtotald.Text);

            int dado1 = juego1.generarAleatorio();
            int dado2 = juego2.generarAleatorio();

            int suma = dado1 + dado2;

            if (dado1 == 1 && dado2 == 1) //gana
            {
                lbtotald.Text = jugador.aumentarTotal(int.Parse(apostard.Text)).ToString();
                MessageBox.Show($"Dado 1: {dado1} \n Dado 2: {dado2 }, Haz Ganado!!");
       
            }
            else if((suma == 3) || (suma == 11) || (suma == 12) || (suma == 7)) //gana
            {
                lbtotald.Text = jugador.aumentarTotal(int.Parse(apostard.Text)).ToString();
                MessageBox.Show($"Dado 1: {dado1} \n Dado 2: {dado2 } \n La suma es: {suma}, Haz Ganado!!");

            }
            else //pierde
            {
                lbtotald.Text = jugador.disminuirTotal(int.Parse(apostard.Text)).ToString();
                MessageBox.Show($"Dado 1: {dado1} \n Dado 2: {dado2 }, Haz Perdido!!");
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Dados salir = new Dados();
            salir.finalizarJuego();
        }
    }
}
