using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_clases.Class
{
    public class Docentes : Empleados
    {
        public string Materias { get; set; }

        public Docentes(string nombre, int edad, string puesto, string materias) : base(nombre, edad, puesto)
        {

            Materias = materias;
        }
        public override void Presentarse()
        {
            base.Presentarse();
            Console.WriteLine($"Soy docente de las materias: {Materias}");
        }
    }
}