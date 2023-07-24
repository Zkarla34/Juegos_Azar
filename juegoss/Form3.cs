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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             Ppt juego = new Ppt();

             int maquina = juego.generarAleatorio();
             int turno = opcionppt.SelectedIndex;

             Jugador jugador = new Jugador();
             jugador.Nombre = lbnombreppt.Text;
             jugador.Total = int.Parse(lbtotalppt.Text);



            // Empates
            
            if (turno == 0 && maquina == 0)
            {
                
                MessageBox.Show($"Jugador: Piedra \n Maquina: Piedra. \n EMPATE");
            }
            else if (turno == 1 && maquina == 1)
            {
                MessageBox.Show($"Jugador: Papel \n Maquina: Papel. \n EMPATE");
            }
            else if (turno == 2 && maquina == 2)
            {
                MessageBox.Show($"Jugador:Piedra \n Maquina: Piedra. \n EMPATE");
            }

            //PIEDRA
            if (turno == 0 && maquina == 1)
            {
                lbtotalppt.Text = jugador.disminuirTotal(int.Parse(textapuestappt.Text)).ToString();
                MessageBox.Show($"Jugador: Piedra \n Maquina: Papel. \n GANA PAPEL");
            }
            else if (turno == 0 && maquina == 2)
            {
                lbtotalppt.Text = jugador.aumentarTotal(int.Parse(textapuestappt.Text)).ToString();
                MessageBox.Show($"Jugador: Piedra \n Maquina: Tijera. \n GANA LA PIEDRA");
            }
            //PAPEL
            else if (turno == 1 && maquina == 0)
            {
                lbtotalppt.Text = jugador.aumentarTotal(int.Parse(textapuestappt.Text)).ToString();
                MessageBox.Show($"Jugador: Papel \n Maquina: Piedra. \n GANA PAPEL");
            }
            else if (turno == 1 && maquina == 2)
            {
                lbtotalppt.Text = jugador.disminuirTotal(int.Parse(textapuestappt.Text)).ToString();
                MessageBox.Show($"Jugador: Papel \n Maquina: Tijera. \n GANA TIJERA");
            }
            //TIJERAS
            else if (turno == 2 && maquina == 0)
            {
                lbtotalppt.Text = jugador.disminuirTotal(int.Parse(textapuestappt.Text)).ToString();
                MessageBox.Show($"Jugador: Tijera \n Maquina: Piedra. \n GANA PIEDRA");
            }
            else if (turno == 2 && maquina == 1)
            {
                lbtotalppt.Text = jugador.aumentarTotal(int.Parse(textapuestappt.Text)).ToString();
                MessageBox.Show($"Jugador: Tijera \n Maquina: Papel. \n GANA TIJERAS");
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Ppt salir = new Ppt();
            salir.finalizarJuego();
        }
    }
}       
    
