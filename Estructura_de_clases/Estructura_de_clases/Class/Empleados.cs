using System;

namespace Estructura_de_clases
{
    public class Empleados
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Puesto { get; set; }

        public Empleados(string nombre, int edad, string puesto)
        {
            Nombre = nombre;
            Edad = edad;
            Puesto = puesto;
        }

        public virtual void Presentarse()
        {
            Console.WriteLine($"Hola, soy {Nombre}, tengo {Edad} años y trabajo como {Puesto}");
        }
    }
}
