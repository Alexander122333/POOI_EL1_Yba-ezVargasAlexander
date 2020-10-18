using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    public class Libro

    {
        public static int contador = 0;
        public string codLibro { get; set; }
        public string nomLibro { get; set; }
        public DateTime fecRegistro { get; set; }
        public string genero { get; set; }
        public string nomAutor { get; set; }

        //Metodo
        public string generaCodigo()
        {
            contador++;
            return "LIB-" + contador.ToString("000");
        }

    }
}
