using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoss
{
    public class Carisellazo : IJuego
    {
        public void finalizarJuego()
        {
            Form1 f1 = new Form1();
            Form1.ActiveForm.Visible = false;
            f1.Show();
        }

        public int generarAleatorio()
        {
            Random moneda = new Random();

            return moneda.Next(0, 2);
        }
    }
}
