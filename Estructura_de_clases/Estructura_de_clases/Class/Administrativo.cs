using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_clases.Class
{
    internal class Administrativo : Empleados
    {
        public string Funcion {  get; set; }

        public Administrativo(string nombre, int edad, string puesto, string funcion) : base (nombre, edad, puesto)
        {
            
            Funcion= funcion;
        }
    }
}
