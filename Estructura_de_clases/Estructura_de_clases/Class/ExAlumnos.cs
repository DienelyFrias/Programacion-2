using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_clases.Class
{
    public class ExAlumnos : MiembroDeLaComunidad
    {
        public string Profesion { get; set; }

        public ExAlumnos(string nombre, int edad, string profesion) : base(nombre, edad)
        {
            Profesion = profesion;
        }

        public void Presentarse()
        {
            Console.WriteLine($"Soy un Exalumno de ITLA y mi profesion es {Profesion}");
        }
    }
}

