using System;

namespace Aporte_3B_Jeancarlosmosquera
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula pelicula = new Pelicula("");
            Asientos asiento = new Asientos();
            Salas sala = new Salas();
            Cliente nombre = new Cliente();
            Aperitivos aperitivos = new Aperitivos();
            // elegir de la pelicula
            pelicula.EleccionPelicula();
            //elegir sala y asiento segun sala
            sala.Disponibles();
            //elegir aperitivos
            
            aperitivos.EleccionAperitivo();
            aperitivos.EleccionBebida();
            //MUESTRA LOS DATOS 
            Console.WriteLine("---------------------");
            Console.WriteLine("**********************");
            Console.WriteLine("*********************");
            Console.WriteLine("*********INFORMACIÓN DETALLADA DEL USUARIO****");
             
            nombre.Nombre();
                   
            pelicula.pelicula();
            
            asiento.Eleccion();
            
            sala.SalaEscogida();
            
            aperitivos.MostrarAperitivos();
            Console.WriteLine("*********************");
            Console.WriteLine("********************");
        }
    }
}
