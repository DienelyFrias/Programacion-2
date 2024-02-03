class Maestros
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Rol { get; set; }
    public string Materia { get; set; }
    public string Especialidad { get; set; }

    public Maestros(string nombre, int edad, string rol, string materia, string especialidad)
    {
        Nombre = nombre;
        Edad = edad;
        Rol = rol;
        Materia = materia;
        Especialidad = especialidad;
    }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, soy el {Rol} {Nombre}, tengo {Edad} años. Enseño {Materia} y tengo especialidad en {Especialidad}");
    }
}
