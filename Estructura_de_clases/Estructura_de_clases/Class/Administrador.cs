using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_clases.Class
{
    public class Administrador : Docentes
    {
        public string Rol { get; set; }

        public Administrador(string nombre, int edad, string cargo, string materia, string rol) : base(nombre, edad, cargo, materia)
        {
            Rol = rol;
        }
    }
}