using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte_3B_Jeancarlosmosquera
{
    class Pelicula
    {
        public string peli;
        private string nombre { get; set; }

        internal Salas Salas
        {
            get => default;
            set
            {
            }
        }

        public Pelicula(string nombre)
        {
            this.nombre = nombre;
        }
        public void EleccionPelicula()
        {
            Console.WriteLine("----------LISTA PELICULAS---------");
            Pelicula pelicula1 = new Pelicula("1.-John Wick 3 ");
            Pelicula pelicula2 = new Pelicula("2.-Spider-Man: No Way Home");
            Pelicula pelicula3 = new Pelicula("3.-Avengers");
            Pelicula pelicula4 = new Pelicula("4.-Eternals");
            Pelicula pelicula5 = new Pelicula("5.-Pikachu");


            List<Pelicula> ListaPelicula = new List<Pelicula>();



            ListaPelicula.Add(pelicula1);
            ListaPelicula.Add(pelicula2);
            ListaPelicula.Add(pelicula3);
            ListaPelicula.Add(pelicula4);
            ListaPelicula.Add(pelicula5);

            foreach (Pelicula i in ListaPelicula)
            {
                Console.WriteLine(i.nombre);
            }

            int opcion;
            do
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion < 1 || opcion > 5)
                {
                    Console.Write("Ingrese un numero de pelicula valido: ");
                }
                if (opcion == 1)
                {
                    peli = "Jhon Wick 3";
                }
                if (opcion == 2)
                {
                    peli = "Spider-Man: No Way Home";
                }
                if (opcion == 3)
                {
                    peli = "Avengers";
                }
                if (opcion == 4)
                {
                    peli = "Eternals";
                }
                if (opcion == 5)
                {
                    peli = "Pikachu";
                }
            } while (opcion <= 0 || opcion > 5);

        }
        public void pelicula()
        {
            Console.WriteLine("Ha escogido la pelicula: " + peli);
        }


    }
}
