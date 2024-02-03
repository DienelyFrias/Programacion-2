class Estudiantes
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Clase { get; set; }

    public Estudiantes(string nombre, int edad, string clase)
    {
        Nombre = nombre;
        Edad = edad;
        Clase = clase;
    }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, soy {Nombre}, tengo {Edad} años y estoy en la clase {Clase}");
    }
}
