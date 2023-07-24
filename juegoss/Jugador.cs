using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoss
{
    public class Jugador
    {
        //Atributos
        private string nombre;
        private int total;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Total { get => total; set => total = value; }


        //Métodos

        public int aumentarTotal(int apuesta)
        {
            total = total + apuesta;
            return total;
        }

        public int disminuirTotal(int apuesta)
        {
            total = total - apuesta;
            return total;
        }

    }
}
