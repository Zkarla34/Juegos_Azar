using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoss
{
    public class Dados : IJuego
    {
        public void finalizarJuego()
        {
            Form1 f1 = new Form1();
            Form1.ActiveForm.Visible = false;
            f1.Show();
        }

        public int generarAleatorio()
        {
            Random rnd = new Random();
            return rnd.Next(1,7);

           // Random qgonorrea = new Random();
           // return qgonorrea.Next(1,7);
        }
    }
}
