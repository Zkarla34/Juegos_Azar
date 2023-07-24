using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoss
{
    public class Ppt : IJuego
    {
        public void finalizarJuego()
        {
            Form1 f1 = new Form1();
            Form1.ActiveForm.Visible = false;
            f1.Show();
        }

        public int generarAleatorio()
        {
            Random ppt = new Random();
            return ppt.Next(0, 3);
        }
    }
}
