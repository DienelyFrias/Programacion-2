using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_clases.Class
{


    public abstract class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }


        public MiembroDeLaComunidad(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void Presentarse()
        {
            Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años");
        }
    }
}
