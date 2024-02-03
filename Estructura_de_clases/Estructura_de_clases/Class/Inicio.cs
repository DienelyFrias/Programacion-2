using System;

namespace Estructura_de_clases.Class
{
    class Inicio
    {
        static void Main(string[] args)
        {
            Estudiantes estudiante = new Estudiantes("Dienely", 20, "2B2" + "\n");
            estudiante.Presentarse();

            Maestros maestro = new Maestros("Teofilo", 45, "Maestro", "Educacion Fisica y Ajedrez", "Educacion Fisica" + "\n");
            maestro.Presentarse();

            Empleados empleado = new Empleados("Juan", 50, "Guardia de seguridad" + "\n" );
            empleado.Presentarse();

            ExAlumnos exalumno = new ExAlumnos("Pepe", 25, "Ingeniería en Software" + "\n");
            exalumno.Presentarse();
        }
    }
}