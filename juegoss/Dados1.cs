using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoss
{
    public class Dados1 : IJuego
    {
        public void finalizarJuego()
        {
            throw new NotImplementedException();
        }

        public int generarAleatorio()
        {
            Random rnd1 = new Random();
            return rnd1.Next(1, 7);
        }
    }
}
