using System;

delegate void ReproductorEvento(string mensaje);



class Program {
    static void ManejarInicioCancion(string mensaje) {
        Console.WriteLine($"Mensaje recibido: {mensaje}");
    }

    static void Main(string[] args) {
        string Cancion;

        ReproductorMusica reproductor = new ReproductorMusica();

        reproductor.CancionComenzada += ManejarInicioCancion;
        Cancion = Console.ReadLine();
        reproductor.IniciarCancion(Cancion);

        
    }
}

class ReproductorMusica
{
    public event ReproductorEvento CancionComenzada;

    public void IniciarCancion(string nombreCancion)
    {
        Console.WriteLine($"Reproduciendo: {nombreCancion}");
        if (CancionComenzada != null)
        {
            CancionComenzada($"Comenzó a reproducirse: {nombreCancion}");
        }
    }
}