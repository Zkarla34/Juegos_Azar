using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoss
{
    public interface IJuego
    {
        int generarAleatorio();
        void finalizarJuego();
    }
}
